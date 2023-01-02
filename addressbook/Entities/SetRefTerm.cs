using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace addressbook.Entities
{
    public class SetRefTerm
    {
        [Key]
        public Guid SetRefTermId { get; set; }

        [ForeignKey("RefSetId")]
        public Guid RefSetId { get; set; }

        [ForeignKey("RefTermId")]
        public Guid RefTermId { get; set; }
    }
}
