﻿using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.DbContexts;
using AddressBook.Entities.Models;

namespace AddressBook.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AddressBookContext _context;

        public UserRepository(AddressBookContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///to create user in db
        ///</summary>
        ///<param name="user"></param>
        // user operation
        public void CreateUser(User user)
        {
            _context.Users.Add(user);

        }

        ///<summary>
        ///update user in db
        ///</summary>
        ///<param name="user"></param>
        public void UpdateUser(User user)
        {

            _context.Users.Update(user);
        }

        ///<summary>
        ///delete user in db
        ///</summary>
        ///<param name="user"></param>
        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }

        ///<summary>
        ///save all changes
        ///</summary>
        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        ///<summary>
        ///retrive image by user id
        ///</summary>
        ///<param name="id"></param>
        public Guid GetImageIdByUserId(Guid id)
        {
            return _context.Assets.Where(e => e.UserId == id).FirstOrDefault().Id;
        }

        ///<summary>
        ///get type id by type name
        ///</summary>
        ///<param name="type"></param>
        public RefTerm TypeFinder(string type)
        {
            return _context.RefTerm.FirstOrDefault(b => b.Key == type);
        }

        ///<summary>
        ///checks is meta data type exist
        ///</summary>
        ///<param name="type"></param>
        public bool IsMetadataExist(string type)
        {
            return _context.RefTerm.Any(a => a.Key == type);
        }



        ///<summary>
        ///is email exist
        ///</summary>
        ///<param name="email"></param>
        public bool IsEmailExist(string email)
        {
            return _context.Emails.Any(e => e.EmailAddress == email);
        }

        ///<summary>
        ///is emai exist not check individual user
        ///</summary>
        ///<param name="email"></param>
        ///<param name="userId"></param>
        public bool IsEmailExistUpdate(string email, Guid userId)
        {
            return _context.Emails.Any(e => e.EmailAddress == email && e.UserId != userId);
        }

        ///<summary>
        ///get all emails 
        ///</summary>
        public IEnumerable<Email> GetAllEmails()
        {
            return _context.Emails.ToList();
        }

        ///<summary>
        ///get email by user id
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Email> GetEmailIds(Guid id)
        {
            return _context.Emails.Where(a => a.UserId == id);
        }



        ///<summary>
        ///check phone number exist
        ///</summary>
        ///<param name="phNumber"></param>
        public bool IsPhoneExist(string phNumber)
        {
            return _context.Phones.Any(e => e.PhoneNumber == phNumber);
        }

        ///<summary>
        ///check phone number exist not check current user
        ///</summary>
        ///<param name="phNumber"></param>
        ///<param name="userId"></param>
        public bool IsPhoneExistUpdate(string phNumber, Guid userId)
        {
            return _context.Phones.Any(e => e.PhoneNumber == phNumber && e.UserId != userId);
        }

        ///<summary>
        ///get phone numeber ids of user
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Phone> GetPhoneIds(Guid id)
        {
            return _context.Phones.Where(a => a.UserId == id);
        }



        ///<summary>
        ///get address ids of user
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Address> GetAddressIds(Guid id)
        {
            return _context.Addresses.Where(a => a.UserId == id);
        }



        ///<summary>
        ///get user by user id
        ///</summary>
        ///<param name="id"></param>
        public User GetUserById(Guid id)
        {

            return _context.Users.FirstOrDefault(b => b.Id == id);
        }
        ///<summary>
        ///get all user from db
        ///</summary>
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        ///<summary>
        ///get user count
        ///</summary>
        public int GetCount()
        {
            List<User> count = _context.Users.ToList();
            return count.Count;
        }

        ///<summary>
        ///check whether user exist
        ///</summary
        ///<param name="userId"></param>
        public bool IsUserExits(Guid userId)
        {

            return _context.Users.Any(a => a.Id == userId);
        }

        ///<summary>
        ///get asset by id
        ///</summary>
        ///<param name="id"></param>
        public Asset GetAssetById(Guid id)
        {
            return _context.Assets.Find(id);
        }
        ///<summary>
        ///get assets by ids
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Asset> GetAssetIds(Guid id)
        {
            IEnumerable<Asset> asset= _context.Assets.Where(a => a.UserId == id);
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));

            return asset;
        }

    }
}
