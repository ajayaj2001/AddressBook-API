using System.Collections.Generic;

namespace addressbook.Models
{
    public class UserCreatingDto
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Password { get; set; }
        public string User_name { get; set; }
        public ICollection<EmailCreatingDto> Emails { get; set; } = new List<EmailCreatingDto>();
       public ICollection<AddressCreatingDto> Addresses { get; set; } = new List<AddressCreatingDto>();
       public ICollection<PhoneNumberCreatingDto> Phones { get; set; } = new List<PhoneNumberCreatingDto>();
    }
}
