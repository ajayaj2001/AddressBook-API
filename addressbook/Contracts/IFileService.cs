using AddressBook.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using System;

namespace AddressBook.Contracts
{
    public interface IFileService
    {
        FileResultDto StoreImage(Guid userId, IFormFile file, Guid authId);
    }
}
