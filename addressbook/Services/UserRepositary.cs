using addressbook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using addressbook.DbContexts;
namespace addressbook.Services
{
    public class UserRepositary : IUserRepositary
    {
        private readonly UserContext _context;

        public UserRepositary(UserContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        // user operation
        public void CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);

        }
        public void UpdateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Update(user);
        }
        public void DeleteUser(User user)
        {

            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Remove(user);
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }



        // file operation
        public void UploadImage(ImageFile saveImage)
        {
            _context.ImageFile.Add(saveImage);
        }
        public ImageFile RetriveImage(Guid id)
        {

            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var image = _context.ImageFile.FirstOrDefault(b => b.FileId == id);

            if (image == null)
                return null;

            return image;
        }
        public Guid GetImageIdByUserId(Guid id)
        {
            return _context.ImageFile.Where(e => e.UserId == id).FirstOrDefault().FileId;
        }



        // ref operation
        public IEnumerable<Guid> getRefSetGroup(Guid id)
        {
            List<Guid> Group = new List<Guid>();
            foreach (var item in _context.SetRefTerms)
            {
                if (item.RefTermId.Equals(id))
                {

                    Group.Add(item.RefSetId);
                }
            }
            return Group;
        }
        public IEnumerable<RefSet> getRefSet(IEnumerable<Guid> items)
        {

            return _context.RefSets.Where(a => items.Contains(a.TypeId));
        }
        public RefTerm getRefTerm(string name)
        {
            return (_context.RefTerm.FirstOrDefault(a => a.Type == name));
        }

        //asset operation
        public void UpdateAsset(AssetDto assetDto)
        {
            _context.AssetDtos.Update(assetDto);
        }
        public void AddAsset(AssetDto assetDto)
        {
            _context.AssetDtos.Add(assetDto);
        }

        // ref helper operation
        public RefSet TypeFinder(string type)
        {
            return _context.RefSets.FirstOrDefault(b => b.Name == type);
        }
        public bool IsMetadataExist(string type)
        {
            return _context.RefSets.Any(a => a.Name == type);
        }



        //email helper operation
        public bool IsEmailExist(string email)
        {
            return _context.Emails.Any(e => e.EmailAddress == email);
        }
        public bool IsEmailExistUpdate(string email, Guid userId)
        {
            return _context.Emails.Any(e => e.EmailAddress == email && e.UserId != userId);
        }
        public IEnumerable<Email> GetAllEmails()
        {
            return _context.Emails.ToList();
        }
        public IEnumerable<Email> GetEmailIds(Guid id)
        {
            return _context.Emails.Where(a => a.UserId == id);
        }



        //phone helper operation
        public bool IsPhoneExist(string phNumber)
        {
            return _context.Phones.Any(e => e.Phone_number == phNumber);
        }
        public bool IsPhoneExistUpdate(string phNumber, Guid userId)
        {
            return _context.Phones.Any(e => e.Phone_number == phNumber && e.UserId != userId);
        }
        public IEnumerable<PhoneNumber> GetPhoneIds(Guid id)
        {
            return _context.Phones.Where(a => a.UserId == id);
        }



        //address helper operation
        public IEnumerable<Address> GetAddressIds(Guid id)
        {
            return _context.Addresses.Where(a => a.UserId == id);
        }



        //user helper operation
        public User GetUserById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _context.Users.FirstOrDefault(b => b.UserId == id);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public int GetCount()
        {
            var count = _context.Users.ToList();
            return count.Count;
        }
        public bool IsUserExits(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userId));
            }
            return _context.Users.Any(a => a.UserId == userId);
        }
        public User GetUserByUserName(string userName)
        {
            var user = _context.Users.Where(a => a.User_name == userName).FirstOrDefault();

            return user;
        }



        //asset helper operation
        public AssetDto GetAssetById(Guid id)
        {
            return _context.AssetDtos.Find(id);
        }
        public IEnumerable<AssetDto> GetAssetIds(Guid id)
        {
            return _context.AssetDtos.Where(a => a.UserId == id);
        }

    }
}
