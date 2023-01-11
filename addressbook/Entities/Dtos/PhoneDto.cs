using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;

namespace AddressBook.Entities.Dtos
{
    public class PhoneDto 
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///user id who created address boook
        ///</summary>
        public Guid UserId { get; set; }

        ///<summary>
        ///phone number of user
        ///</summary>
        [JsonProperty(PropertyName = "phone_number")]

        ///<summary>
        ///phone number of user
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///phone number type
        ///</summary>
        public Guid TypeId { get; set; }
    }
}
