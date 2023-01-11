using System;

namespace AddressBook.Entities.Dtos
{
    public class AddressDto 
    {
        ///<summary>
        ///unique id of field
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///user id of who created address
        ///</summary>
        public Guid UserId { get; set; }

        ///<summary>
        ///address line 1 of user
        ///</summary>
        public string Line1 { get; set; }

        ///<summary>
        ///address line 1 of user
        ///</summary>
        public string Line2 { get; set; }

        ///<summary>
        ///address city of user
        ///</summary>
        public string City { get; set; }

        ///<summary>
        ///address state name of user
        ///</summary>
        public string StateName { get; set; }

        ///<summary>
        ///address zipcode of user
        ///</summary>
        public string Zipcode { get; set; }

        ///<summary>
        ///address type id
        ///</summary>
        public Guid TypeId { get; set; }

        ///<summary>
        ///address country of user
        ///</summary>
        public Guid Country { get; set; }
    }
}
