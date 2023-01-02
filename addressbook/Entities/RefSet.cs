using System.ComponentModel.DataAnnotations;
using System;

namespace addressbook.Entities
{
    public class RefSet
    {
        [Required]
        public string  Name { get; set; }
        [Key]
        public Guid TypeId { get; set; }

        public string Description { get; set; }
    }
}
