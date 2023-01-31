using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entities.Dtos
{
    public class CreateEmailDto
    {
        ///<summary>
        ///email address of user
        ///</summary>
        [Required]
        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$", ErrorMessage = "enter valid email address")]
        public string EmailAddress { get; set; }

        ///<summary>
        ///email address type
        ///</summary>
        public string Type { get; set; }
    }
}
