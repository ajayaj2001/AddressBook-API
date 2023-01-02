using System;

namespace addressbook.Models
{
    public class EmailDto
    {
        public Guid UserId { get; set; }
        public Guid EmailId { get; set; }
        public string EmailAddress { get; set; }
        public Guid TypeId { get; set; }
    }
}
