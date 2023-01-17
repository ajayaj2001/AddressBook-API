using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace AddressBook.Contracts
{
    public interface IFileService
    {
        ///<summary>
        ///store and update details in asset 
        ///</summary>
        ///<param name="authId"></param>
        ///<param name="userId"></param>
        ///<param name="file"></param>
        FileResultDto StoreImage(Guid userId, IFormFile file, Guid authId);

        ///<summary>
        ///fetch asset by asset id
        ///</summary>
        ///<param name="assetId"></param>
        Asset FetchImage(Guid assetId);
    }
}
