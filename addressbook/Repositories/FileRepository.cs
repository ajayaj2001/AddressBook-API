using AddressBook.DbContexts;
using AddressBook.Entities.Models;
using System;
using System.Linq;

namespace AddressBook.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly AddressBookContext _context;

        public FileRepository(AddressBookContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///upload user image to db
        ///</summary>
        public void UploadImage(Asset saveImage)
        {
            _context.Assets.Add(saveImage);
        }

        ///<summary>
        ///retrive image from db
        ///</summary>
        public Asset RetriveImage(Guid id)
        {
            Asset image = _context.Assets.FirstOrDefault(b => b.Id == id);
            if (image == null)
                return null;

            return image;
        }
    }
}
