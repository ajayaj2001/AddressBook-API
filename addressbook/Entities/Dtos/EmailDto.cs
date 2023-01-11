using System;

namespace AddressBook.Entities.Dtos
{
    public class EmailDto
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///user id of who created address book
        ///</summary>
        public Guid UserId { get; set; }

        ///<summary>
        ///unique email address of user
        ///</summary>
        public string EmailAddress { get; set; }

        ///<summary>
        ///email address type
        ///</summary>
        public Guid TypeId { get; set; }
    }
}
