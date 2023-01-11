using AddressBook.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using AddressBook.Entities.Models;

namespace AddressBook.Contracts
{
    public interface IService
    {
        FileResultDto StoreImage(Guid userId, IFormFile file,Guid authId);

        ICollection<RefSetDto> MetaDataUpdate(string keyword);

        string CreateJWTToken(User userData);

        bool ComparePassword(string userPass, string dbPass);

        Guid CreateUser(UserCreatingDto user,Guid authId);

        List<User> GetAllAddressBook(PageSortParam pageSortParam);

        IEnumerable<UserDto> UpdateAddressBookDetail(List<User> users);

        UserDto UpdateSingleAddressBookDetail(User user);

        void DeleteAddressBook(User user);

        void UpdateAddressBook(Guid userId, UserUpdatingDto userInput, User userFromRepo,Guid authId);
    }
}
