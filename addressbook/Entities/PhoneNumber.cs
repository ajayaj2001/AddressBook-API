using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace addressbook.Entities
{
    public class PhoneNumber
    {

        [Key]
        public Guid PhoneId { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public string Phone_number { get; set; }

        [ForeignKey("TypeId")]
        public Guid TypeId { get; set; }
    }
}
