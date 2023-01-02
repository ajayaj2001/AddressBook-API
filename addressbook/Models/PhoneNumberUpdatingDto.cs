using System;

namespace addressbook.Models
{
    public class PhoneNumberUpdatingDto
    {
        public Guid PhoneId { get; set; }
        public string Phone_number { get; set; }
        public string Type { get; set; }
    }
}
