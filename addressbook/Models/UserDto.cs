using System.Collections.Generic;
using System;

namespace addressbook.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string User_name { get; set; }
        public ICollection<AddressCreatingDto> Addresses { get; set; } = new List<AddressCreatingDto>();
        public ICollection<EmailCreatingDto> Emails { get; set; } = new List<EmailCreatingDto>();
        public ICollection<PhoneNumberCreatingDto> Phones { get; set; } = new List<PhoneNumberCreatingDto>();

    }
}
