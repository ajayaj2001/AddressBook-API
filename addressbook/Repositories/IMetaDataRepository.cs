using AddressBook.Entities.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Repositories
{
    public interface IMetaDataRepository
    {
        IEnumerable<RefSet> GetRefSet(IEnumerable<Guid> items);

        IEnumerable<Guid> GetRefSetGroup(Guid id);

        RefTerm GetRefTerm(string name);
    }
}
