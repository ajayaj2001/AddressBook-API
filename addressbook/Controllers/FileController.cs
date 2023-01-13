using AddressBook.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using AddressBook.Entities.ResponseTypes;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Entities.Dtos;
using AddressBook.Contracts;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using AddressBook.Repositories;

namespace AddressBook.Controllers
{

    [ApiController]
    [Route("api/asset")]
    public class FileController : ControllerBase
    {
        private readonly IFileRepository _fileRepository;
        private readonly IFileService _fileServices;
        private readonly ILogger _logger;

        public FileController(IFileRepository fileRepositary, IFileService fileServices, ILogger logger)
        {
            _fileRepository = fileRepositary ?? throw new ArgumentNullException(nameof(fileRepositary));
            _fileServices = fileServices ?? throw new ArgumentNullException(nameof(fileServices));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        ///<summary> 
        ///Upload User Image
        ///</summary>
        ///<remarks>To upload the user image in db and return image details</remarks> 
        ///<param name="userId"></param> 
        ///<param name="file"></param> 
        ///<response code = "200" >Uploaded image details returned successfully</response> 
        ///<response code = "401" >Not an authorized user</response> 
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpPost("upload-file")]
        [SwaggerOperation(Summary = "Image Upload", Description = "To upload the user image in db and return image details")]
        [SwaggerResponse(200, "Success", typeof(FileResultDto))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]

        public ActionResult UploadImage([FromQuery(Name = "user-Id")] Guid userId, [FromForm] IFormFile file)
        {
            Guid authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (file.Length < 0)
            { _logger.LogError("file empty"); return BadRequest("file empty"); }

            FileResultDto result = _fileServices.StoreImage(userId, file, authId);
            _logger.LogInformation("file uploaded successfully");
            return Ok(result);
        }

        ///<summary> 
        ///Download User Image
        ///</summary>
        ///<remarks>Download the user image by image id</remarks> 
        ///<param name="assetId"></param> 
        ///<response code = "200" >To downloaded the image successfully</response> 
        ///<response code = "401" >Not an authorized user</response> 
        ///<response code = "404" >image not found</response> 
        ///<response code="500">Internel server error</response>
        [Authorize]
        [HttpGet("{asset-Id}")]
        [SwaggerOperation(Summary = "Download User Image", Description = "To download the user image by image id")]
        [SwaggerResponse(200, "Success", typeof(byte[]))]
        [SwaggerResponse(401, "Unauthorized", typeof(ErrorResponse))]
        [SwaggerResponse(404, "Not Found", typeof(ErrorResponse))]
        [SwaggerResponse(500, "Internal server error", typeof(ErrorResponse))]
        public IActionResult DownloadImage([FromQuery(Name = "asset-Id")] Guid assetId)
        {
            Asset Image64 = _fileRepository.RetriveImage(assetId);
            if (Image64 == null)
            { _logger.LogError("image not found"); return NotFound(); }

            MemoryStream outputStream = new MemoryStream(Convert.FromBase64String(Image64.File));
            byte[] bytesInStream = outputStream.ToArray();
            _logger.LogInformation("image downloaded successfully");
            return File(bytesInStream, "APPLICATION/octnet-stream");
        }
    }
}
