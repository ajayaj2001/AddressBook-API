using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using addressbook.Models;
using addressbook.Services;
using System;
using System.Collections.Generic;
using addressbook.Helper;

namespace addressbook.Controllers
{
    [ApiController]
    [Route("api/meta-data/ref-set")]
    public class MetadataController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IUserRepositary _userRepositary;
        private readonly IMapper _mapper;


        public MetadataController(IUserRepositary UserDetailRepositary, IMapper mapper, IConfiguration config)
        {
            _userRepositary = UserDetailRepositary ?? throw new ArgumentNullException(nameof(UserDetailRepositary));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        [Authorize]
        [HttpGet("{refId}")]
        public IActionResult refSet(int refId)
        {
            ICollection<RefSetDto> resultMetadata;
            switch (refId)
            {
                case 1:
                    resultMetadata = MetadataMapper.getMetaData(_userRepositary, _mapper, "ADDRESS_TYPE");
                    return Ok(resultMetadata);
                case 2:
                    resultMetadata = MetadataMapper.getMetaData(_userRepositary, _mapper, "PHONE_NUMBER_TYPE");
                    return Ok(resultMetadata);
                case 3:
                    resultMetadata = MetadataMapper.getMetaData(_userRepositary, _mapper, "EMAIL_ADDRESS_TYPE");
                    return Ok(resultMetadata);
                case 4:
                    resultMetadata = MetadataMapper.getMetaData(_userRepositary, _mapper, "COUNTRY");
                    return Ok(resultMetadata);
                default:
                    return NotFound();

            }
        }
    }
}
