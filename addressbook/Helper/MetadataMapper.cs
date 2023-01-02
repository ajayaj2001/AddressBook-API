using addressbook.Models;
using addressbook.Services;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace addressbook.Helper
{
    public class MetadataMapper
    {
       
        public static ICollection<RefSetDto> getMetaData(IUserRepositary userRepositary, IMapper mapper, string keyword)
        {

            var RefTermFromRepo = userRepositary.getRefTerm(keyword);
            var ResultFromRepo = userRepositary.getRefSetGroup(RefTermFromRepo.RefTermId);
            var RefSetFromRepo = userRepositary.getRefSet(ResultFromRepo);
            var value = mapper.Map<IEnumerable<RefSetDto>>(RefSetFromRepo);

            return value.ToList();
        }
    }
}
