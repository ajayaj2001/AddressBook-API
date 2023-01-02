using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace addressbook.Entities
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        [ForeignKey("Type")]
        public Guid TypeId { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        [ForeignKey("Country")]
        public Guid Country { get; set; }
        public string Zipcode { get; set; }
    }
}
