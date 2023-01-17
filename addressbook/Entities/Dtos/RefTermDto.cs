using System;

namespace AddressBook.Entities.Dtos
{
    public class RefTermDto 
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///ref term name 
        ///</summary>
        public string Key { get; set; }

        ///<summary>
        ///ref term description 
        ///</summary>
        public string Description { get; set; }
    }
}
