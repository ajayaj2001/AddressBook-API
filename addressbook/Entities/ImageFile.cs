using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace addressbook.Entities
{
    public class ImageFile
    {
        [Key]
        public Guid FileId { get; set; }
        
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength]
        public string File { get; set; }


    }
}
