using Microsoft.Extensions.Configuration;
using System;
using AddressBook.Entities.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AddressBook.Contracts.Services;
using AddressBook.Contracts.Repositories;

namespace AddressBook.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;
        private readonly IAuthRepository _authRepository;

        public AuthService(IConfiguration config, IAuthRepository authRepositary)
        {
            _authRepository = authRepositary ?? throw new ArgumentNullException(nameof(authRepositary));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        ///<summary>
        ///create session token
        ///</summary>
        ///<param name="userData"></param>
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
        ///compare password
        ///</summary>
        ///<param name="dbPass"></param>
        ///<param name="userPass"></param>
        public bool ComparePassword(string userPass, string dbPass)
        {
            return userPass == dbPass ? true : false;
        }

        ///<summary>
        ///get user by user name
        ///</summary>
        ///<param name="userName"></param>
        public User GetUserByUserName(string userName)
        {
            return _authRepository.GetUserByUserName(userName);
            
        }

    }
}
