using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;

namespace AddressBook.Entities.Dtos
{
    public class PhoneNumberUpdatingDto : BaseDto
    {

        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///phone number of user 
        ///</summary>
        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

        ///<summary>
        ///phone number type
        ///</summary>
        public string Type { get; set; }
    }
}
