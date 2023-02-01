using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using System.Collections.Generic;
using System;
using AutoMapper;
using System.Linq;
using AddressBook.Contracts.Services;
using AddressBook.Contracts.Repositories;

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
            RefSet RefSetFromRepo = _metaDataRepository.GetRefSet(keyword);
            if (RefSetFromRepo != null)
            {
                IEnumerable<Guid> ResultFromRepo = _metaDataRepository.GetRefTermGroup(RefSetFromRepo.Id);
                IEnumerable<RefTerm> RefTermFromRepo = _metaDataRepository.GetRefTerm(ResultFromRepo);
                IEnumerable<RefTermDto> value = _mapper.Map<IEnumerable<RefTermDto>>(RefTermFromRepo);
                ResultMetaData metaData = new ResultMetaData();
                metaData.Description = RefSetFromRepo.Description;
                metaData.Id = RefSetFromRepo.Id;
                metaData.Key = RefSetFromRepo.Key;
                metaData.RefTermList = value.ToList();
                return metaData;
            }
            ResultMetaData metaData2 = new ResultMetaData();
            metaData2.Key = null;
            return metaData2;
        }
    }
}
