using AddressBook.Entities.Dtos;
using AddressBook.Entities.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using AddressBook.Contracts;
using AutoMapper;
using AddressBook.Repositories;

namespace AddressBook.Services
{
    public class FileService : IFileService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IFileRepository _fileRepository;

        public FileService(IMapper mapper, IUserRepository UserRepository,IFileRepository fileRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userRepository = UserRepository ?? throw new ArgumentNullException(nameof(UserRepository));
            _fileRepository= fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
        }



        ///<summary>
        ///store and update details in asset 
        ///</summary>
        public FileResultDto StoreImage(Guid userId, IFormFile file, Guid authId)
        {
            Guid fileId;
            using (MemoryStream ms = new MemoryStream())
            {
                Asset ImageEntity = StoreImageInDb(ms, userId, file, authId);
                fileId = ImageEntity.Id;
            }
            return new FileResultDto() { Id = fileId, Size = file.Length, FileName = file.Name };
        }

        ///<summary>
        ///store image in database
        ///</summary>
        public Asset StoreImageInDb(MemoryStream ms, Guid userId, IFormFile file, Guid authId)
        {
            file.CopyTo(ms);
            byte[] fileBytes = ms.ToArray();

            AssetCreatingDto imageCreateDto = new AssetCreatingDto();
            imageCreateDto.File = Convert.ToBase64String(fileBytes);
            imageCreateDto.UserId = userId;
            Asset ImageEntity = _mapper.Map<Asset>(imageCreateDto);
            ImageEntity.CreatedBy = authId;
            ImageEntity.CreatedAt = DateTime.Now.ToString();
            _fileRepository.UploadImage(ImageEntity);
            _userRepository.Save();
            return ImageEntity;
        }
    }
}
