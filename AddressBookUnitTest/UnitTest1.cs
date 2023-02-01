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
using AddressBookUnitTest.DbContext;
using Moq;
using System.Security.Claims;
using AddressBook.Contracts.Services;

namespace AddressBookUnitTest
{
    public class UnitTest1
    {
        private readonly UserController _addresBookController;
        private readonly MetadataController _metaDataController;
        private readonly AuthController _authController;
        private readonly FileController _fileController;
        private readonly UserRepository _addressBookRepository;
        private readonly AuthRepository _authRepository;
        private readonly FileRepository _fileRepository;
        private readonly MetaDataRepository _metaDataRepository;
        private readonly IUserService _addressBookServices;
        private readonly IAuthService _authService;
        private readonly IMetaDataService _metadataService;
        private readonly IFileService _fileService;
        private readonly AddressBookContext _context;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public UnitTest1()
        {
            _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();

            using ServiceProvider services = new ServiceCollection()
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
            _logger = host.Services.GetRequiredService<ILogger<UserController>>();

            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AddressBook.Profiles.Mapper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            _addressBookRepository = new UserRepository(_context);
            _authRepository = new AuthRepository(_context);
            _metaDataRepository = new MetaDataRepository(_context);
            _fileRepository = new FileRepository(_context);
            _authService = new AuthService(_configuration,_authRepository);
            _addressBookServices = new UserService(_mapper, _addressBookRepository, _logger);
            _metadataService = new MetaDataService(_mapper, _metaDataRepository);
            _fileService = new FileService(_mapper, _addressBookRepository, _fileRepository);
            _addresBookController = new UserController(_addressBookServices, _logger);
            _metaDataController = new MetadataController(_metadataService, _logger);
            _authController = new AuthController(_authService, _logger);
            _fileController = new FileController(_fileService, _logger);

            string userId = "7cf56f52-1aab-4646-b090-d337aac18370";
            Mock<HttpContext> contextMock = new Mock<HttpContext>();
            contextMock.Setup(x => x.User).Returns(new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId)
                                        // other required and custom claims
                           }, "TestAuthentication")));
            _addresBookController.ControllerContext.HttpContext = contextMock.Object;
            _fileController.ControllerContext.HttpContext = contextMock.Object;
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
            Assert.Equal(3, resultCount.count);
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
        }

        /// <summary>
        ///   To test get address book using non existing user id
        /// </summary>
        [Fact]
        public void GetAddressBookById_NotFoundObjectResult()
        {
            Guid userId2 = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5466");
            ActionResult response2 = _addresBookController.GetAddressBookById(userId2) as ActionResult;
            Assert.IsType<NotFoundObjectResult>(response2);
        }

        /// <summary>
        ///  To test the get all address book
        /// </summary>
        [Fact]
        public void GetAllAddress_OkObjectResult()
        {
            ActionResult response1 = _addresBookController.GetAllAddressBook(10, 1) as ActionResult;
            Assert.IsType<OkObjectResult>(response1);
            OkObjectResult item = response1 as OkObjectResult;
            Assert.IsType<List<UserDto>>(item.Value);
        }

        /// <summary>
        ///  To test the get all address book by non existing field
        /// </summary>
        [Fact]
        public void GetAllAddress_NotFoundObjectResult()
        {
            ActionResult response1 = _addresBookController.GetAllAddressBook(10, 1,"email") as ActionResult;
            Assert.IsType<NotFoundObjectResult>(response1);
        }

        /// <summary>
        ///  To test the login user
        /// </summary>
        [Fact]
        public void login_OkObjectResult()
        {
            LoginDetailsDto loginDetails = new LoginDetailsDto() { UserName = "Ajay Kumar", Password = "12345werWER@" };
            IActionResult response1 = _authController.UserLogin(loginDetails);
            Assert.IsType<OkObjectResult>(response1);
        }

        /// <summary>
        ///  To test the login user by invalid data
        /// </summary>
        [Fact]
        public void login_UnauthorizedObjectResult()
        {
            LoginDetailsDto loginDetails2 = new LoginDetailsDto() { UserName = "Ajaydd Kumar", Password = "12345werWER@" };
            IActionResult response2 = _authController.UserLogin(loginDetails2);
            Assert.IsType<UnauthorizedObjectResult>(response2);
        }

        /// <summary>
        ///   To test the create method in the user
        /// </summary>
        [Fact]
        public void Create_AddressBook_OkResponses()
        {
            CreateUserDto user = new CreateUserDto()
            {
                FirstName = "pradeep",
                LastName = "kumar",
                UserName = "pradeep kumar",
                Password = "pradeeeP@77",
                Addresses = new List<CreateAddressDto>(),
                Emails = new List<CreateEmailDto>(),
                Phones = new List<CreatePhoneNumberDto>(),
            };
            user.Addresses.Add(new CreateAddressDto()
            {
                Line1 = "24 seval",
                Line2 = "nandavanam",
                City = "dindigul",
                Zipcode = "123123",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new CreateEmailDto()
            {
                EmailAddress = "who@ajay.live",
                Type = "WORK"
            });
            user.Phones.Add(new CreatePhoneNumberDto()
            {
                PhoneNumber = "8189900490",
                Type = "PERSONAL"
            });

            ActionResult<string> account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<OkObjectResult>(account.Result);
        }


        /// <summary>
        ///   To test the create method using existing email
        /// </summary>
        [Fact]
        public void Create_AddressBook_ConflictObjectResult()
        {
            CreateUserDto user = new CreateUserDto()
            {
                FirstName = "pradeep",
                LastName = "kumar",
                UserName = "pradeep kumar",
                Password = "pradeeeP@77",
                Addresses = new List<CreateAddressDto>(),
                Emails = new List<CreateEmailDto>(),
                Phones = new List<CreatePhoneNumberDto>(),
            };
            user.Addresses.Add(new CreateAddressDto()
            {
                Line1 = "24 seval",
                Line2 = "nandavanam",
                City = "dindigul",
                Zipcode = "123123",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new CreateEmailDto()
            {
                EmailAddress = "admin@ajay.live",
                Type = "PERSONAL"
            });
            user.Phones.Add(new CreatePhoneNumberDto()
            {
                PhoneNumber = "8189900490",
                Type = "PERSONAL"
            });

            ActionResult<string> account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<ConflictObjectResult>(account.Result);
        }

        /// <summary>
        ///   To test the create method using non existing type
        /// </summary>
        [Fact]
        public void Create_AddressBook_NotFoundObjectResult()
        {
            CreateUserDto user = new CreateUserDto()
            {
                FirstName = "pradeep",
                LastName = "kumar",
                UserName = "pradeep kumar",
                Password = "pradeeeP@77",
                Addresses = new List<CreateAddressDto>(),
                Emails = new List<CreateEmailDto>(),
                Phones = new List<CreatePhoneNumberDto>(),
            };
            user.Addresses.Add(new CreateAddressDto()
            {
                Line1 = "24 seval",
                Line2 = "nandavanam",
                City = "dindigul",
                Zipcode = "123123",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new CreateEmailDto()
            {
                EmailAddress = "ajay@gmail.com",
                Type = "PERSONAL"
            });
            user.Phones.Add(new CreatePhoneNumberDto()
            {
                PhoneNumber = "2345678999",
                Type = "alternative"
            });

            ActionResult<string> account = _addresBookController.CreateAddressBook(user);
            Assert.IsType<NotFoundObjectResult>(account.Result);
        }

        /// <summary>
        ///   To test the update method in the user
        /// </summary>
        [Fact]
        public void Update_AddressBook_ReturnOkResponses()
        {
            UpdateUserDto user = new UpdateUserDto()
            {
                FirstName = "Ram",
                LastName = "kumar",
                Addresses = new List<UpdateAddressDto>(),
                Emails = new List<UpdateEmailDto>(),
                Phones = new List<UpdatePhoneNumberDto>(),
            };
            user.Addresses.Add(new UpdateAddressDto()
            {
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                Zipcode = "626101",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new UpdateEmailDto()
            {
                EmailAddress = "support@ajay.live",
                Type = "PERSONAL"
            });
            user.Phones.Add(new UpdatePhoneNumberDto()
            {
                PhoneNumber = "8189900410",
                Type = "PERSONAL"
            });

            Guid userId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425");
            ActionResult<string> account = _addresBookController.UpdateAddressBook(userId, user);
            Assert.IsType<OkObjectResult>(account.Result);
        }

        /// <summary>
        ///   To test the update method with non existing type
        /// </summary>
        [Fact]
        public void Update_AddressBook_NotFoundObjectResponses()
        {
            UpdateUserDto user = new UpdateUserDto()
            {
                FirstName = "Ram",
                LastName = "kumar",
                Addresses = new List<UpdateAddressDto>(),
                Emails = new List<UpdateEmailDto>(),
                Phones = new List<UpdatePhoneNumberDto>(),
            };
            user.Addresses.Add(new UpdateAddressDto()
            {
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                Zipcode = "626101",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new UpdateEmailDto()
            {
                EmailAddress = "ajay@gmail.com",
                Type = "PERSONAL"
            });
            user.Phones.Add(new UpdatePhoneNumberDto()
            {
                PhoneNumber = "2345678999",
                Type = "alternative"
            });
            //If the RefTerm Not Found
            ActionResult<string> account = _addresBookController.UpdateAddressBook(Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"), user);
            Assert.IsType<NotFoundObjectResult>(account.Result);
        }

        /// <summary>
        ///   To test the update method with existing email
        /// </summary>
        [Fact]
        public void Update_AddressBook_ConflitObjectResult()
        {
            UpdateUserDto user = new UpdateUserDto()
            {
                FirstName = "Ram",
                LastName = "kumar",
                Addresses = new List<UpdateAddressDto>(),
                Emails = new List<UpdateEmailDto>(),
                Phones = new List<UpdatePhoneNumberDto>(),
            };
            user.Addresses.Add(new UpdateAddressDto()
            {
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                Zipcode = "626101",
                StateName = "tamil nadu",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            user.Emails.Add(new UpdateEmailDto()
            {
                EmailAddress = "admin2@ajay.live",
                Type = "PERSONAL"
            });
            user.Phones.Add(new UpdatePhoneNumberDto()
            {
                PhoneNumber = "8189900410",
                Type = "PERSONAL"
            });
            // If the email or phone number is already exist
           ActionResult<string> account = _addresBookController.UpdateAddressBook(Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"), user);
            Assert.IsType<ConflictObjectResult>(account.Result);
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
            ResultMetaData list = item.Value as ResultMetaData;
            Assert.Equal("PERSONAL", list.RefTermList[0].Key);
        }

        /// <summary>
        ///  To test the meta data type using non existing type
        /// </summary>
        [Fact]
        public void MetaData_NotFoundObjectResult()
        {
            string key2 = "NAME_TYPE";
            ActionResult response2 = _metaDataController.FetchMetaData(key2) as ActionResult;
            Assert.IsType<NotFoundObjectResult>(response2);
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
            using (FileStream stream = System.IO.File.OpenRead(path))
            {
                File = new FormFile(stream, 0, stream.Length, Path.GetFileName(stream.Name), Path.GetFileName(stream.Name));

                ActionResult response = _fileController.UploadImage(userId, File);
                Assert.IsType<OkObjectResult>(response);
            };
        }

        // <summary>
        ///  To test the download image
        /// </summary>
        [Fact]
        public void DownloadFile_ContentResult()
        {
            Guid assetId = new Guid("876072b6-04e4-4577-b21c-946e96bef643");
            IActionResult response = _fileController.DownloadImage(assetId);
            Assert.IsType<FileContentResult>(response);
        }

        // <summary>
        ///  To test the download image using non existing image id
        /// </summary>
        [Fact]
        public void DownloadFile_NotFoundObjectResult()
        {
            Guid assetId2 = new Guid("555072b6-04e4-4577-b21c-946e96bef643");
            IActionResult response2 = _fileController.DownloadImage(assetId2);
            Assert.IsType<NotFoundObjectResult>(response2);
        }


        /// <summary>
        ///  To test the delete address book
        /// </summary>
        [Fact]
        public void deleteAddressBook_OkObjectResult()
        {
            Guid userId1 = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370");
            ActionResult response1 = _addresBookController.DeleteAddressBook(userId1) as ActionResult;
            Assert.IsType<OkObjectResult>(response1);
            OkObjectResult item = response1 as OkObjectResult;
            Assert.IsType<string>(item.Value);
        }

        /// <summary>
        ///  To test the delete address book using non existing id
        /// </summary>
        [Fact]
        public void deleteAddressBook_NotFoundObjectResult()
        {
            Guid userId2 = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18355");
            ActionResult response2 = _addresBookController.DeleteAddressBook(userId2) as ActionResult;
            Assert.IsType<NotFoundObjectResult>(response2);
        }
    }
}
