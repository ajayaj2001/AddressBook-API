using AddressBook.Entities.Dtos;
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
    }
}
