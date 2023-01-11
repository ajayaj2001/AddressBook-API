using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Entities.Models
{
    public class Address : BaseModel
    {
        ///<summary>
        /// address type 
        ///</summary>
        [ForeignKey("Type")]
        public Guid TypeId { get; set; }

        ///<summary>
        ///  user id of who creaated this
        ///</summary>
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        ///<summary>
        /// address line1 of user
        ///</summary>
        public string Line1 { get; set; }

        ///<summary>
        /// address line2 of user
        ///</summary>
        public string Line2 { get; set; }

        ///<summary>
        /// address city of user
        ///</summary>
        public string City { get; set; }

        ///<summary>
        /// address state name of user
        ///</summary>
        public string StateName { get; set; }

        ///<summary>
        /// address country of user
        ///</summary>
        [ForeignKey("Country")]
        public Guid Country { get; set; }

        ///<summary>
        /// address zipcode of user
        ///</summary>
        public string Zipcode { get; set; }
    }
}
