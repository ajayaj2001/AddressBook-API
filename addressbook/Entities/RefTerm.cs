using System.ComponentModel.DataAnnotations;
using System;

namespace addressbook.Entities
{
    public class RefTerm
    {
        [Key]
        public Guid RefTermId { get; set; }
        [Required]
        public string Type { get; set; }

        public string Description { get; set; }
    }
}
