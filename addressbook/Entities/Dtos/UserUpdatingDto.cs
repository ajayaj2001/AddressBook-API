using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace AddressBook.Entities.Dtos
{
    public class UserUpdatingDto : BaseDto
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
        ///address list of user 
        ///</summary>
        public ICollection<AddressUpdatingDto> Addresses { get; set; } = new List<AddressUpdatingDto>();
        
        ///<summary>
        ///email list of user
        ///</summary>
        public ICollection<EmailUpdatingDto> Emails { get; set; } = new List<EmailUpdatingDto>();

        ///<summary>
        ///phone number list of user 
        ///</summary>
        public ICollection<PhoneNumberUpdatingDto> Phones { get; set; } = new List<PhoneNumberUpdatingDto>();
    }
}
