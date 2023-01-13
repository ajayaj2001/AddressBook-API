using System;

namespace AddressBook.Entities.Dtos
{
    public class UpdateEmailDto : BaseDto
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///unique email addres of user
        ///</summary>
        public string EmailAddress { get; set; }

        ///<summary>
        /// email address type
        ///</summary>
        public string Type { get; set; }
    }
}
