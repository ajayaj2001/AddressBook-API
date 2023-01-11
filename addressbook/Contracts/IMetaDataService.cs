using AddressBook.Entities.Dtos;
using System.Collections.Generic;

namespace AddressBook.Contracts
{
    public interface IMetaDataService
    {
        ICollection<RefSetDto> MetaDataUpdate(string keyword);
    }
}
