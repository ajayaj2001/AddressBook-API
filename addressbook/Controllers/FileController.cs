using addressbook.Entities;
using addressbook.Models;
using addressbook.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace addressbook.Controllers
{

    [ApiController]
    [Route("api/asset")]
    public class FileController : ControllerBase
    {

        private readonly IUserRepositary _userRepositary;
        private readonly IMapper _mapper;

        public FileController(IUserRepositary UserRepositary, IMapper mapper)
        {
            _userRepositary = UserRepositary ?? throw new ArgumentNullException(nameof(UserRepositary));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize]
        [HttpPost("upload-file")]

        public async Task<ActionResult> UploadImage([FromQuery] Guid userId, [FromForm] IFormFile file)
        {
            Guid fileId ;

            if (file.Length < 0)
            {
                return BadRequest();
            }

            await using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();

                FileCreatingDto imageCreateDto = new FileCreatingDto();

                imageCreateDto.File = Convert.ToBase64String(fileBytes);

                imageCreateDto.UserId = userId;

                var ImageEntity = _mapper.Map<ImageFile>(imageCreateDto);

                _userRepositary.UploadImage(ImageEntity);
                _userRepositary.Save();
               

                //get image id and store in asset db
                AssetDtoCreating assetDtoCreating = new AssetDtoCreating();
                assetDtoCreating.FieldId = _userRepositary.GetImageIdByUserId(userId);

                assetDtoCreating.UserId = userId;

                var AssetFromRepo = _userRepositary.GetAssetById(userId);
                if (AssetFromRepo != null)
                {
                    _mapper.Map(AssetFromRepo, assetDtoCreating);
                    _userRepositary.UpdateAsset(AssetFromRepo);
                    _userRepositary.Save();
                }
                else
                {
                    var Asset = _mapper.Map<AssetDto>(assetDtoCreating);
                    _userRepositary.AddAsset(Asset);
                    _userRepositary.Save();
                }

                fileId = ImageEntity.FileId;
            }
            return Ok(new FileResultDto() {Id=fileId ,File_type = file.ContentType, Size = file.Length, File_name = file.Name, File_content = file.ContentDisposition });
        }

        [Authorize]
        [HttpGet("{assetId}")]
        public IActionResult DownloadImage(string assetId)
        {

            if (!Guid.TryParse(assetId, out Guid guid))
                return BadRequest("enter valid id");

            var Image64 = _userRepositary.RetriveImage(Guid.Parse(assetId));

            if (Image64 == null)
            {
                return NotFound();
            }

            var outputStream = new MemoryStream(Convert.FromBase64String(Image64.File));

            byte[] bytesInStream = outputStream.ToArray();

            return File(bytesInStream, "APPLICATION/octnet-stream");

        }
    }
}
