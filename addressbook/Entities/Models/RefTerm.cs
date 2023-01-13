using System.ComponentModel.DataAnnotations;
using System;

namespace AddressBook.Entities.Models
{
    public class RefTerm : BaseModel
    {
        

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
