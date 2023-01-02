using addressbook.Entities;
using System;
using System.Collections.Generic;

namespace addressbook.Services
{
    public interface IUserRepositary
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

        void UploadImage(ImageFile uploadImage);

        bool IsUserExits(Guid userId);

        User GetUserByUserName(string email);

        ImageFile RetriveImage(Guid id);

        IEnumerable<Email> GetEmailIds(Guid id);

        IEnumerable<Address> GetAddressIds(Guid id);

        IEnumerable<PhoneNumber> GetPhoneIds(Guid id);

        IEnumerable<RefSet> getRefSet(IEnumerable<Guid> items);

        IEnumerable<Guid> getRefSetGroup(Guid id);

        RefTerm getRefTerm(string name);

        public void AddAsset(AssetDto assetDto);

        public void UpdateAsset(AssetDto assetDto);

        public AssetDto GetAssetById(Guid id);

        public Guid GetImageIdByUserId(Guid id);

        public IEnumerable<AssetDto> GetAssetIds(Guid id);

        bool Save();
    }
}
