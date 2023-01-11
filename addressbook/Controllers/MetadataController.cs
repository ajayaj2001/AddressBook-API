﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBook.Entities.Dtos;
using System.Linq;
using AddressBook.Entities.ResponseTypes;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Contracts;
using Microsoft.Extensions.Logging;

namespace AddressBook.Controllers
{

    [ApiController]
    [Route("api/meta-data/ref-set")]
    public class MetadataController : ControllerBase
    {
        private readonly IService _services;
        private readonly ILogger _logger;

        public MetadataController(IService services, ILogger logger)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        ///<summary> 
        ///Get Metadata 
        ///</summary>
        ///<remarks>To get the metadata list like Address Type, Email address type, phone number type,country etc.,</remarks> 
        ///<param name="key"></param> 
        ///<response code = "200" >List of metadata linked to the key returned Successfully</response> 
        ///<response code = "401" >Not an authorized user</response>
        ///<response code = "404" >MetaData type not found</response>
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpGet("{key}")]
        [SwaggerOperation(Summary = "Get Metadata Types", Description = "To get the metadata list like Address Type etc.")]
        [SwaggerResponse(200, "Success", typeof(ICollection<RefSetDto>))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult FetchMetaData(string key)
        {
            string[] types = new string[] { "ADDRESS_TYPE", "PHONE_NUMBER_TYPE", "EMAIL_ADDRESS_TYPE", "COUNTRY" };
            if (!types.Contains(key))
            { _logger.LogError("meta data not found"); return NotFound(); }

            ICollection<RefSetDto> value = _services.MetaDataUpdate(key);
            _logger.LogInformation("meta data returned successfully");
            return Ok(value);
        }
    }
}
