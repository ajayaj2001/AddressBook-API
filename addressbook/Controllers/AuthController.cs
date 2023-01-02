using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using addressbook.Entities;
using addressbook.Models;
using addressbook.Services;
using addressbook.Helper;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace addressbook.Controllers
{
    //authentication controller

    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        //decl
        private IConfiguration _config;
        private readonly IUserRepositary _userRepositary;
        private readonly IMapper _mapper;

        //const
        public AuthController(IUserRepositary UserDetailRepositary, IMapper mapper, IConfiguration config)
        {
            _userRepositary = UserDetailRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _config = config ?? throw new ArgumentNullException(nameof(config));

        }


        [AllowAnonymous]
        [HttpPost("signin")]
        public IActionResult UserLogin([FromBody] LoginDetailsDto loginCredentials)
        {
            IActionResult response = Unauthorized();

            //check username
            if (loginCredentials.User_name == null || loginCredentials.Password == null)
            {
                return StatusCode(401, "user_name or password is Empty");
            }

            //check password
            if (!PasswordChecker.ValidatePassword(loginCredentials.Password))
            {
                return StatusCode(401, "Password must be one lower case , one upper case , special character,one number and 8 characters length");
            }

            //is username exist
            var User = _userRepositary.GetUserByUserName(loginCredentials.User_name);
            if (User == null)
            {
                return StatusCode(401, "userName not exist");
            }

            //is password same
            bool check = PasswordChecker.ComparePassword(User.Password, loginCredentials.Password);
            if (check)
            {
                var tokenString = createJWTToken(User);
                response = Ok(new { access_token = tokenString, token_type = "Bearer" });
                return response;
            }
            else
            {
                return StatusCode(401, "wrong password");
            }

        }


        //genereate json web token
        private string createJWTToken(User userData)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSecret:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
         new Claim(JwtRegisteredClaimNames.Sub, userData.First_name),
         new Claim(JwtRegisteredClaimNames.Sub, userData.Last_name),
         new Claim(JwtRegisteredClaimNames.Sub, userData.Password),
         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(_config["JwtSecret:Issuer"],
                _config["JwtSecret:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(290),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
