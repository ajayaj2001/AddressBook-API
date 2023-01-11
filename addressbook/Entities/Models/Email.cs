using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AddressBook.Entities.Models
{
    public class Email : BaseModel
    {
        ///<summary>
        /// user id of whos email
        ///</summary>
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        ///<summary>
        /// unique email address of user
        ///</summary>
        public string EmailAddress { get; set; }

        ///<summary>
        /// email address type
        ///</summary>
        [ForeignKey("TypeId")]
        public Guid TypeId { get; set; }
    }
}
