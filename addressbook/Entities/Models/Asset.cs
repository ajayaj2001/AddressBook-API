using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AddressBook.Entities.Models
{
    public class Asset : BaseModel
    {
        ///<summary>
        /// file byte string of uploaded image
        ///</summary>
        [MaxLength]
        public string File { get; set; }

        ///<summary>
        /// user id of who uploaded
        ///</summary>
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}
