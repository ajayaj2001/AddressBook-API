using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Entities.Models
{
    public class Phone : BaseModel
    {
        ///<summary>
        /// user id of whos phone number
        ///</summary>
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        ///<summary>
        ///unique phone number of user
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///phone number type
        ///</summary>
        [ForeignKey("TypeId")]
        public Guid TypeId { get; set; }
    }
}
