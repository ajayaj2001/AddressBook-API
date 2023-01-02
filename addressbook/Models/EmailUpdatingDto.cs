using System;

namespace addressbook.Models
{
    public class EmailUpdatingDto
    {
        public Guid EmailId { get; set; }
        public string EmailAddress { get; set; }
        public string Type { get; set; }
    }
}
