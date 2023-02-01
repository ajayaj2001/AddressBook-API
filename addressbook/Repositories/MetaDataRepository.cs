using AddressBook.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using AddressBook.DbContexts;
using System.Linq;
using AddressBook.Contracts.Repositories;

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
        ///<param name="id"></param>
        public IEnumerable<Guid> GetRefTermGroup(Guid id)
        {
            List<Guid> Group = new List<Guid>();
            foreach (SetRefTerm item in _context.SetRefTerms)
            {
                if (item.RefSetId.Equals(id))
                {
                    Group.Add(item.RefTermId);
                }
            }
            return Group;
        }
        ///<summary>
        ///get ref term by id list
        ///</summary>
        ///<param name="items"></param>
        public IEnumerable<RefTerm> GetRefTerm(IEnumerable<Guid> items)
        {

            return _context.RefTerm.Where(a => items.Contains(a.Id) && a.IsActive);
        }

        ///<summary>
        ///get set term by name
        ///</summary>
        ///<param name="name"></param>
        public RefSet GetRefSet(string name)
        {
            return _context.RefSets.FirstOrDefault(a => a.Key == name && a.IsActive);
        }


    }
}
