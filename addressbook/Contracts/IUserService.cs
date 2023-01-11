using AddressBook.Entities.Dtos;
using System;
using System.Collections.Generic;
using AddressBook.Entities.Models;
using AddressBook.Entities.ResponseTypes;

namespace AddressBook.Contracts
{
    public interface IUserService
    {
        Guid CreateUser(UserCreatingDto user,Guid authId);

        List<User> GetAllAddressBook(PageSortParam pageSortParam);

        IEnumerable<UserDto> UpdateAddressBookDetail(List<User> users);

        UserDto UpdateSingleAddressBookDetail(User user);

        void DeleteAddressBook(User user);

        void UpdateAddressBook(Guid userId, UserUpdatingDto userInput, User userFromRepo,Guid authId);

        UserCreatingDto UpdateUserDetailsForCreate(UserCreatingDto user, Guid authId);

        ValidateInputResponse ValidateUserInputUpdate(UserUpdatingDto user, Guid id);
        ValidateInputResponse ValidateUserInputCreate(UserCreatingDto user);

        UserUpdatingDto UpdateUserDetailsForUpdate(UserUpdatingDto user, Guid authId);

       
    }
}
