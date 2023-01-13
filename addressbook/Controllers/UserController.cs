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
using AddressBook.Repositories;

namespace AddressBook.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userServices;
        private readonly ILogger _logger;

        public UserController(IUserRepository UserRepositary, IUserService userServices, ILogger logger)
        {
            _userRepository = UserRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _userServices = userServices ?? throw new ArgumentNullException(nameof(userServices));
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
        public ActionResult<string> CreateAddressBook([FromBody] CreateUserDto user)
        {
              Guid  authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            ValidateInputResponse validate= _userServices.ValidateUserInputCreate(user);
            if (validate.errorCode == 404)
            {
                return NotFound(validate.errorMessage);
            }else if(validate.errorCode == 409)
            {
                return Conflict(validate.errorMessage);
            }
            else
            {
                CreateUserDto updatedUser = _userServices.UpdateUserDetailsForCreate(user,authId);
                _logger.LogInformation("new user created successfully");
                return Ok(_userServices.CreateUser(updatedUser, authId));
            }
        }

        ///<summary> 
        ///Get All Address Book 
        ///</summary>
        ///<remarks>To get all the address book stored in the database</remarks> 
        ///<param name="size"></param> 
        /// ///<param name="pageNo"></param> 
        /// ///<param name="sortBy"></param> 
        /// ///<param name="sortOrder"></param> 
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
        public IActionResult GetAllAddressBook(int size=10,int pageNo=1,string sortBy="",string sortOrder="")
        {
            PageSortParam pageSortParam = new PageSortParam() { Size=size,PageNo=pageNo,SortBy=sortBy };
            if (sortOrder == "ASC")
                pageSortParam.SortOrder = SortDirection.ASC;
            else if (sortOrder == "DESC")
                pageSortParam.SortOrder = SortDirection.DESC;
            
                List<User> users = _userServices.GetAllAddressBook(pageSortParam);
            if (users == null)
            {
                _logger.LogError("User Not Found");
                return new NotFoundResult();
            }
            _logger.LogInformation("returned all address book");
            return Ok(_userServices.FetchAddressBookDetail(users));
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
            return Ok(_userServices.FetchSingleAddressBookDetail(foundUser));
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
            _userServices.DeleteAddressBook(userFromRepo);
            _logger.LogInformation("Address book deleted successfully");
            return Ok("Address book deleted successfully");
        }

        ///<summary> 
        ///Update Address Book 
        ///</summary>
        ///<remarks>To update the existing address book details like first name etc</remarks> 
        ///<param name="user"></param> 
        ///<param name="id"></param>
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
        public ActionResult<string> UpdateAddressBook(Guid id, [FromBody] UpdateUserDto user)
        {
            
            Guid  authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            User userFromRepo = _userRepository.GetUserById(id);
            if (userFromRepo == null)
            {
                _logger.LogError("user not found");
                return NotFound();
            }

            ValidateInputResponse validate = _userServices.ValidateUserInputUpdate(user,id);
            if (validate.errorCode == 404)
            {
                return NotFound(validate.errorMessage);
            }
            else if (validate.errorCode == 409)
            {
                return Conflict(validate.errorMessage);
            }
            else
            {
                UpdateUserDto updatedUser = _userServices.UpdateUserDetailsForUpdate(user, authId);
                _userServices.UpdateAddressBook(id, updatedUser, userFromRepo, authId);
                _logger.LogInformation("Addresstype updated successfully");
                return Ok("updated");
            }
        }
    }
}
