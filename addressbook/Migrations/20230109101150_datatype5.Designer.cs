﻿// <auto-generated />
using System;
using AddressBook.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddressBook.Migrations
{
    [DbContext(typeof(AddressBookContext))]
    [Migration("20230109101150_datatype5")]
    partial class datatype5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressBook.Entities.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Country")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                            City = "dindigul",
                            Country = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Line1 = "psna college",
                            Line2 = "psna nagar",
                            StateName = "tamilnadu",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Zipcode = "625422"
                        },
                        new
                        {
                            Id = new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                            City = "virudhunagar",
                            Country = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            Line1 = "anna nagar",
                            Line2 = "aruppukottai",
                            StateName = "tamilnadu",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            Zipcode = "626101"
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            EmailAddress = "admin@ajay.live",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("7cf56f52-1aab-4646-b090-d337aac18370")
                        },
                        new
                        {
                            Id = new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            EmailAddress = "support@ajay.live",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.PhoneNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            Id = new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Phone_number = "7397142913",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("7cf56f52-1aab-4646-b090-d337aac18370")
                        },
                        new
                        {
                            Id = new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            Phone_number = "8189900410",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.RefSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RefSets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            Description = @"denotes personal based things",
                            Name = "PERSONAL"
                        },
                        new
                        {
                            Id = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            Description = @"denotes work based things",
                            Name = "WORK"
                        },
                        new
                        {
                            Id = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            Description = @"denotes country india",
                            Name = "INDIA"
                        },
                        new
                        {
                            Id = new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                            Description = @"denotes country usa",
                            Name = "UNITED_STATES"
                        },
                        new
                        {
                            Id = new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                            Description = @"denotes other things",
                            Name = "OTHER"
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.RefTerm", b =>
                {
                    b.Property<Guid>("RefTermId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RefTermId");

                    b.ToTable("RefTerm");

                    b.HasData(
                        new
                        {
                            RefTermId = new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                            Description = @"Types of addresses",
                            Key = "ADDRESS_TYPE"
                        },
                        new
                        {
                            RefTermId = new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                            Description = @"Types of phonenumber",
                            Key = "PHONE_NUMBER_TYPE"
                        },
                        new
                        {
                            RefTermId = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                            Description = @"Types of emails",
                            Key = "EMAIL_ADDRESS_TYPE"
                        },
                        new
                        {
                            RefTermId = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                            Description = @"Types of countries",
                            Key = "COUNTRY"
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.SetRefTerm", b =>
                {
                    b.Property<Guid>("SetRefTermId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefTermId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SetRefTermId");

                    b.ToTable("SetRefTerms");

                    b.HasData(
                        new
                        {
                            SetRefTermId = new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"),
                            RefSetId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            RefTermId = new Guid("2094b365-b61a-477e-a52a-36c00865962d")
                        },
                        new
                        {
                            SetRefTermId = new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"),
                            RefSetId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            RefTermId = new Guid("2094b365-b61a-477e-a52a-36c00865962d")
                        },
                        new
                        {
                            SetRefTermId = new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"),
                            RefSetId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            RefTermId = new Guid("147b6392-722c-4375-a396-71234fad8ece")
                        },
                        new
                        {
                            SetRefTermId = new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"),
                            RefSetId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            RefTermId = new Guid("147b6392-722c-4375-a396-71234fad8ece")
                        },
                        new
                        {
                            SetRefTermId = new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"),
                            RefSetId = new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                            RefTermId = new Guid("147b6392-722c-4375-a396-71234fad8ece")
                        },
                        new
                        {
                            SetRefTermId = new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"),
                            RefSetId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            RefTermId = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45")
                        },
                        new
                        {
                            SetRefTermId = new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"),
                            RefSetId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            RefTermId = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45")
                        },
                        new
                        {
                            SetRefTermId = new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"),
                            RefSetId = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            RefTermId = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf")
                        },
                        new
                        {
                            SetRefTermId = new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"),
                            RefSetId = new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                            RefTermId = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            First_name = "Ajay",
                            Last_name = "Kumar",
                            Password = "12345werWER@",
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            User_name = "Ajay Kumar"
                        },
                        new
                        {
                            Id = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            CreatedAt = "09-01-2023 03:41:49 PM",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            First_name = "Ram",
                            Last_name = "Kumar",
                            Password = "12345werWER@",
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            User_name = "Ram Kumar"
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Address", b =>
                {
                    b.HasOne("AddressBook.Entities.Models.User", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Asset", b =>
                {
                    b.HasOne("AddressBook.Entities.Models.User", null)
                        .WithMany("Assets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Email", b =>
                {
                    b.HasOne("AddressBook.Entities.Models.User", null)
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AddressBook.Entities.Models.PhoneNumber", b =>
                {
                    b.HasOne("AddressBook.Entities.Models.User", null)
                        .WithMany("Phones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
