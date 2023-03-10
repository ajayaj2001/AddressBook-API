using AddressBook.Entities.Models;

namespace AddressBook.Contracts.Services
{
    public interface IAuthService
    {

        ///<summary>
        ///create session token
        ///</summary>
        ///<param name="userData"></param>
        string CreateJWTToken(User userData);

        ///<summary>
        ///compare password
        ///</summary>
        ///<param name="dbPass"></param>
        ///<param name="userPass"></param>
        bool ComparePassword(string userPass, string dbPass);

        ///<summary>
        ///get user by user name
        ///</summary>
        ///<param name="userName"></param>
        User GetUserByUserName(string userName);
    }
}
