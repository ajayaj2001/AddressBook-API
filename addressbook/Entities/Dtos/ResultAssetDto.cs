using Newtonsoft.Json;
using System;

namespace AddressBook.Entities.Dtos
{
    public class ResultAssetDto
    {
        ///<summary>
        ///unique id of asset
        ///</summary>
        [JsonProperty(PropertyName = "fieldId")]
        public Guid Id { get; set; }

    }
}
