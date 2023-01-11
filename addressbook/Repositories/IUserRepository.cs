using AddressBook.Entities.Models;
using System;
using System.Collections.Generic;

namespace AddressBook.Repositories
{
    public interface IUserRepository
    {
        RefSet TypeFinder(string type);

        int GetCount();

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

        User GetUserById(Guid id);

        bool IsMetadataExist(string type);

        bool IsEmailExist(string email);

        bool IsEmailExistUpdate(string email, Guid userId);

        bool IsPhoneExist(string phNumber);

        bool IsPhoneExistUpdate(string phNumber, Guid userId);

        IEnumerable<Email> GetAllEmails();

        IEnumerable<User> GetAllUsers();

        bool IsUserExits(Guid userId);

        IEnumerable<Email> GetEmailIds(Guid id);

        IEnumerable<Address> GetAddressIds(Guid id);

        IEnumerable<Phone> GetPhoneIds(Guid id);

        public Asset GetAssetById(Guid id);

        public Guid GetImageIdByUserId(Guid id);

        public IEnumerable<Asset> GetAssetIds(Guid id);

        bool Save();
    }
}
