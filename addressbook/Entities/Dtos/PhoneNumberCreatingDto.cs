using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entities.Dtos
{
    public class PhoneNumberCreatingDto : BaseDto
    {
        ///<summary>
        ///phone number of user
        ///</summary>
        [RegularExpression(@"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Enter valid phone number")]
        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

        ///<summary>
        ///phone number type
        ///</summary>
        public string Type { get; set; }
    }
}
