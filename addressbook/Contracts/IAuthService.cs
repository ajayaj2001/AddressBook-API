using AddressBook.Entities.Models;

namespace AddressBook.Contracts
{
    public interface IAuthService
    {
        string CreateJWTToken(User userData);

        bool ComparePassword(string userPass, string dbPass);
    }
}
