using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using AddressBook.Helper;
using AddressBook.Contracts;
using AddressBook.Entities.ResponseTypes;
using Microsoft.Extensions.Logging;

namespace AddressBook.Services
{
    public class Service : IService
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IAddressBookRepository _userRepository;
        private readonly ILogger _logger;

        public Service(IConfiguration config, IMapper mapper, IAddressBookRepository UserRepository, ILogger logger)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userRepository = UserRepository ?? throw new ArgumentNullException(nameof(UserRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        ///<summary>
        ///store and update details in asset 
        ///</summary>
        public FileResultDto StoreImage(Guid userId, IFormFile file, Guid authId)
        {
            Guid fileId;
            using (MemoryStream ms = new MemoryStream())
            {
                Asset ImageEntity = StoreImageInDb(ms, userId, file, authId);
                fileId = ImageEntity.Id;
            }
            return new FileResultDto() { Id = fileId, Size = file.Length, FileName = file.Name };
        }

        ///<summary>
        ///store image in database
        ///</summary>
        public Asset StoreImageInDb(MemoryStream ms, Guid userId, IFormFile file, Guid authId)
        {
            file.CopyTo(ms);
            byte[] fileBytes = ms.ToArray();

            AssetCreatingDto imageCreateDto = new AssetCreatingDto();
            imageCreateDto.File = Convert.ToBase64String(fileBytes);
            imageCreateDto.UserId = userId;
            Asset ImageEntity = _mapper.Map<Asset>(imageCreateDto);
            ImageEntity.CreatedBy = authId;
            ImageEntity.CreatedAt = DateTime.Now.ToString();
            _userRepository.UploadImage(ImageEntity);
            _userRepository.Save();
            return ImageEntity;
        }

        ///<summary>
        ///return meta data by key
        ///</summary>
        public ICollection<RefSetDto> MetaDataUpdate(string keyword)
        {
            RefTerm RefTermFromRepo = _userRepository.GetRefTerm(keyword);
            IEnumerable<Guid> ResultFromRepo = _userRepository.GetRefSetGroup(RefTermFromRepo.RefTermId);
            IEnumerable<RefSet> RefSetFromRepo = _userRepository.GetRefSet(ResultFromRepo);
            IEnumerable<RefSetDto> value = _mapper.Map<IEnumerable<RefSetDto>>(RefSetFromRepo);
            return value.ToList();
        }

        ///<summary>
        ///create session token
        ///</summary>
        public string CreateJWTToken(User userData)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSecret:Key"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            Claim[] claims = new[] {
         new Claim(JwtRegisteredClaimNames.Sub, userData.Id.ToString()),
         new Claim(JwtRegisteredClaimNames.Sub, userData.LastName),
         new Claim(JwtRegisteredClaimNames.Sub, userData.Password),
         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            JwtSecurityToken token = new JwtSecurityToken(_config["JwtSecret:Issuer"],
                _config["JwtSecret:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(290),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        ///<summary>
        ///create new user in db
        ///</summary>
        public Guid CreateUser(UserCreatingDto user, Guid authId)
        {
            User userResult = _mapper.Map<User>(user);
            userResult.CreatedAt = DateTime.Now.ToString();
            userResult.CreatedBy = authId;
            _userRepository.CreateUser(userResult);
            _userRepository.Save();

            UserDto userDetail = _mapper.Map<UserDto>(userResult);
            return userDetail.Id;
        }

        ///<summary>
        ///compare password
        ///</summary>
        public bool ComparePassword(string userPass, string dbPass)
        {
            return userPass == dbPass ? true : false;
        }

        ///<summary>
        ///get all address book based on filter
        ///</summary>
        public List<User> GetAllAddressBook(PageSortParam pageSortParam)
        {
            IEnumerable<User> foundedUserList = _userRepository.GetAllUsers();
            PaginationHandler<User> list = new PaginationHandler<User>(pageSortParam);
            return list.GetData(foundedUserList);
        }

        ///<summary>
        ///update address book in database
        ///</summary>
        public IEnumerable<UserDto> UpdateAddressBookDetail(List<User> users)
        {
            foreach (User user in users)
            {
                user.Emails = _userRepository.GetEmailIds(user.Id).ToList();
                user.Addresses = _userRepository.GetAddressIds(user.Id).ToList();
                user.Phones = _userRepository.GetPhoneIds(user.Id).ToList();
                user.Assets = _userRepository.GetAssetIds(user.Id).ToList();
            }
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        ///<summary>
        ///get single address book detais
        ///</summary>
        public UserDto UpdateSingleAddressBookDetail(User user)
        {
            user.Emails = _userRepository.GetEmailIds(user.Id).ToList();
            user.Addresses = _userRepository.GetAddressIds(user.Id).ToList();
            user.Phones = _userRepository.GetPhoneIds(user.Id).ToList();
            user.Assets = _userRepository.GetAssetIds(user.Id).ToList();

            return _mapper.Map<UserDto>(user);
        }

        ///<summary>
        ///delete address book in database
        ///</summary>
        public void DeleteAddressBook(User user)
        {
            _userRepository.DeleteUser(user);
            _userRepository.Save();
        }

        ///<summary>
        ///update address book details
        ///</summary>
        public void UpdateAddressBook(Guid userId, UserUpdatingDto userInput, User userFromRepo, Guid authId)
        {
            List<Email> emailCollection = _userRepository.GetEmailIds(userId).ToList();
            List<Phone> phCollection = _userRepository.GetPhoneIds(userId).ToList();
            List<Address> addressCollection = _userRepository.GetAddressIds(userId).ToList();
            for (int i = 0; i < emailCollection.Count; i++)
            {
                userInput.Emails.ElementAt(i).Id = emailCollection[i].Id;
            }
            for (int i = 0; i < addressCollection.Count; i++)
            {
                userInput.Addresses.ElementAt(i).Id = addressCollection[i].Id;
            }
            for (int i = 0; i < phCollection.Count; i++)
            {
                userInput.Phones.ElementAt(i).Id = phCollection[i].Id;
            }

            _mapper.Map(userInput, userFromRepo);
            userFromRepo.UpdatedAt = DateTime.Now.ToString();
            userFromRepo.UpdatedBy = authId;
            _userRepository.UpdateUser(userFromRepo);
            _userRepository.Save();
        }

        public ValidateInputResponse ValidateUserInputCreate(UserCreatingDto user)
        {
            //check email & type
            foreach (EmailCreatingDto item in user.Emails)
            {
                if (_userRepository.IsEmailExist(item.EmailAddress))
                {
                    _logger.LogError("Email is already exist");
                    return new ValidateInputResponse() { errorMessage = "Email is already exist", errorCode = 409 };
                }
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Email type is not exist");
                    return new ValidateInputResponse() { errorMessage = "Email type is not exist", errorCode = 404 };
                }
            }
            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            {
                _logger.LogError("Dont enter same email multiple time");
                return new ValidateInputResponse() { errorMessage = "Dont enter same email multiple time", errorCode = 409 };
            }

            foreach (PhoneNumberCreatingDto item in user.Phones)
            {
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Phone number type is not exist");
                    return new ValidateInputResponse() { errorMessage = "Phone number type is not exist", errorCode = 404 };
                }

                if (_userRepository.IsPhoneExist(item.PhoneNumber))
                {
                    _logger.LogError("Phone number is already exist");
                    return new ValidateInputResponse() { errorMessage = "phone number is already exist", errorCode = 409 };
                }
            }
            if (user.Phones.GroupBy(x => x.PhoneNumber).Any(g => g.Count() > 1))
            {
                _logger.LogError("dont enter same ph number multiple time");
                return new ValidateInputResponse() { errorMessage = "Dont enter same phone number multiple time", errorCode = 409 };
            }

            //check address & type
            foreach (AddressCreatingDto item in user.Addresses)
            {
                if (!_userRepository.IsMetadataExist(item.Country))
                {
                    _logger.LogError($"Countrytype is not exist{item.Country}");
                    return new ValidateInputResponse() { errorMessage = "country type is not exist", errorCode = 404 };
                }

                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Addresstype is not exist");
                    return new ValidateInputResponse() { errorMessage = "Addresstype is not exist", errorCode = 404 };
                }
            }

            return new ValidateInputResponse() { errorMessage = "no error", errorCode = 200 };
        }
        public ValidateInputResponse ValidateUserInputUpdate(UserUpdatingDto user, Guid id)
        {
            foreach (EmailUpdatingDto item in user.Emails)
            {
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Email type is not exist");
                    return new ValidateInputResponse() { errorMessage = "Phone number type is not exist", errorCode = 404 };
                }

                if (_userRepository.IsEmailExistUpdate(item.EmailAddress, id))
                {
                    _logger.LogError("Email is already exist");
                    return new ValidateInputResponse() { errorMessage = "Email is already exist", errorCode = 409 };
                }
            }

            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            {
                _logger.LogError("dont enter same email multiple time");
                return new ValidateInputResponse() { errorMessage = "Email is already exist", errorCode = 409 };
            }

            foreach (PhoneNumberUpdatingDto item in user.Phones)
            {

                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Phone number type is not exist");
                    return new ValidateInputResponse() { errorMessage = "Phone number type is not exist", errorCode = 404 };

                }

                if (_userRepository.IsPhoneExistUpdate(item.PhoneNumber, id))
                {
                    _logger.LogError("Phone number is already exist");
                    return new ValidateInputResponse() { errorMessage = "Phone number type is not exist", errorCode = 404 };

                }
            }

            if (user.Phones.GroupBy(x => x.PhoneNumber).Any(g => g.Count() > 1))
            {
                _logger.LogError("dont enter same ph number multiple time");
                return new ValidateInputResponse() { errorMessage = "Email is already exist", errorCode = 409 };
            }

            foreach (AddressUpdatingDto item in user.Addresses)
            {
                if (!_userRepository.IsMetadataExist(item.Country))
                {
                    _logger.LogError($"Countrytype is not exist{item.Country}");
                    return new ValidateInputResponse() { errorMessage = "country type is not exist", errorCode = 404 };
                }
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Addresstype is not exist");
                    return new ValidateInputResponse() { errorMessage = "address type is not exist", errorCode = 404 };
                }
            }

            return new ValidateInputResponse() { errorMessage = "no error", errorCode = 200 };
        }
        public UserCreatingDto UpdateUserDetailsForCreate(UserCreatingDto user, Guid authId)
        {
            foreach (EmailCreatingDto item in user.Emails)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
            }
            foreach (PhoneNumberCreatingDto item in user.Phones)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();

            }
            foreach (AddressCreatingDto item in user.Addresses)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (_userRepository.TypeFinder(item.Country)).Id.ToString();
            }
            return user;

        }

        public UserUpdatingDto UpdateUserDetailsForUpdate(UserUpdatingDto user, Guid authId)
        {
            foreach (EmailUpdatingDto item in user.Emails)
            {
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }
            foreach (PhoneNumberUpdatingDto item in user.Phones)
            {
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;

            }
            foreach (AddressUpdatingDto item in user.Addresses)
            {
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (_userRepository.TypeFinder(item.Country)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }
            return user;

        }


    }
}