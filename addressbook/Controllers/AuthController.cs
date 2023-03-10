using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using AddressBook.Entities.Models;
using AddressBook.Entities.Dtos;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Entities.ResponseTypes;
using AddressBook.Repositories;
using Microsoft.Extensions.Logging;
using AddressBook.Contracts.Services;

namespace AddressBook.Controllers
{
    //authentication controller

    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
       
        private readonly IAuthService _authServices;
        private readonly ILogger _logger;

        public AuthController(IAuthService authService, ILogger logger)
        {
            _authServices = authService ?? throw new ArgumentNullException(nameof(authService));
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
            {
                _logger.LogError("User name or password Empty");
                return Unauthorized(new ErrorResponse { errorMessage = "user_name or password is Empty", errorCode = 401, errorType = "user-credientials" });
            }
            //is username exist
            User User = _authServices.GetUserByUserName(loginCredentials.UserName);
            if (User == null)
            {
                _logger.LogError("UserName not exist");
                return Unauthorized(new ErrorResponse { errorMessage = "userName not exist", errorCode = 401, errorType = "user-credientials" });
            };
            //is password same
            bool check = _authServices.ComparePassword(User.Password, loginCredentials.Password);
            if (!check)
            { _logger.LogError("Wrong password");
                return Unauthorized(new ErrorResponse { errorMessage = "wrong password", errorCode = 401, errorType = "user-credientials" });
            }

            string tokenString = _authServices.CreateJWTToken(User);
            _logger.LogInformation("Session created successfully");
            return Ok(new LoginSuccessResponse { access_token = tokenString, token_type = "Bearer" });
        }

    }
}
