using AddressBook.Entities.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Contracts.Repositories
{
    public interface IMetaDataRepository
    {
        ///<summary>
        ///get ref set by id list
        ///</summary>
        ///<param name="items"></param>

        IEnumerable<RefTerm> GetRefTerm(IEnumerable<Guid> items);
        //<summary>
        ///get all ref set group in db
        ///</summary>
        ///<param name="id"></param>

        IEnumerable<Guid> GetRefTermGroup(Guid id);

        ///<summary>
        ///get ref term by name
        ///</summary>
        ///<param name="name"></param>
        RefSet GetRefSet(string name);
    }
}
