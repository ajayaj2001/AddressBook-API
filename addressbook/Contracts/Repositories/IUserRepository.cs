using AddressBook.Entities.Models;
using System;
using System.Collections.Generic;

namespace AddressBook.Contracts.Repositories
{
    public interface IUserRepository
    {
        ///<summary>
        ///get type id by type name
        ///</summary>
        ///<param name="type"></param>
        RefTerm TypeFinder(string type);

        ///<summary>
        ///get user count
        ///</summary>
        int GetCount();

        ///<summary>
        ///to create user in db
        ///</summary>
        ///<param name="user"></param>
        // user operation
        void CreateUser(User user);

        ///<summary>
        ///update user in db
        ///</summary>
        ///<param name="user"></param>
        void UpdateUser(User user);

        ///<summary>
        ///get user by user id
        ///</summary>
        ///<param name="id"></param>
        User GetUserById(Guid id);

        ///<summary>
        ///checks is meta data type exist
        ///</summary>
        ///<param name="type"></param>
        bool IsMetadataExist(string type);

        ///<summary>
        ///is email exist
        ///</summary>
        ///<param name="email"></param>
        bool IsEmailExist(string email);

        ///<summary>
        ///is emai exist not check individual user
        ///</summary>
        ///<param name="email"></param>
        ///<param name="userId"></param>
        bool IsEmailExistUpdate(string email, Guid userId);

        ///<summary>
        ///check phone number exist
        ///</summary>
        ///<param name="phNumber"></param>
        bool IsPhoneExist(string phNumber);

        ///<summary>
        ///check phone number exist not check current user
        ///</summary>
        ///<param name="phNumber"></param>
        ///<param name="userId"></param>
        bool IsPhoneExistUpdate(string phNumber, Guid userId);

        ///<summary>
        ///get all emails 
        ///</summary>
        IEnumerable<Email> GetAllEmails();

        ///<summary>
        ///get all user from db
        ///</summary>
        IEnumerable<User> GetAllUsers();

        ///<summary>
        ///check whether user exist
        ///</summary
        ///<param name="userId"></param>
        bool IsUserExits(Guid userId);

        ///<summary>
        ///get email by user id
        ///</summary>
        ///<param name="id"></param>
        IEnumerable<Email> GetEmailIds(Guid id);

        ///<summary>
        ///get address ids of user
        ///</summary>
        ///<param name="id"></param>
        IEnumerable<Address> GetAddressIds(Guid id);

        ///<summary>
        ///get phone numeber ids of user
        ///</summary>
        ///<param name="id"></param>
        IEnumerable<Phone> GetPhoneIds(Guid id);

        ///<summary>
        ///get asset ids of user
        ///</summary>
        ///<param name="id"></param>
        public Asset GetAssetById(Guid id);


        ///<summary>
        ///retrive image by user id
        ///</summary>
        ///<param name="id"></param>
        public Guid GetImageIdByUserId(Guid id);

        ///<summary>
        ///get assets by ids
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Asset> GetAssetIds(Guid id);


        ///<summary>
        ///save all changes
        ///</summary>
        bool Save();
    }
}
