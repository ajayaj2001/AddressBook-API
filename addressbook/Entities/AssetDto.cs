using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace addressbook.Entities
{
    public class AssetDto
    {
        [Key]
        public Guid AssetId { get; set; }

        [ForeignKey("FieldId")]
        public Guid FieldId { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}
