using AddressBook.Entities.Dtos;
using System.Collections.Generic;

namespace AddressBook.Contracts.Services
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
