using AddressBook.Entities.Models;
using System;

namespace AddressBook.Repositories
{
    public interface IFileRepository
    {
        Asset RetriveImage(Guid id);

        void UploadImage(Asset uploadImage);
    }
}
