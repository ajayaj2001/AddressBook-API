using AddressBook.Entities.Models;

namespace AddressBook.Repositories
{
    public interface IAuthRepository
    {
        User GetUserByUserName(string email);
    }
}
