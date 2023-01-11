using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Helper;
using System;
using AddressBook.Entities.Models;
using AddressBook.Entities.Dtos;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Entities.ResponseTypes;
using AddressBook.Contracts;
using AddressBook.Repositories;
using Microsoft.Extensions.Logging;

namespace AddressBook.Controllers
{
    //authentication controller


    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAddressBookRepository _userRepository;
        private readonly IService _services;
        private readonly ILogger _logger;

        public AuthController(IAddressBookRepository UserDetailRepositary, IService services, ILogger logger)
        {
            _userRepository = UserDetailRepositary ?? throw new ArgumentNullException(nameof(AddressBookRepository));
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        ///<summary> 
        ///To login user
        ///</summary>
        ///<remarks>To create and return session for valid user</remarks> 
        ///<param name="loginCredentials"></param> 
        ///<response code = "200" >Session type and token returned succesfully</response> 
        ///<response code = "401" >User credientials invalid</response> 
        ///<response code="500">Internel server error</response>
        [AllowAnonymous]
        [HttpPost("signin")]
        [SwaggerOperation(Summary = "Login User", Description = "Login user and return session token")]
        [SwaggerResponse(200, "Success", typeof(LoginSuccessResponse))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult UserLogin([FromBody] LoginDetailsDto loginCredentials)
        {
            //check username
            if (loginCredentials.UserName == null || loginCredentials.Password == null)
            { _logger.LogError("user_name or password is Empty"); return StatusCode(401, "user_name or password is Empty"); }

            //is username exist
            User User = _userRepository.GetUserByUserName(loginCredentials.UserName);
            if (User == null)
            { _logger.LogError("userName not exist"); return Unauthorized( "userName not exist"); }

            //is password same
            bool check = _services.ComparePassword(User.Password, loginCredentials.Password);
            if (!check)
            { _logger.LogError("wrong password"); return Unauthorized("wrong password"); }


            string tokenString = _services.CreateJWTToken(User);
            _logger.LogError("session created successfully");
            return Ok(new { access_token = tokenString, token_type = "Bearer" });
        }

    }
}
