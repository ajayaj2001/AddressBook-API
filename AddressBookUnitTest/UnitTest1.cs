using AddressBook.Contracts;
using AddressBook.Controllers;
using AddressBook.DbContexts;
using AddressBook.Entities.Dtos;
using AddressBook.Entities.ResponseTypes;
using AddressBook.Repositories;
using AddressBook.Services;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using System.Linq;
using AddressBookUnitTest.DbContext;

namespace AddressBookUnitTest
{
    public class UnitTest1
    {
        private readonly AddressBookController _addresBookController;
        private readonly MetadataController _metaDataController;
        private readonly AuthController _authController;
        private readonly FileController _fileController;
        private readonly AddressBookRepository _addressBookRepository;
        private readonly IService _addressBookServices;
        private readonly AddressBookContext _context;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public UnitTest1()
        {

            _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();

            using var services = new ServiceCollection()
                            .AddSingleton<Microsoft.Extensions.Configuration.IConfiguration>(_configuration)
                            // -> add your DI needs here
                            .BuildServiceProvider();

            AddressBookContext context = TestDbContext.addressBookDbContext();
            _context = TestData.AddData(context);
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder().
           ConfigureLogging((builderContext, loggingBuilder) =>
           {
               loggingBuilder.AddConsole((options) =>
               {
                   options.IncludeScopes = true;
               });
           });
            IHost host = hostBuilder.Build();
           _logger = host.Services.GetRequiredService<ILogger<AddressBookController>>();

            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AddressBook.Profiles.Mapper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            _addressBookRepository = new AddressBookRepository(_context);
            _addressBookServices = new Service(_configuration, _mapper, _addressBookRepository);
            _addresBookController = new AddressBookController(_addressBookRepository, _addressBookServices, _logger);
            _metaDataController = new MetadataController(_addressBookServices, _logger);
            _authController = new AuthController(_addressBookRepository, _addressBookServices, _logger);
            _fileController = new FileController(_addressBookRepository, _addressBookServices, _logger);
        }

        /// <summary>
        ///   To test address book count 
        /// </summary>
        [Fact]
        public void GetAddressBookCount_OkObjectResult()
        {
            OkObjectResult response = _addresBookController.GetAddressBookCount() as OkObjectResult;
            Assert.IsType<CountSuccessResponse>(response.Value);

            CountSuccessResponse resultCount = response.Value as CountSuccessResponse;
            Assert.Equal(2, resultCount.count);
        }

        /// <summary>
        ///   To test get address book by user id
        /// </summary>
        [Fact]
        public void GetAddressBookById_OkObjectResult()
        {
            Guid userId1 = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425");
            ActionResult response1 = _addresBookController.GetAddressBookById(userId1) as ActionResult;
            Assert.IsType<OkObjectResult>(response1);
            OkObjectResult item = response1 as OkObjectResult;
            Assert.IsType<UserDto>(item.Value);

            Guid userId2 = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5466");
            ActionResult response2 = _addresBookController.GetAddressBookById(userId2) as ActionResult;
            Assert.IsType<NotFoundResult>(response2);
        }

        /// <summary>
        ///  To test the get all address book
        /// </summary>
        [Fact]
        public void GetAllAddress_OkObjectResult()
        {
            PageSortParam page = new PageSortParam() { PageNo = 1, Size = 1 };

            ActionResult response1 = _addresBookController.GetAllAddressBook(page) as ActionResult;
            Assert.IsType<OkObjectResult>(response1);
            OkObjectResult item = response1 as OkObjectResult;
            Assert.IsType<List<UserDto>>(item.Value);
        }

        /// <summary>
        ///  To test the delete address book
        /// </summary>
        [Fact]
        public void deleteAddressBook_OkObjectResult()
        {
            Guid userId1 = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425");
            ActionResult response1 = _addresBookController.DeleteAddressBook(userId1) as ActionResult;
            Assert.IsType<OkObjectResult>(response1);
            OkObjectResult item = response1 as OkObjectResult;
            Assert.IsType<string>(item.Value);

            Guid userId2 = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5466");
            ActionResult response2 = _addresBookController.DeleteAddressBook(userId2) as ActionResult;
            Assert.IsType<NotFoundResult>(response2);
        }

        /// <summary>
        ///  To test the login user
        /// </summary>
        [Fact]
        public void login_OkObjectResult()
        {
            LoginDetailsDto loginDetails = new LoginDetailsDto() { UserName = "Ajay Kumar", Password = "12345werWER@" };
            var response1 = _authController.UserLogin(loginDetails);
            Assert.IsType<OkObjectResult>(response1);
  
            LoginDetailsDto loginDetails2 = new LoginDetailsDto() { UserName = "Ajaydd Kumar", Password = "12345werWER@" };
            var response2 = _authController.UserLogin(loginDetails2);
            Assert.IsType<UnauthorizedObjectResult>(response2);
        }

