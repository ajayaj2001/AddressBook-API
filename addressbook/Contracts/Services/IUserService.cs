using AddressBook.Entities.Dtos;
using System;
using System.Collections.Generic;
using AddressBook.Entities.Models;
using AddressBook.Entities.ResponseTypes;

namespace AddressBook.Contracts.Services
{
    public interface IUserService
    {
        ///<summary>
        ///create new user in db
        ///</summary>
        ///<param name="authId"></param>
        ///<param name="user"></param>
        Guid CreateUser(User user, Guid authId);

        ///<summary>
        ///get all address book based on filter
        ///</summary>
        ///<param name="pageSortParam"></param>
        List<User> GetAllAddressBook(PageSortParam pageSortParam);

        ///<summary>
        ///update address book in database
        ///</summary>
        ///<param name="users"></param>
        IEnumerable<UserDto> FetchAddressBookDetail(List<User> users);

        ///<summary>
        ///get single address book detais
        ///</summary>
        ///<param name="user"></param>
        UserDto FetchSingleAddressBookDetail(User user);

        ///<summary>
        ///delete address book in database
        ///</summary>
        ///<param name="user"></param>
        void DeleteAddressBook(Guid userId);

        ///<summary>
        ///get user by user id
        ///</summary>
        ///<param name="userId"></param>
        User GetUserById(Guid userId);


        ///<summary>
        ///fetch all user from database
        ///</summary>
        IEnumerable<User> GetAllUsers();


        ///<summary>
        ///update address book details
        ///</summary>
        ///<param name="authId"></param>
        ///<param name="userId"></param>
        ///<param name="userFromRepo"></param>
        ///<param name="userInput"></param>
        void UpdateAddressBook(Guid userId, User userInput, User userFromRepo, Guid authId);

        ///<summary>
        ///validate user input in create user 
        ///</summary>
        ///<param name="user"></param>
        User FetchUserDetailsForCreate(CreateUserDto user, Guid authId);

        ///<summary>
        ///validate user input in update user 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="id"></param>
        ValidateInputResponse ValidateUserInputUpdate(UpdateUserDto user, Guid id);

        ///<summary>
        ///fetch user details for create 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="authId"></param>
        ValidateInputResponse ValidateUserInputCreate(CreateUserDto user);

        ///<summary>
        ///fetch user details for create 
        ///</summary>
        ///<param name="user"></param>
        ///<param name="authId"></param>
        User FetchUserDetailsForUpdate(UpdateUserDto user, Guid authId);


    }
}
