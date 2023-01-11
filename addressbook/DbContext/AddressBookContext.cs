using Microsoft.EntityFrameworkCore;
using System;
using AddressBook.Entities.Models;
using System.IO;

namespace AddressBook.DbContexts
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RefSet> RefSets { get; set; }
        public DbSet<RefTerm> RefTerm { get; set; }
        public DbSet<SetRefTerm> SetRefTerms { get; set; }
        public DbSet<Asset> Assets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user data
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                FirstName = "Ajay",
                LastName = "Kumar",
                UserName = "Ajay Kumar",
                Password = "12345werWER@",
                CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",
            },
            new User()
            {
                Id = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                FirstName = "Ram",
                LastName = "Kumar",
                Password = "12345werWER@",
                UserName = "Ram Kumar",
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",
            }

            );

            //address data
            modelBuilder.Entity<Address>().HasData(
                new Address()
                {
                    UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                    Id = Guid.Parse("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                    Line1 = "psna college",
                    Line2 = "psna nagar",
                    City = "dindigul",
                    StateName = "tamilnadu",
                    TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                    Country = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                    Zipcode = "625422",
                    CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                    CreatedAt = DateTime.Now.ToString(),
                    UpdatedAt = "",
                },
            new Address()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                Id = Guid.Parse("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                Line1 = "anna nagar",
                Line2 = "aruppukottai",
                City = "virudhunagar",
                StateName = "tamilnadu",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                Country = Guid.Parse("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                Zipcode = "626101",
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

            }
            );

            //ph number data
            modelBuilder.Entity<Phone>().HasData(new Phone()
            {
                UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                Id = Guid.Parse("65ec5717-5626-442a-afb5-532caedeab32"),
                PhoneNumber = "7397142913",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",
            },
            new Phone()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                Id = Guid.Parse("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                PhoneNumber = "8189900410",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

            }
            );

            //email data
            modelBuilder.Entity<Email>().HasData(new Email()
            {
                UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                Id = Guid.Parse("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                EmailAddress = "admin@ajay.live",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

            },
            new Email()
            {
                UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                Id = Guid.Parse("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                EmailAddress = "support@ajay.live",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

            });

            modelBuilder.Entity<Asset>().Property(b => b.File).HasColumnType("varchar(max)");

            string RefSetPath = @"F:\work\project\training\Address Book\addressbook\DbContext\MetaData\RefSet.csv";
            string[] RefSetValues = File.ReadAllText(RefSetPath).Split('\n');
            foreach (string item in RefSetValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    RefSet refSet = new RefSet()
                    {
                        Id = Guid.Parse(row[0].ToString()),
                        Key = row[1],
                        Description = row[2]
                    };
                    modelBuilder.Entity<RefSet>().HasData(refSet);
                }

            }

            //refTerm
            string RefTermPath = @"F:\work\project\training\Address Book\addressbook\DbContext\MetaData\RefTerm.csv";
            string[] RefTermValues = File.ReadAllText(RefTermPath).Split('\n');
            foreach (string item in RefTermValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    RefTerm refTerm = new RefTerm()
                    {
                        RefTermId = Guid.Parse(row[0].ToString()),
                        Key = row[1],
                        Description = row[2]
                    };
                    modelBuilder.Entity<RefTerm>().HasData(refTerm);
                }
            }

            //setRefTerm
            string SetRefTermPath = @"F:\work\project\training\Address Book\addressbook\DbContext\MetaData\SetRefTerm.csv";
            string[] SetRefTermValues = File.ReadAllText(SetRefTermPath).Split('\n');
            foreach (string item in SetRefTermValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    SetRefTerm setRefTerm = new SetRefTerm()
                    {
                        RefTermId = Guid.Parse(row[0].ToString()),
                        RefSetId = Guid.Parse(row[1].ToString()),
                        SetRefTermId = Guid.Parse(row[2].ToString()),
                    };
                    modelBuilder.Entity<SetRefTerm>().HasData(setRefTerm);
                }
            }


            base.OnModelCreating(modelBuilder);
        }



    }
}
