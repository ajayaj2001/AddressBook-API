using System;

namespace addressbook.Models
{
    public class FileResultDto
    {
        public Guid Id { get; set; }
        public string File_name { get; set; }
        public string File_type { get; set; }
        public long Size { get; set; }
        public string File_content { get; set; }
    }
}
