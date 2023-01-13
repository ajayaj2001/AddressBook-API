using AddressBook.Entities.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Repositories
{
    public interface IMetaDataRepository
    {
        ///<summary>
        ///get ref set by id list
        ///</summary>
        ///<param name="items"></param>
        
        IEnumerable<RefSet> GetRefSet(IEnumerable<Guid> items);
        //<summary>
        ///get all ref set group in db
        ///</summary>
        ///<param name="id"></param>
    
        IEnumerable<Guid> GetRefSetGroup(Guid id);

        ///<summary>
        ///get ref term by name
        ///</summary>
        ///<param name="name"></param>
        RefTerm GetRefTerm(string name);
    }
}
