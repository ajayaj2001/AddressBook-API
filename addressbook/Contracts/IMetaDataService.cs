using AddressBook.Entities.Dtos;
using System.Collections.Generic;

namespace AddressBook.Contracts
{
    public interface IMetaDataService
    {
        ///<summary>
        ///return meta data by key
        ///</summary>
        ///<param name="keyword"></param>
        ResultMetaData FetchMetaData(string keyword);
    }
}
