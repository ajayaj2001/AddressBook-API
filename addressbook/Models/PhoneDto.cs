using System;

namespace addressbook.Models
{
    public class PhoneDto
    {
        public Guid PhoneId { get; set; }
        public Guid UserId { get; set; }
        public string Phone_number { get; set; }
        public Guid TypeId { get; set; }
    }
}
