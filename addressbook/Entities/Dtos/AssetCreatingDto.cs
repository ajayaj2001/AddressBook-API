using System;

namespace AddressBook.Entities.Dtos
{
    public class AssetCreatingDto : BaseDto
    {
        ///<summary>
        ///user id who created asset
        ///</summary>
        public Guid UserId { get; set; }

        ///<summary>
        ///file byte string of uploaded image
        ///</summary>
        public string File { get; set; }
    }
}
