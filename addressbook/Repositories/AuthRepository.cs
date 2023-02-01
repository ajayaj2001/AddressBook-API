using AddressBook.Contracts.Repositories;
using AddressBook.DbContexts;
using AddressBook.Entities.Models;
using System;
using System.Linq;

namespace AddressBook.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AddressBookContext _context;

        public AuthRepository(AddressBookContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///get user by user name
        ///</summary>
        ///<param name="userName"></param>
        public User GetUserByUserName(string userName)
        {
            User user = _context.Users.Where(a => a.UserName == userName && a.IsActive).FirstOrDefault();
            return user;
        }
    }
}
