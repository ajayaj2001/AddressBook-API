using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entities.Models
{
    public class User : BaseModel
    {
        ///<summary>
        ///first name of user
        ///</summary>
        [Required]
        public string FirstName { get; set; }

        ///<summary>
        ///last name of user
        ///</summary>
        [Required]
        public string LastName { get; set; }

        ///<summary>
        ///user name of user
        ///</summary>
        [Required]
        public string UserName { get; set; }

        ///<summary>
        ///password of user
        ///</summary>
        [Required]
        public string Password { get; set; }

        ///<summary>
        ///unique emails details of user
        ///</summary>
        public ICollection<Email> Emails { get; set; } = new List<Email>();

        ///<summary>
        ///address details of user
        ///</summary>
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        ///<summary>
        ///unique phone number details of user
        ///</summary>
        public ICollection<Phone> Phones { get; set; } = new List<Phone>();

        ///<summary>
        ///user profile image details
        ///</summary>
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();

    }
}
