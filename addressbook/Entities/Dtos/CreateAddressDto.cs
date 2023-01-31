namespace AddressBook.Entities.Dtos
{
    public class CreateAddressDto
    {
        ///<summary>
        ///address type
        ///</summary>
        public string Type { get; set; }

        ///<summary>
        ///address line 1 of user
        ///</summary>
        public string Line1 { get; set; }

        ///<summary>
        ///address line 2 of user
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
        ///address country of user
        ///</summary>
        public string Country { get; set; }

        ///<summary>
        ///address zipcode of user
        ///</summary>
        public string Zipcode { get; set; }
    }
}
