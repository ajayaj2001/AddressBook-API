using System;

namespace addressbook.Models
{
    public class FileCreatingDto
    {
        public Guid FileId { get; set; }
        public Guid UserId { get; set; }
        public string File { get; set; }
    }
}
