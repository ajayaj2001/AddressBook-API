using System.ComponentModel.DataAnnotations;
using System;

namespace AddressBook.Entities.Models
{
    public class RefTerm
    {
        ///<summary>
        ///unique id of ref term
        ///</summary>
        [Key]
        public Guid RefTermId { get; set; }

        ///<summary>
        ///ref term name
        ///</summary>
        [Required]
        public string Key { get; set; }

        ///<summary>
        ///description of ref term
        ///</summary>
        public string Description { get; set; }
    }
}
