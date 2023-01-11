using AddressBook.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using AddressBook.Entities.ResponseTypes;
using Swashbuckle.AspNetCore.Annotations;
using AddressBook.Entities.Dtos;
using AddressBook.Contracts;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace AddressBook.Controllers
{

    [ApiController]
    [Route("api/asset")]
    public class FileController : ControllerBase
    {
        private readonly IAddressBookRepository _userRepository;
        private readonly IService _services;
        private readonly ILogger _logger;

        public FileController(IAddressBookRepository UserRepositary, IService services, ILogger logger)
        {
            _userRepository = UserRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        ///<summary> 
        ///Upload User Image
        ///</summary>
        ///<remarks>To upload the user image in db and return image details</remarks> 
        ///<param name="user-Id"></param> 
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
            Guid authId;
            if (String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
             authId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); 
            else //while testing dummy userid
                authId = Guid.Parse("6ebb437a-03e5-4ebf-83fa-652f548368f2");

            if (file.Length < 0)
            { _logger.LogError("file empty"); return BadRequest("file empty"); }

            FileResultDto result = _services.StoreImage(userId, file,authId);
            _logger.LogInformation("file uploaded successfully");
            return Ok(result);
        }

        ///<summary> 
        ///Download User Image
        ///</summary>
        ///<remarks>Download the user image by image id</remarks> 
        ///<param name="asset-Id"></param> 
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
            

            Asset Image64 = _userRepository.RetriveImage(assetId);
            if (Image64 == null)
            { _logger.LogError("image not found"); return NotFound(); }

            MemoryStream outputStream = new MemoryStream(Convert.FromBase64String(Image64.File));
            byte[] bytesInStream = outputStream.ToArray();
            _logger.LogInformation("image downloaded successfully");
            return File(bytesInStream, "APPLICATION/octnet-stream");
        }
    }
}
