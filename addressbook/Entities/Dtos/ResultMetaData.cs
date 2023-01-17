using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AddressBook.Entities.Dtos
{
    public class ResultMetaData
    {
        [Key]
        public Guid Id { get; set; }

        ///<summary>
        ///ref term name
        ///</summary>
        [Required]
        public string Key { get; set; }

        ///<summary>
        ///description of ref term
        ///</summary>
        public string Description { get; set; }

        [JsonProperty(PropertyName = "ref_term_list")]
        ///<summary>
        ///list of ref sets
        ///</summary>
        public List<RefTermDto> RefTermList { get; set; } = new List<RefTermDto>();

    }
}
