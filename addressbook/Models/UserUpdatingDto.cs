using System.Collections.Generic;


namespace addressbook.Models
{
    public class UserUpdatingDto
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public ICollection<AddressUpatingDto> Addresses { get; set; } = new List<AddressUpatingDto>();
        public ICollection<EmailUpdatingDto> Emails { get; set; } = new List<EmailUpdatingDto>();
        public ICollection<PhoneNumberUpdatingDto> Phones { get; set; } = new List<PhoneNumberUpdatingDto>();
    }
}
