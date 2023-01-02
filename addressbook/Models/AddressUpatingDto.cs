using System;

namespace addressbook.Models
{
    public class AddressUpatingDto
    {
        public Guid AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string Zipcode { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }

    }
}
