using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AddressBook.Entities.Dtos
{
    public class LoginDetailsDto
    {
        ///<summary>
        ///user name of user
        ///</summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        ///<summary>
        ///password user
        ///</summary>
        public string Password { get; set; }

    }
}
