using System.ComponentModel.DataAnnotations;
using System;

namespace AddressBook.Entities.Models
{
    public class RefTerm : BaseModel
    {
       
        ///<summary>
        ///name of ref term
        ///</summary>
        [Required]
        public string Key { get; set; }


        ///<summary>
        ///description of ref term
        ///</summary>
        public string Description { get; set; }
    }
}
