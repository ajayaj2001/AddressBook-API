using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AddressBook.Entities.Models;
using AddressBook.Entities.Dtos;
using AddressBook.Entities.ResponseTypes;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Contracts;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace AddressBook.Controllers
{
    [ApiController]
    [Route("api/")]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookRepository _userRepository;
        private readonly IService _services;
        private readonly ILogger _logger;

        public AddressBookController(IAddressBookRepository UserRepositary, IService services, ILogger logger)
        {
            _userRepository = UserRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        ///<summary> 
        ///Create Address Book 
        ///</summary>
        ///<remarks>To create address book with first name, last name and their communication details</remarks> 
        ///<param name="user"></param> 
        ///<response code = "200" >Id of created address book returned successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "409" >The user input is not valid</response>
        ///<response code = "404" >MetaData type not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpPost("account")]
        [SwaggerOperation(Summary = "Create Address Book", Description = "To create address book with first name, last name and their communication details")]
        [SwaggerResponse(200, "Created", typeof(CreatedSuccessResponse))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(409, "Conflict", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public ActionResult<string> CreateAddressBook([FromBody] UserCreatingDto user)
        {
            Guid authId;
            if (String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
                authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            else //while testing dummy userid
                authId = Guid.Parse("6ebb437a-03e5-4ebf-83fa-652f548368f2");

            //check email & type
            foreach (EmailCreatingDto item in user.Emails)
            {
                if (_userRepository.IsEmailExist(item.EmailAddress))
                {
                    _logger.LogError("Email is already exist");
                    return Conflict("Email is already exist");
                }
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Email type is not exist");
                    return NotFound("Email type is not exist");
                }
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
            }
            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            {
                _logger.LogError("Dont enter same email multiple time");
                return Conflict("dont enter same email multiple time");
            }
            //check phone & type
            foreach (PhoneNumberCreatingDto item in user.Phones)
            {
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Phone number type is not exist");
                    return NotFound("Phone number type is not exist");
                }

                if (_userRepository.IsPhoneExist(item.PhoneNumber))
                {
                    _logger.LogError("Phone number is already exist");
                    return Conflict("Phone number is already exist");
                }
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();

            }
            if (user.Phones.GroupBy(x => x.PhoneNumber).Any(g => g.Count() > 1))
            {
                _logger.LogError("dont enter same ph number multiple time");
                return Conflict("dont enter same ph number multiple time");
            }

            //check address & type
            foreach (AddressCreatingDto item in user.Addresses)
            {
                if (!_userRepository.IsMetadataExist(item.Country))
                {
                    _logger.LogError($"Countrytype is not exist{item.Country}");
                    return NotFound($"Countrytype is not exist{item.Country}");
                }

                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Addresstype is not exist");
                    return NotFound("Addresstype is not exist");
                }
                item.CreatedAt = DateTime.Now.ToString();
                item.CreatedBy = authId;
                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (_userRepository.TypeFinder(item.Country)).Id.ToString();
            }
            _logger.LogInformation("created address book");
            return Ok(_services.CreateUser(user,authId));
        }

        ///<summary> 
        ///Get All Address Book 
        ///</summary>
        ///<remarks>To get all the address book stored in the database</remarks> 
        ///<param name="pageSortParam"></param> 
        ///<response code = "200" >get all address book based on query returned successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "404" >AddressBook not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpGet("account", Name = "GetAllUser")]
        [SwaggerOperation(Summary = "Get All Address Book", Description = "To get all the address book stored in the database")]
        [SwaggerResponse(200, "Success", typeof(List<UserDto>))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult GetAllAddressBook([FromQuery] PageSortParam pageSortParam)
        {
            List<User> users = _services.GetAllAddressBook(pageSortParam);
            if (users == null)
            {
                _logger.LogError("User Not Found");
                return new NotFoundResult();
            }
            _logger.LogInformation("returned all address book");
            return Ok(_services.UpdateAddressBookDetail(users));
        }


        ///<summary> 
        ///Get Address Book Count
        ///</summary>
        ///<remarks>To get the total count of all address book stored in the database</remarks> 
        ///<response code = "200" >count of total address book returned successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpGet("account/count")]
        [SwaggerOperation(Summary = "Get Address Book Count", Description = "To get all the address book stored in the database")]
        [SwaggerResponse(200, "Success", typeof(CountSuccessResponse))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]

        public IActionResult GetAddressBookCount()
        {
            int count = _userRepository.GetAllUsers().Count();
            _logger.LogInformation("returned address book count");
            return Ok(new CountSuccessResponse() { count = count });
        }

        ///<summary> 
        ///Get Address Book 
        ///</summary>
        ///<remarks>To get an address book details stored in the database</remarks> 
        ///<param name="id"></param> 
        ///<response code = "200" >get address book based on userId returned successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "404" >AddressBook not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpGet("account/{id}", Name = "GetUser")]
        [SwaggerOperation(Summary = "Get Address Book", Description = "To get an address book details stored in the database")]
        [SwaggerResponse(200, "Success", typeof(UserDto))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult GetAddressBookById(Guid id)
        {
            User foundUser = _userRepository.GetUserById(id);
            if (foundUser == null)
            {
                _logger.LogError("user not found");
                return NotFound();
            }
            _logger.LogInformation("returned individual address book ");
            return Ok(_services.UpdateSingleAddressBookDetail(foundUser));
        }

        ///<summary> 
        ///Delete Address Book 
        ///</summary>
        ///<remarks>To delete an address book frpm database</remarks> 
        ///<param name="id"></param> 
        ///<response code = "200" >address book delted successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "404" >AddressBook not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpDelete("account/{id}")]
        [SwaggerOperation(Summary = "Delete Address Book", Description = "To delet an address book from database")]
        [SwaggerResponse(200, "Success", typeof(string))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult DeleteAddressBook(Guid id)
        {
            User userFromRepo = _userRepository.GetUserById(id);
            if (userFromRepo == null)
            {
                _logger.LogError("user not found");
                return NotFound();
            }
            _services.DeleteAddressBook(userFromRepo);
            _logger.LogInformation("Address book deleted successfully");
            return Ok("Address book deleted successfully");
        }

        ///<summary> 
        ///Update Address Book 
        ///</summary>
        ///<remarks>To update the existing address book details like first name etc</remarks> 
        ///<param name="user"></param> 
        ///<param name="userId"></param>
        ///<response code = "200" >Address book updated successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "409" >The user input is not valid</response>
        ///<response code = "404" >AddressBook not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpPut("account/{id}")]
        [SwaggerOperation(Summary = "Update Address Book", Description = "To update the existing address book details like first name etc")]
        [SwaggerResponse(200, "Success", typeof(string))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(409, "Conflict", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public ActionResult<string> UpdateAddressBook(Guid id, [FromBody] UserUpdatingDto user)
        {
            Guid authId;
            if (String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
                authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            else //while testing dummy userid
                authId = Guid.Parse("6ebb437a-03e5-4ebf-83fa-652f548368f2");

            User userFromRepo = _userRepository.GetUserById(id);
            if (userFromRepo == null)
            {
                _logger.LogError("user not found");
                return NotFound();
            }
            foreach (EmailUpdatingDto item in user.Emails)
            {
                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Email type is not exist");
                    return NotFound("Email type is not exist");
                }

                if (_userRepository.IsEmailExistUpdate(item.EmailAddress, id))
                { _logger.LogError("Email is already exist"); return Conflict("Email is already exist"); }

                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }

            if (user.Emails.GroupBy(x => x.EmailAddress).Any(g => g.Count() > 1))
            { _logger.LogError("dont enter same email multiple time"); return Conflict("dont enter same email multiple time"); }

            foreach (PhoneNumberUpdatingDto item in user.Phones)
            {

                if (!_userRepository.IsMetadataExist(item.Type))
                {
                    _logger.LogError("Phone number type is not exist");
                    return NotFound("Phone number type is not exist");
                }

                if (_userRepository.IsPhoneExistUpdate(item.PhoneNumber, id))
                { _logger.LogError("Phone number is already exist"); return NotFound("Phone number is already exist"); }

                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }

            if (user.Phones.GroupBy(x => x.PhoneNumber).Any(g => g.Count() > 1))
            {
                _logger.LogError("dont enter same ph number multiple time");
                return Conflict("dont enter same ph number multiple time");
            }

            foreach (AddressUpatingDto item in user.Addresses)
            {
                if (!_userRepository.IsMetadataExist(item.Country))
                { _logger.LogError($"Countrytype is not exist{item.Country}"); return NotFound($"Countrytype is not exist{item.Country}"); }
                if (!_userRepository.IsMetadataExist(item.Type))
                { _logger.LogError("Addresstype is not exist"); return NotFound("Addresstype is not exist"); }

                item.Type = (_userRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (_userRepository.TypeFinder(item.Country)).Id.ToString();
                item.UpdatedAt = DateTime.Now.ToString();
                item.UpdatedBy = authId;
            }
            _services.UpdateAddressBook(id, user, userFromRepo,authId);
            _logger.LogInformation("Addresstype updated successfully");
            return Ok("updated");
        }
    }
}
