using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Contracts;
using AddressBook.DbContexts;
using AddressBook.Entities.Models;

namespace AddressBook.Repositories
{
    public class AddressBookRepository : IAddressBookRepository
    {
        private readonly AddressBookContext _context;

        public AddressBookRepository(AddressBookContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///to create user in db
        ///</summary>
        // user operation
        public void CreateUser(User user)
        {
                       _context.Users.Add(user);

        }

        ///<summary>
        ///update user in db
        ///</summary>
        public void UpdateUser(User user)
        {
           
            _context.Users.Update(user);
        }

        ///<summary>
        ///delete user in db
        ///</summary>
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
        ///upload user image to db
        ///</summary>
        public void UploadImage(Asset saveImage)
        {
            _context.Assets.Add(saveImage);
        }
        public Asset RetriveImage(Guid id)
        {

            Asset image = _context.Assets.FirstOrDefault(b => b.Id == id);

            if (image == null)
                return null;

            return image;
        }

        ///<summary>
        ///retrive image by user id
        ///</summary>
        public Guid GetImageIdByUserId(Guid id)
        {
            return _context.Assets.Where(e => e.UserId == id).FirstOrDefault().Id;
        }



        ///<summary>
        ///get all ref set group in db
        ///</summary>
        public IEnumerable<Guid> GetRefSetGroup(Guid id)
        {
            List<Guid> Group = new List<Guid>();
            foreach (SetRefTerm item in _context.SetRefTerms)
            {
                if (item.RefTermId.Equals(id))
                {

                    Group.Add(item.RefSetId);
                }
            }
            return Group;
        }
        ///<summary>
        ///get ref set by id list
        ///</summary>
        public IEnumerable<RefSet> GetRefSet(IEnumerable<Guid> items)
        {

            return _context.RefSets.Where(a => items.Contains(a.Id));
        }

        ///<summary>
        ///get ref term by name
        ///</summary>
        public RefTerm GetRefTerm(string name)
        {
            return _context.RefTerm.FirstOrDefault(a => a.Key == name);
        }

        ///<summary>
        ///get type id by type name
        ///</summary>
        public RefSet TypeFinder(string type)
        {
            return _context.RefSets.FirstOrDefault(b => b.Key == type);
        }
        ///<summary>
        ///checks is meta data type exist
        ///</summary>
        public bool IsMetadataExist(string type)
        {
            return _context.RefSets.Any(a => a.Key == type);
        }



        ///<summary>
        ///is email exist
        ///</summary>
        public bool IsEmailExist(string email)
        {
            return _context.Emails.Any(e => e.EmailAddress == email);
        }

        ///<summary>
        ///is emai exist not check individual user
        ///</summary>
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
        public IEnumerable<Email> GetEmailIds(Guid id)
        {
            return _context.Emails.Where(a => a.UserId == id);
        }



        ///<summary>
        ///check phone number exist
        ///</summary>
        public bool IsPhoneExist(string phNumber)
        {
            return _context.Phones.Any(e => e.PhoneNumber == phNumber);
        }

        ///<summary>
        ///check phone number exist not check current user
        ///</summary>
        public bool IsPhoneExistUpdate(string phNumber, Guid userId)
        {
            return _context.Phones.Any(e => e.PhoneNumber == phNumber && e.UserId != userId);
        }

        ///<summary>
        ///get phone numeber ids of user
        ///</summary>
        public IEnumerable<Phone> GetPhoneIds(Guid id)
        {
            return _context.Phones.Where(a => a.UserId == id);
        }



        ///<summary>
        ///get address ids of user
        ///</summary>
        public IEnumerable<Address> GetAddressIds(Guid id)
        {
            return _context.Addresses.Where(a => a.UserId == id);
        }



        ///<summary>
        ///get user by user id
        ///</summary>
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
        ///</summary>
        public bool IsUserExits(Guid userId)
        {
            
            return _context.Users.Any(a => a.Id == userId);
        }
        ///<summary>
        ///get user by user name
        ///</summary>
        public User GetUserByUserName(string userName)
        {
            User user = _context.Users.Where(a => a.UserName == userName).FirstOrDefault();

            return user;
        }



        ///<summary>
        ///get asset by id
        ///</summary>
        public Asset GetAssetById(Guid id)
        {
            return _context.Assets.Find(id);
        }
        ///<summary>
        ///get assets by ids
        ///</summary>
        public IEnumerable<Asset> GetAssetIds(Guid id)
        {
            return _context.Assets.Where(a => a.UserId == id);
        }

    }
}
