using System;
namespace AddressBook.Entities.Dtos
{
    public class BaseDto
    {


        public string CreatedAt { get; set; }

        ///<summary>
        /// when last updated have time & date 
        ///</summary>
        public string UpdatedAt { get; set; }

        ///<summary>
        /// who created have userId 
        ///</summary>
        public Guid CreatedBy { get; set; }

        ///<summary>
        /// who updated have userId 
        ///</summary>
        public Guid UpdatedBy { get; set; }

    }
}
