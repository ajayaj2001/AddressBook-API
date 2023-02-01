using AddressBook.Entities.Models;

namespace AddressBook.Contracts.Repositories
{
    public interface IAuthRepository
    {
        ///<summary>
        /// street 1  of the user 
        ///</summary>
        ///<param name="email"></param>
        User GetUserByUserName(string email);

    }
}
