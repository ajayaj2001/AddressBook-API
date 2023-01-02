using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace addressbook.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string First_name { get; set; }

        [Required]
        public string Last_name { get; set; }

        [Required]
        public string User_name { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Email> Emails { get; set; } = new List<Email>();

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public ICollection<PhoneNumber> Phones { get; set; } = new List<PhoneNumber>();
        public ICollection<AssetDto> AssetDto { get; set; } = new List<AssetDto>();
    }
}