        /// <summary>
        ///   To test the create method in the user
        /// </summary>
        [Fact]
        public void Create_AddressBook_ReturnOkResponses()
        {
            UserCreatingDto user = new UserCreatingDto()
            {
                FirstName = "pradeep",
                LastName = "kumar",
                UserName = "pradeep kumar",
                Password = "pradeeeP@77",
                Addresses = new List<AddressCreatingDto>(),
                Emails = new List<EmailCreatingDto>(),
                Phones = new List<PhoneNumberCreatingDto>(),
            };
            user.Addresses.Add(new AddressCreatingDto()
            {
                Line1 = "24 seval",
                Line2 = "nandavanam",
                City = "dindigul",
                Zipcode = "123123",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new EmailCreatingDto()
            {
                EmailAddress = "who@ajay.live",
                Type = "WORK"
            });
            user.Phones.Add(new PhoneNumberCreatingDto()
            {
                PhoneNumber = "8189900490",
                Type = "PERSONAL"
            });
            ActionResult<string> account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<OkObjectResult>(account.Result);

            // If the email or phone number is already exist
            user.Emails.First().EmailAddress = "ajay@gmail.com";
            user.Emails.First().Type = "PERSONAL";
            user.Phones.First().Type = "PERSONAL";
            user.Addresses.First().Type = "PERSONAL";
            user.Addresses.First().Country = "INDIA";
            account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<ConflictObjectResult>(account.Result);

            //If the RefTerm Not Found
            user.Emails.First().EmailAddress = "ajay@gmail.com";
            user.Phones.First().PhoneNumber = "2345678999";
            user.Addresses.First().Type = "alternative";
            account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<NotFoundObjectResult>(account.Result);
        }

        /// <summary>
        ///   To test the update method in the user
        /// </summary>
        [Fact]
        public void Update_AddressBook_ReturnOkResponses()
        {
            UserUpdatingDto user = new UserUpdatingDto()
            {
                FirstName = "Ram",
                LastName = "kumar",
                Addresses = new List<AddressUpatingDto>(),
                Emails = new List<EmailUpdatingDto>(),
                Phones = new List<PhoneNumberUpdatingDto>(),
            };
            user.Addresses.Add(new AddressUpatingDto()
            {
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                Zipcode = "626101",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new EmailUpdatingDto()
            {
                EmailAddress = "support@ajay.live",
                Type = "PERSONAL"
            });
            user.Phones.Add(new PhoneNumberUpdatingDto()
            {
                PhoneNumber = "8189900410",
                Type = "PERSONAL"
            });

            Guid userId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425");
            ActionResult<string> account = _addresBookController.UpdateAddressBook(userId, user);
            Assert.IsType<OkObjectResult>(account.Result);

            // If the email or phone number is already exist
            user.Emails.First().EmailAddress = "ajay@gmail.com";
            user.Emails.First().Type = "PERSONAL";
            user.Phones.First().Type = "PERSONAL";
            user.Addresses.First().Type = "PERSONAL";
            user.Addresses.First().Country = "INDIA";
            account = _addresBookController.UpdateAddressBook(Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"), user);
            Assert.IsType<ConflictObjectResult>(account.Result);

            //If the RefTerm Not Found
            user.Emails.First().EmailAddress = "ajay@gmail.com";
            user.Phones.First().PhoneNumber = "2345678999";
            user.Addresses.First().Type = "alternative";
            account = _addresBookController.UpdateAddressBook(Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"), user);
            Assert.IsType<NotFoundObjectResult>(account.Result);
        }

        /// <summary>
        ///  To test the meta data type
        /// </summary>
        [Fact]
        public void MetaData_OkObjectResult()
        {
            string key = "PHONE_NUMBER_TYPE";
            ActionResult response = _metaDataController.FetchMetaData(key) as ActionResult;
            Assert.IsType<OkObjectResult>(response);

            OkObjectResult item = response as OkObjectResult;
            List<RefSetDto> list = item.Value as List<RefSetDto>;
            Assert.Equal("PERSONAL", list[0].Key);

            string key2 = "NAME_TYPE";
            ActionResult response2 = _metaDataController.FetchMetaData(key2) as ActionResult;
            Assert.IsType<NotFoundResult>(response2);
        }

        // <summary>
        ///  To test the upload image
        /// </summary>
        [Fact]
        public void UploadFie_ReturnOkResponse()
        {
            Guid userId = new Guid("7cf56f52-1aab-4646-b090-d337aac18370");


            string path = @"F:\work\project\training\Address Book\AddressBookUnitTest\data\files\response.jpeg";
            IFormFile File;
            using (var stream = System.IO.File.OpenRead(path))
            {
                File = new FormFile(stream, 0, stream.Length, Path.GetFileName(stream.Name), Path.GetFileName(stream.Name));
                
                var response = _fileController.UploadImage(userId, File);
                Assert.IsType<OkObjectResult>(response);
            };
        }

        // <summary>
        ///  To test the download image
        /// </summary>
        [Fact]
        public void Download_FieContentResult()
        {
            Guid assetId = new Guid("876072b6-04e4-4577-b21c-946e96bef643");
            var response = _fileController.DownloadImage(assetId);
            Assert.IsType<FileContentResult>(response);

            Guid assetId2 = new Guid("555072b6-04e4-4577-b21c-946e96bef643");
            var response2 = _fileController.DownloadImage(assetId2);
            Assert.IsType<NotFoundResult>(response2);
        }

    }
}
