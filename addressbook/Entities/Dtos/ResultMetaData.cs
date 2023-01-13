using System.ComponentModel.DataAnnotations;
using System;
using AddressBook.Entities.Models;
using System.Collections.Generic;

namespace AddressBook.Entities.Dtos
{
    public class ResultMetaData
    {
        [Key]
        public Guid RefTermId { get; set; }

        ///<summary>
        ///ref term name
        ///</summary>
        [Required]
        public string Key { get; set; }

        ///<summary>
        ///description of ref term
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        ///list of ref sets
        ///</summary>
        public List<RefSetDto> RefSetList { get; set; } = new List<RefSetDto>();

    }
}
