using AddressBook.DbContexts;
using AddressBook.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;

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
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string addressBookPath = Path.Combine(baseDir, @"..\..\..\DbContext\data\AddressBook.csv");
            string[] userValues = File.ReadAllText(Path.GetFullPath(addressBookPath)).Split('\n');

            foreach (string item in userValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");

                    context.Users.Add(
                    new User()
                    {
                        Id = Guid.Parse(row[0].ToString()),
                        FirstName = row[1],
                        LastName = row[2],
                        UserName = row[3],
                        Password = row[4],
                        CreatedBy = Guid.Parse(row[5].ToString()),
                        CreatedAt = row[6],
                        UpdatedAt = "",


                        Addresses = new List<Address>() {
                            new Address()
                            {
                                UserId = Guid.Parse(row[8].ToString()),
                                Id = Guid.Parse(row[7].ToString()),
                                Line1 = row[9],
                                Line2 = row[10],
                                City = row[11],
                                StateName = row[12],
                                TypeId = Guid.Parse(row[13].ToString()),
                                Country = Guid.Parse(row[14].ToString()),
                                Zipcode = row[15],
                                CreatedBy = Guid.Parse(row[16].ToString()),
                                CreatedAt = row[17],
                                UpdatedAt = "",
                            },
                        },

                        Phones = new List<Phone>() {
                            new Phone()
                            {
                                UserId = Guid.Parse(row[19].ToString()),
                                Id = Guid.Parse(row[18].ToString()),
                                PhoneNumber = row[20],
                                TypeId = Guid.Parse(row[21].ToString()),
                                CreatedBy = Guid.Parse(row[22].ToString()),
                                CreatedAt = row[23],
                                UpdatedAt = "",
                            },
                        },
                        Emails = new List<Email>() {
                            new Email()
                            {
                                UserId = Guid.Parse(row[25].ToString()),
                                Id = Guid.Parse(row[24].ToString()),
                                EmailAddress = row[26],
                                TypeId = Guid.Parse(row[27].ToString()),
                                CreatedBy = Guid.Parse(row[28].ToString()),
                                CreatedAt = row[29],
                                UpdatedAt = "",
                            },
                        }
                    }

                   );

                }
            }


            //ref term

            string RefTermPath = Path.Combine(baseDir, @"..\..\..\DbContext\data\RefSet.csv");
            string[] RefTermValues = File.ReadAllText(Path.GetFullPath(RefTermPath)).Split('\n');
            foreach (string item in RefTermValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    RefTerm refTerm = new RefTerm()
                    {
                        Id = Guid.Parse(row[0].ToString()),
                        Key = row[1],
                        Description = row[2],
                        CreatedBy = Guid.Parse(row[3].ToString()),
                        CreatedAt = row[4],

                    };
                    context.RefTerm.Add(refTerm);
                }
            }

            //refSet
            string RefSetPath = Path.Combine(baseDir, @"..\..\..\DbContext\data\RefTerm.csv");
            string[] RefSetValues = File.ReadAllText(Path.GetFullPath(RefSetPath)).Split('\n');
            foreach (string item in RefSetValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    RefSet refSet = new RefSet()
                    {
                        Id = Guid.Parse(row[0].ToString()),
                        Key = row[1],
                        Description = row[2],
                        CreatedBy = Guid.Parse(row[3].ToString()),
                        CreatedAt = row[4],
                    };
                    context.RefSets.Add(refSet);
                }
            }

            //setRefTerm
            string SetRefTermPath = Path.Combine(baseDir, @"..\..\..\DbContext\data\SetRefTerm.csv");
            string[] SetRefTermValues = File.ReadAllText(Path.GetFullPath(SetRefTermPath)).Split('\n');
            foreach (string item in SetRefTermValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    SetRefTerm setRefTerm = new SetRefTerm()
                    {
                        RefTermId = Guid.Parse(row[1].ToString()),
                        RefSetId = Guid.Parse(row[0].ToString()),
                        Id = Guid.Parse(row[2].ToString()),
                        CreatedBy = Guid.Parse(row[3].ToString()),
                        CreatedAt = row[4],
                    };
                    context.SetRefTerms.Add(setRefTerm);
                }
            }

            string imagePath = Path.Combine(baseDir, @"..\..\..\data\files\response.jpeg");
            FileStream dummyImg = File.OpenRead(Path.GetFullPath(imagePath));
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
