using System;

namespace AddressBook.Entities.Dtos
{
    public class RefSetDto 
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///ref set name 
        ///</summary>
        public string Key { get; set; }

        ///<summary>
        ///ref set description 
        ///</summary>
        public string Description { get; set; }
    }
}
