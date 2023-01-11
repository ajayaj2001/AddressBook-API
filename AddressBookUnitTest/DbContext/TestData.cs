using AddressBook.DbContexts;
using AddressBook.Entities.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookUnitTest.DbContext
{
    public static class TestData
    {
        /// <summary>
        /// Thids method is used to add data in database
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static AddressBookContext AddData(AddressBookContext context)
        {
            context.Users.Add(new User()
            {
                Id = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                FirstName = "Ajay",
                LastName = "Kumar",
                UserName = "Ajay Kumar",
                Password = "12345werWER@",
                CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

                Addresses = new List<Address>() {
                    new Address() {
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
                    }
                },

                Emails = new List<Email>() {
                    new Email() {
                        UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                        Id = Guid.Parse("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                        EmailAddress = "admin@ajay.live",
                        TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                        CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                        CreatedAt = DateTime.Now.ToString(),
                        UpdatedAt = "",
                    }
                },

                Phones = new List<Phone>() {
                    new Phone() {
                        UserId = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                        Id = Guid.Parse("65ec5717-5626-442a-afb5-532caedeab32"),
                        PhoneNumber = "7397142913",
                        TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                        CreatedBy = Guid.Parse("7cf56f52-1aab-4646-b090-d337aac18370"),
                        CreatedAt = DateTime.Now.ToString(),
                    }
                }

            });


            context.Users.Add(new User()
            {
                Id = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                FirstName = "Ram",
                LastName = "Kumar",
                Password = "12345werWER@",
                UserName = "Ram Kumar",
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",

                Addresses = new List<Address>() {
                new Address(){
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
                },

                Emails = new List<Email>() {
                new Email(){
                   UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                Id = Guid.Parse("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                EmailAddress = "support@ajay.live",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",
                }
                },

                Phones = new List<Phone>() {
                new Phone(){
                     UserId = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                Id = Guid.Parse("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                PhoneNumber = "8189900410",
                TypeId = Guid.Parse("8d25536f-8683-4740-a39c-fbedfbab8005"),
                CreatedBy = Guid.Parse("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = "",
                }
                }

            });




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
                    context.RefSets.Add(refSet);
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
                    context.RefTerm.Add(refTerm);
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
                    context.SetRefTerms.Add(setRefTerm);
                }
            }


            FileStream dummyImg = File.OpenRead(@"F:\work\project\training\Address Book\AddressBookUnitTest\data\files\response.jpeg");
            MemoryStream ms = new MemoryStream();
            dummyImg.CopyToAsync(ms);
            byte[] byteArray = ms.ToArray();
            Asset assetdto = new Asset { Id = Guid.Parse("876072b6-04e4-4577-b21c-946e96bef643"), File = Convert.ToBase64String(byteArray) };
            context.Assets.Add(assetdto);

            context.SaveChanges();
            return context;
        }
    }
}
