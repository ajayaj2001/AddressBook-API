using AddressBook.Entities.Models;
using System;

namespace AddressBook.Repositories
{
    public interface IFileRepository
    {
        ///<summary>
        /// street 1  of the user 
        ///</summary>
        ///<param name="id"></param>
        Asset RetriveImage(Guid id);

        ///<summary>
        /// 
        ///</summary>
        ///<param name="uploadImage"></param>
        void UploadImage(Asset uploadImage);
    }
}
