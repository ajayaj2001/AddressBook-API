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
            string addressBookPath = @"F:\work\project\training\Address Book\addressbook\DbContext\data\AddressBook.csv";
            string[] userValues = File.ReadAllText(addressBookPath).Split('\n');

            foreach (string item in userValues)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] row = item.Split(",");
                    User user = new User()
                    {
                        Id = Guid.Parse(row[0].ToString()),
                        FirstName = row[1],
                        LastName = row[2],
                        UserName = row[3],
                        Password = row[4],
                        CreatedBy = Guid.Parse(row[5].ToString()),
                        CreatedAt = row[6],
                        UpdatedAt = "",
                    };
                    

                    Address address = new Address()
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
                    };
                   

                   Phone phone= new Phone()
                    {
                        UserId = Guid.Parse(row[19].ToString()),
                        Id = Guid.Parse(row[18].ToString()),
                        PhoneNumber = row[20],
                        TypeId = Guid.Parse(row[21].ToString()),
                        CreatedBy = Guid.Parse(row[22].ToString()),
                        CreatedAt = row[23],
                        UpdatedAt = "",
                    };

                   Email email= new Email()
                    {
                        UserId = Guid.Parse(row[25].ToString()),
                        Id = Guid.Parse(row[24].ToString()),
                        EmailAddress = row[26],
                        TypeId = Guid.Parse(row[27].ToString()),
                        CreatedBy = Guid.Parse(row[28].ToString()),
                        CreatedAt = row[29],
                        UpdatedAt = "",
                    };

                    modelBuilder.Entity<Address>().HasData(address);
                    modelBuilder.Entity<Email>().HasData(email);
                    modelBuilder.Entity<Phone>().HasData(phone);
                    modelBuilder.Entity<User>().HasData(user);

                }
            }

            modelBuilder.Entity<Asset>().Property(b => b.File).HasColumnType("varchar(max)");

            string RefSetPath = @"F:\work\project\training\Address Book\addressbook\DbContext\data\RefSet.csv";
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
                        Description = row[2],
                        CreatedBy = Guid.Parse(row[3].ToString()),
                        CreatedAt = row[4],
                        
                    };
                    modelBuilder.Entity<RefSet>().HasData(refSet);
                }

            }

            //refTerm
            string RefTermPath = @"F:\work\project\training\Address Book\addressbook\DbContext\data\RefTerm.csv";
            string[] RefTermValues = File.ReadAllText(RefTermPath).Split('\n');
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
                    modelBuilder.Entity<RefTerm>().HasData(refTerm);
                }
            }

            //setRefTerm
            string SetRefTermPath = @"F:\work\project\training\Address Book\addressbook\DbContext\data\SetRefTerm.csv";
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
                        Id = Guid.Parse(row[2].ToString()),
                        CreatedBy = Guid.Parse(row[3].ToString()),
                        CreatedAt = row[4],
                    };
                    modelBuilder.Entity<SetRefTerm>().HasData(setRefTerm);
                }
            }


            base.OnModelCreating(modelBuilder);
        }



    }
}
