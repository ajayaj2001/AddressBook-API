using System.ComponentModel.DataAnnotations;


namespace addressbook.Models
{
    public class EmailCreatingDto
    {

        [Required]
        public string EmailAddress { get; set; } 
        public string Type { get; set; }
    }
}
