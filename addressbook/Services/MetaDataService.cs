using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using System.Collections.Generic;
using System;
using AddressBook.Contracts;
using AutoMapper;
using System.Linq;
using AddressBook.Repositories;

namespace AddressBook.Services
{
    public class MetaDataService : IMetaDataService
    {
        private readonly IMapper _mapper;
        private readonly IMetaDataRepository _metaDataRepository;

        public MetaDataService(IMapper mapper, IMetaDataRepository metaDataRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _metaDataRepository = metaDataRepository ?? throw new ArgumentNullException(nameof(metaDataRepository));
        }


        ///<summary>
        ///return meta data by key
        ///</summary>
        ///<param name="keyword"></param>
        public ResultMetaData FetchMetaData(string keyword)
        {
            RefTerm RefTermFromRepo = _metaDataRepository.GetRefTerm(keyword);
            if (RefTermFromRepo != null)
            {
                IEnumerable<Guid> ResultFromRepo = _metaDataRepository.GetRefSetGroup(RefTermFromRepo.Id);
                IEnumerable<RefSet> RefSetFromRepo = _metaDataRepository.GetRefSet(ResultFromRepo);
                IEnumerable<RefSetDto> value = _mapper.Map<IEnumerable<RefSetDto>>(RefSetFromRepo);
                ResultMetaData metaData = new ResultMetaData();
                metaData.Description = RefTermFromRepo.Description;
                metaData.RefTermId = RefTermFromRepo.Id;
                metaData.Key = RefTermFromRepo.Key;
                metaData.RefSetList = value.ToList();
                return metaData;
            }
            ResultMetaData metaData2 = new ResultMetaData();
            metaData2.Key = null;
            return metaData2;
        }
    }
}
