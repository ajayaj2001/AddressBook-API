using System.ComponentModel.DataAnnotations;
using System;

namespace AddressBook.Entities.Models
{
    public class RefSet : BaseModel
    {

        ///<summary>
        ///name of ref set
        ///</summary>
        [Required]
        public string Key { get; set; }


        ///<summary>
        ///description of ref set
        ///</summary>
        public string Description { get; set; }
    }
}
