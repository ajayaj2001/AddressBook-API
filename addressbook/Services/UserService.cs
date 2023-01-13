using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Helper;
using AddressBook.Contracts;
using AddressBook.Entities.ResponseTypes;
using Microsoft.Extensions.Logging;
using AddressBook.Repositories;

namespace AddressBook.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public UserService(IMapper mapper, IUserRepository UserRepository, ILogger logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userRepository = UserRepository ?? throw new ArgumentNullException(nameof(UserRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        ///<summary>
        ///create new user in db
        ///</summary>
        ///<param name="authId"></param>
        ///<param name="user"></param>
        public Guid CreateUser(CreateUserDto user, Guid authId)
        {
            if (authId == null)
                throw new Exception("empty auth");

            User userResult = _mapper.Map<User>(user);
            userResult.CreatedAt = DateTime.Now.ToString();
            userResult.CreatedBy = authId;
            _userRepository.CreateUser(userResult);
            _userRepository.Save();

            UserDto userDetail = _mapper.Map<UserDto>(userResult);
            return userDetail.Id;
        }

        ///<summary>
        ///get all address book based on filter
        ///</summary>
        ///<param name="pageSortParam"></param>
        public List<User> GetAllAddressBook(PageSortParam pageSortParam)
        {
            IEnumerable<User> foundedUserList = _userRepository.GetAllUsers();
            PaginationHandler<User> list = new PaginationHandler<User>(pageSortParam);
            return list.GetData(foundedUserList);
        }

        ///<summary>
        ///update address book in database
        ///</summary>
        ///<param name="users"></param>
        public IEnumerable<UserDto> FetchAddressBookDetail(List<User> users)
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
        ///<param name="user"></param>
        public UserDto FetchSingleAddressBookDetail(User user)
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
        ///<param name="user"></param>
        public void DeleteAddressBook(User user)
        {
            _userRepository.DeleteUser(user);
            _userRepository.Save();
        }

        ///<summary>
        ///update address book details
        ///</summary>
        ///<param name="authId"></param>
        ///<param name="userId"></param>
        ///<param name="userFromRepo"></param>
        ///<param name="userInput"></param>
        public void UpdateAddressBook(Guid userId, UpdateUserDto userInput, User userFromRepo, Guid authId)
        {
            List<Email> emailCollection = _userRepository.GetEmailIds(userId).ToList();
            List<Phone> phCollection = _userRepository.GetPhoneIds(userId).ToList();
            List<Address> addressCollection = _userRepository.GetAddressIds(userId).ToList();

            emailCollection.Select((value, i) =>
            {
                userInput.Emails.ElementAt(i).Id = value.Id;
                return value;
            });
            phCollection.Select((value, i) =>
            {
                userInput.Phones.ElementAt(i).Id = value.Id;
                return value;
            });
            addressCollection.Select((value, i) =>
            {
                userInput.Addresses.ElementAt(i).Id = value.Id;
                return value;
            });          
            _mapper.Map(userInput, userFromRepo);
            userFromRepo.UpdatedAt = DateTime.Now.ToString();
            userFromRepo.UpdatedBy = authId;
            _userRepository.UpdateUser(userFromRepo);
            _userRepository.Save();
        }

        ///<summary>
        ///validate user input in create user 
        ///</summary>
        ///<param name="user"></param>
        public ValidateInputResponse ValidateUserInputCreate(CreateUserDto user)
        {
            //check email & type
            foreach (CreateEmailDto item in user.Emails)
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

            foreach (CreatePhoneNumberDto item in user.Phones)
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
            foreach (CreateAddressDto item in user.Addresses)
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

        ///<summary>
        ///validate user input in update user 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="id"></param>
        public ValidateInputResponse ValidateUserInputUpdate(UpdateUserDto user, Guid id)
        {
            foreach (UpdateEmailDto item in user.Emails)
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

            foreach (UpdatePhoneNumberDto item in user.Phones)
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

            foreach (UpdateAddressDto item in user.Addresses)
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

        ///<summary>
        ///fetch user details for create 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="authId"></param>
        public CreateUserDto UpdateUserDetailsForCreate(CreateUserDto user, Guid authId)
        {
            foreach (CreateEmailDto item in user.Emails)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
            }
            foreach (CreatePhoneNumberDto item in user.Phones)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();

            }
            foreach (CreateAddressDto item in user.Addresses)
            {
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (_userRepository.TypeFinder(item.Country)).Id.ToString();
            }
            return user;

        }

        ///<summary>
        ///fetch user details for create 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="authId"></param>
        public UpdateUserDto UpdateUserDetailsForUpdate(UpdateUserDto user, Guid authId)
        {
            foreach (UpdateEmailDto item in user.Emails)
            {
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }
            foreach (UpdatePhoneNumberDto item in user.Phones)
            {
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;

            }
            foreach (UpdateAddressDto item in user.Addresses)
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