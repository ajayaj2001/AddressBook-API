using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;

namespace AddressBook.Entities.Dtos
{
    public class AssetDtoResult
    {
        ///<summary>
        ///unique id of asset
        ///</summary>
        [JsonProperty(PropertyName = "fieldId")]
        public Guid Id { get; set; }

    }
}
