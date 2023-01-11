using AddressBook.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using AddressBook.DbContexts;
using System.Linq;

namespace AddressBook.Repositories
{
    public class MetaDataRepository : IMetaDataRepository
    {

        private readonly AddressBookContext _context;

        public MetaDataRepository(AddressBookContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///get all ref set group in db
        ///</summary>
        public IEnumerable<Guid> GetRefSetGroup(Guid id)
        {
            List<Guid> Group = new List<Guid>();
            foreach (SetRefTerm item in _context.SetRefTerms)
            {
                if (item.RefTermId.Equals(id))
                {

                    Group.Add(item.RefSetId);
                }
            }
            return Group;
        }
        ///<summary>
        ///get ref set by id list
        ///</summary>
        public IEnumerable<RefSet> GetRefSet(IEnumerable<Guid> items)
        {

            return _context.RefSets.Where(a => items.Contains(a.Id));
        }

        ///<summary>
        ///get ref term by name
        ///</summary>
        public RefTerm GetRefTerm(string name)
        {
            return _context.RefTerm.FirstOrDefault(a => a.Key == name);
        }


    }
}
