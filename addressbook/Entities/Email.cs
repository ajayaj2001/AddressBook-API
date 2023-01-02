using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace addressbook.Entities
{
    public class Email
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [Key]
        public Guid EmailId { get; set; }
        public string EmailAddress { get; set; }

        [ForeignKey("TypeId")]
        public Guid TypeId { get; set; }
    }
}
