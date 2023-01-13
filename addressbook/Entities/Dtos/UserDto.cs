using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AddressBook.Entities.Dtos
{
    public class UserDto
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

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
        ///user name of user 
        ///</summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        ///<summary>
        ///address list of user
        ///</summary>
        public ICollection<AddressDto> Addresses { get; set; } = new List<AddressDto>();

        ///<summary>
        ///email list of user 
        ///</summary>
        public ICollection<EmailDto> Emails { get; set; } = new List<EmailDto>();

        ///<summary>
        ///phone number list of user
        ///</summary>
        public ICollection<PhoneDto> Phones { get; set; } = new List<PhoneDto>();

        ///<summary>
        ///user image 
        ///</summary>
        public ICollection<ResultAssetDto> Assets { get; set; } = new List<ResultAssetDto>();

    }
}
