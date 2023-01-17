using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entities.Models
{
    public class RefSet : BaseModel
    {

        ///<summary>
        ///ref set name
        ///</summary>
        [Required]
        public string Key { get; set; }

        ///<summary>
        ///description of ref set
        ///</summary>
        public string Description { get; set; }


    }
}
