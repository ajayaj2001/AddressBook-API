using Microsoft.EntityFrameworkCore;
using addressbook.Entities;
using System;

namespace addressbook.DbContexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<PhoneNumber> Phones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RefSet> RefSets { get; set; }
        public DbSet<RefTerm> RefTerm { get; set; }
        public DbSet<SetRefTerm> SetRefTerms { get; set; }
        public DbSet<ImageFile> ImageFile { get; set; }
        public DbSet<AssetDto> AssetDtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user data
            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                First_name = "Ajay",
                Last_name = "Kumar",
                User_name = "Ajay Kumar",
                Password = "12345werWER@"
            },
            new User()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                First_name = "Ram",
                Last_name = "Kumar",
                Password = "12345werWER@",
                User_name = "Ram Kumar",
            }

            );

            //address data
            modelBuilder.Entity<Address>().HasData(
                new Address()
                {
                    UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                    AddressId = Guid.Parse("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                    Line1 = "psna college",
                    Line2 = "psna nagar",
                    City = "dindigul",
                    StateName = "tamilnadu",
                    TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                    Country = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                    Zipcode = "625422"
                },
            new Address()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                AddressId = Guid.Parse("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                StateName = "tamilnadu",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                Country = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                Zipcode = "626101"
            }
            );

            //ph number data
            modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber()
            {
                UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                PhoneId = Guid.Parse("65ec5717-5626-442a-afb5-532caedeab32"),
                Phone_number = "7397142913",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005")
            },
            new PhoneNumber()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                PhoneId = Guid.Parse("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                Phone_number = "8189900410",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005")

            }
            );

            //email data
            modelBuilder.Entity<Email>().HasData(new Email()
            {
                UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                EmailId = Guid.Parse("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                EmailAddress = "admin@ajay.live",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005")

            },
            new Email()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                EmailId = Guid.Parse("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                EmailAddress = "support@ajay.live",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005")

            });

            modelBuilder.Entity<ImageFile>().Property(b => b.File).HasColumnType("varchar(max)");

            
            //     RefSet

            modelBuilder.Entity<RefSet>().HasData(new RefSet()
            {
                Name = "PERSONAL",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                Description = "denotes personal based things"
            },
            new RefSet()
            {
                Name = "WORK",
                TypeId = Guid.Parse("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                Description = "denotes work based things"
            },
            new RefSet()
            {
                Name = "INDIA",
                TypeId = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                Description = "denotes country india",
            },
            new RefSet()
            {
                Name = "UNITED_STATES",
                TypeId = Guid.Parse("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                Description = "denotes country usa"
            },
            new RefSet()
            {
                TypeId = Guid.Parse("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                Name = "OTHER",
                Description = "denotes other things"
            }
            );
            
            // RefTerm
            
            modelBuilder.Entity<RefTerm>().HasData(new RefTerm()
            {
                RefTermId = Guid.Parse("2094b365-b61a-477e-a52a-36c00865962d"),
                Type = "ADDRESS_TYPE",
                Description = "Types of addresses"
            },
            new RefTerm()
            {
                RefTermId = Guid.Parse("147b6392-722c-4375-a396-71234fad8ece"),
                Type = "PHONE_NUMBER_TYPE",
                Description = "Types of phonenumber"
            },
            new RefTerm()
            {
                RefTermId = Guid.Parse("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                Type = "EMAIL_ADDRESS_TYPE",
                Description = "Types of emails"
            },
            new RefTerm()
            {
                RefTermId = Guid.Parse("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                Type = "COUNTRY",
                Description = "Types of countries"
            }
            );
            


            //     set RefTerm

            modelBuilder.Entity<SetRefTerm>().HasData(
            //Address Type
            new SetRefTerm()
            {
                RefTermId = Guid.Parse("2094b365-b61a-477e-a52a-36c00865962d"),
                RefSetId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                SetRefTermId = Guid.Parse("60802b12-c78d-4c85-980f-8098a0ff23d7")
            },
            new SetRefTerm()
            {
                RefTermId = Guid.Parse("2094b365-b61a-477e-a52a-36c00865962d"),
                RefSetId = Guid.Parse("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                SetRefTermId = Guid.Parse("e5d19692-9936-47b3-ad37-4ef28ac69824")
            },


            //Phone Number Type

            //Personal
            new SetRefTerm()
            {
                RefTermId = Guid.Parse("147b6392-722c-4375-a396-71234fad8ece"),
                RefSetId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                SetRefTermId = Guid.Parse("f06a2c4b-e618-4eaa-83bf-368870350a65")
            },
            //Work
            new SetRefTerm()
            {
                RefTermId = Guid.Parse("147b6392-722c-4375-a396-71234fad8ece"),
                RefSetId = Guid.Parse("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                SetRefTermId = Guid.Parse("9d118fca-ac40-4b05-b3be-0c3300baa8e0")
            },
            //Other
            new SetRefTerm()
            {
                RefTermId = Guid.Parse("147b6392-722c-4375-a396-71234fad8ece"),
                RefSetId = Guid.Parse("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                SetRefTermId = Guid.Parse("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4")
            },


            //Email Address Type
             new SetRefTerm()
             {
                 RefTermId = Guid.Parse("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                 RefSetId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                 SetRefTermId = Guid.Parse("190fd253-8bfc-415a-b9e0-35cfe15c852c")
             },
             new SetRefTerm()
             {
                 RefTermId = Guid.Parse("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                 RefSetId = Guid.Parse("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                 SetRefTermId = Guid.Parse("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee")
             },


             //CountryType
             new SetRefTerm()
             //India
             {
                 RefTermId = Guid.Parse("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                 RefSetId = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                 SetRefTermId = Guid.Parse("3de4b869-5363-4796-bd29-4ffa5580816f")
             },
             //USA
             new SetRefTerm()
             {
                 RefTermId = Guid.Parse("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                 RefSetId = Guid.Parse("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                 SetRefTermId = Guid.Parse("46a34b19-95c5-41a7-a59c-e89d63f79d0e")
             }
            );



            base.OnModelCreating(modelBuilder);
        }



    }
}
