using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBook.Entities.Dtos;
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
        private readonly IMetaDataService _metadataServices;
        private readonly ILogger _logger;

        public MetadataController(IMetaDataService metaDataService, ILogger logger)
        {
            _metadataServices = metaDataService ?? throw new ArgumentNullException(nameof(metaDataService));
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
        [SwaggerResponse(200, "Success", typeof(ICollection<RefTermDto>))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult FetchMetaData(string key)
        {
            ResultMetaData value = _metadataServices.FetchMetaData(key);
            _logger.LogInformation("Meta data returned");

            if (value.Key == null)
            {
                _logger.LogError("Meta data not found");
                return NotFound(new ErrorResponse { errorCode = 404, errorMessage = "meta data not found", errorType = "meta-data" });
            }
            return Ok(value);

        }

    }
}
