using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Entities.Dtos
{
    public class UserCreatingDto : BaseDto
    {
        ///<summary>
        ///first name of user
        ///</summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        ///<summary>
        ///last name of user 
        ///</summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        ///<summary>
        ///password of user
        ///</summary>
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Password must be one lower case , one upper case , special character,one number and 8 characters length")]
        public string Password { get; set; }

        ///<summary>
        ///user name of user
        ///</summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        ///<summary>
        ///email details list of user
        ///</summary>
        public ICollection<EmailCreatingDto> Emails { get; set; } = new List<EmailCreatingDto>();

        ///<summary>
        ///addrss details list of user
        ///</summary>
        public ICollection<AddressCreatingDto> Addresses { get; set; } = new List<AddressCreatingDto>();
        
        ///<summary>
        ///phone dettails list of user 
        ///</summary>
        public ICollection<PhoneNumberCreatingDto> Phones { get; set; } = new List<PhoneNumberCreatingDto>();
    }
}
