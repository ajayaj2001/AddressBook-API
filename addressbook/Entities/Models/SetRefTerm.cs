using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Entities.Models
{
    public class SetRefTerm 
    {
        ///<summary>
        ///unique id of set ref term
        ///</summary>
        [Key]
        public Guid SetRefTermId { get; set; }

        ///<summary>
        ///refers ref set field
        ///</summary>
        [ForeignKey("RefSetId")]
        public Guid RefSetId { get; set; }

        ///<summary>
        ///refers ref term field
        ///</summary>
        [ForeignKey("RefTermId")]
        public Guid RefTermId { get; set; }
    }
}
