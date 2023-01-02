using System;

namespace addressbook.Models
{
    public class AddressDto
    {
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string Zipcode { get; set; }
        public Guid Type { get; set; }
        public Guid Country { get; set; }
    }
}
