using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace AddressBook.Entities.Dtos
{
    public class UpdateUserDto : BaseDto
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
        public ICollection<UpdateAddressDto> Addresses { get; set; } = new List<UpdateAddressDto>();
        
        ///<summary>
        ///email list of user
        ///</summary>
        public ICollection<UpdateEmailDto> Emails { get; set; } = new List<UpdateEmailDto>();

        ///<summary>
        ///phone number list of user 
        ///</summary>
        public ICollection<UpdatePhoneNumberDto> Phones { get; set; } = new List<UpdatePhoneNumberDto>();
    }
}
