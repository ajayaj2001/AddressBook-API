﻿using AddressBook.DbContexts;
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
        public User GetUserByUserName(string userName)
        {
            User user = _context.Users.Where(a => a.UserName == userName).FirstOrDefault();

            return user;
        }
    }
}