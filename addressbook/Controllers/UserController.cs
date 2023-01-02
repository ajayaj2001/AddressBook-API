using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using addressbook.Models;
using addressbook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using addressbook.Entities;
using addressbook.Helper;

namespace addressbook.Controllers
{

    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepositary _userRepositary;
        private readonly IMapper _mapper;

        public UserController(IUserRepositary UserRepositary, IMapper mapper)
        {
            _userRepositary = UserRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //create new addressbook
        [Authorize]
        [HttpPost("account")]
        public ActionResult<string> CreateUser([FromBody] UserCreatingDto user)
        {
            //check email & type
            foreach (var item in user.Emails)
            {
                if (!PasswordChecker.ValidateEmail(item.EmailAddress))
                    return Conflict("enter valid Email");

                if (!_userRepositary.IsMetadataExist(item.Type))
                    return NotFound("Email type is not exist");


                if (_userRepositary.IsEmailExist(item.EmailAddress))
                    return Conflict("Email is already exist");

                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();

            }
            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            {
                return Conflict("dont enter same email multiple time");
            }

            //check phone & type
            foreach (var item in user.Phones)
            {
                if (!PasswordChecker.ValidatePhone(item.Phone_number))
                    return Conflict("enter valid Phone number");

                if (!_userRepositary.IsMetadataExist(item.Type))
                    return NotFound("Phone number type is not exist");

                if (_userRepositary.IsPhoneExist(item.Phone_number))
                    return Conflict("Phone number is already exist");

                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();

            }
            if (user.Phones.GroupBy(x => x.Phone_number).Any(g => g.Count() > 1))
            {
                return Conflict("dont enter same ph number multiple time");
            }

            //check address & type
            foreach (var item in user.Addresses)
            {
                if (!_userRepositary.IsMetadataExist(item.Country))
                {
                    return NotFound($"Countrytype is not exist{item.Country}");
                }
                if (!_userRepositary.IsMetadataExist(item.Type))
                {
                    return NotFound("Addresstype is not exist");
                }
                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();
                item.Country = (_userRepositary.TypeFinder(item.Country)).TypeId.ToString();
            }
            var userResult = _mapper.Map<User>(user);
            _userRepositary.CreateUser(userResult);
            _userRepositary.Save();

            var userDetail = _mapper.Map<UserDto>(userResult);

            return StatusCode(201, userDetail.UserId);
        }

        //get all addressbook
        [Authorize]
        [HttpGet("account", Name = "GetAllUser")]
        public IActionResult GetUsers([FromQuery] PageSortParam pageSortParam)
        {
            IEnumerable<User> foundedUserList = _userRepositary.GetAllUsers();

            if (foundedUserList != null)
            {
                foundedUserList = foundedUserList.Select(user =>
                   {
                       return FieldMapper.updateFields(user, _userRepositary);
                   });

                PaginationHandler<User> list = new PaginationHandler<User>(pageSortParam);
                var result = list.GetData(foundedUserList);


                return new JsonResult(result);
            }
            else
            {
                return new NotFoundResult();
            }

        }


        //get addressbook count
        [Authorize]
        [HttpGet("account/count")]
        public IActionResult GetCount()
        {
            var count = _userRepositary.GetAllUsers().Count();
            return new JsonResult(new { count = count });
        }

        //get addressbook by id
        [Authorize]
        [HttpGet("account/{id}", Name = "GetUser")]
        public IActionResult UserLogin(Guid id)
        {
            User foundUser = _userRepositary.GetUserById(id);

            if (foundUser == null)
                return NotFound();

            User resultUser = FieldMapper.updateFields(foundUser, _userRepositary);

            return Ok(resultUser);
        }

        //delete addressbook by id
        [Authorize]
        [HttpDelete("account/{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var userFromRepo = _userRepositary.GetUserById(id);

            if (userFromRepo == null)
                return NotFound();

            _userRepositary.DeleteUser(userFromRepo);
            _userRepositary.Save();
            return Ok("Address book deleted successfully");
        }

        //update addressbook
        [Authorize]
        [HttpPut("account/{userId}")]
        public ActionResult<UserDto> UpdateUser(Guid userId, [FromBody] UserUpdatingDto user)
        {

            var userFromRepo = _userRepositary.GetUserById(userId);

            if (userFromRepo == null)
            {
                return NotFound();
            }

            foreach (var item in user.Emails)
            {
                if (!PasswordChecker.ValidateEmail(item.EmailAddress))
                    return Conflict("enter valid Email");

                if (!_userRepositary.IsMetadataExist(item.Type))
                    return NotFound("Email type is not exist");

                if (_userRepositary.IsEmailExistUpdate(item.EmailAddress, userId))
                    return Conflict("Email is already exist");

                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();

            }

            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            {
                return Conflict("dont enter same email multiple time");
            }

            foreach (var item in user.Phones)
            {
                if (!PasswordChecker.ValidatePhone(item.Phone_number))
                    return Conflict("enter valid Phone number");

                if (!_userRepositary.IsMetadataExist(item.Type))
                    return NotFound("Phone number type is not exist");

                if (_userRepositary.IsPhoneExistUpdate(item.Phone_number, userId))
                    return NotFound("Phone number is already exist");

                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();
            }

            if (user.Phones.GroupBy(x => x.Phone_number).Any(g => g.Count() > 1))
            {
                return Conflict("dont enter same ph number multiple time");
            }

            foreach (var item in user.Addresses)
            {
                if (!_userRepositary.IsMetadataExist(item.Country))
                {
                    return NotFound($"Countrytype is not exist{item.Country}");
                }
                if (!_userRepositary.IsMetadataExist(item.Type))
                {
                    return NotFound("Addresstype is not exist");
                }
                item.Type = (_userRepositary.TypeFinder(item.Type)).TypeId.ToString();
                item.Country = (_userRepositary.TypeFinder(item.Country)).TypeId.ToString();
            }

            var emailCollection = _userRepositary.GetEmailIds(userId).ToList();
            var phCollection = _userRepositary.GetPhoneIds(userId).ToList();
            var addressCollection = _userRepositary.GetAddressIds(userId).ToList();

            for (int i = 0; i < emailCollection.Count; i++)
            {
                user.Emails.ElementAt(i).EmailId = emailCollection[i].EmailId;
            }

            for (int i = 0; i < addressCollection.Count; i++)
            {
                user.Addresses.ElementAt(i).AddressId = addressCollection[i].AddressId;
            }

            for (int i = 0; i < phCollection.Count; i++)
            {
                user.Phones.ElementAt(i).PhoneId = phCollection[i].PhoneId;
            }

            _mapper.Map(user, userFromRepo);
            _userRepositary.UpdateUser(userFromRepo);
            _userRepositary.Save();

            return Ok("updated");
        }
    }
}
