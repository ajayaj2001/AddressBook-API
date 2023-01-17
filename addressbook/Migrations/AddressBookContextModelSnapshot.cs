﻿// <auto-generated />
using System;
using AddressBook.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddressBook.Migrations
{
    [DbContext(typeof(AddressBookContext))]
    partial class AddressBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = "01-12-2023 11:50",
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
                            CreatedAt = "01-12-2023 11:50",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            Line1 = "anna nagar",
                            Line2 = "aruppukottai",
                            StateName = "tamilnadu",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            Zipcode = "626101"
                        },
                        new
                        {
                            Id = new Guid("8e3c9344-5625-4d4e-86e9-222f4a182a31"),
                            City = "dindigul",
                            Country = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e6"),
                            CreatedAt = "02-12-2023 11:50",
                            CreatedBy = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            Line1 = "kk nagar",
                            Line2 = "dindigul",
                            StateName = "tamilnadu",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            Zipcode = "921001"
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
                            CreatedAt = @"01-12-2023 11:50",
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
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            EmailAddress = "support@ajay.live",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425")
                        },
                        new
                        {
                            Id = new Guid("ee1ebeaa-f3ce-42bd-bc37-e2c86e98446d"),
                            CreatedAt = @"02-12-2023 11:50",
                            CreatedBy = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            EmailAddress = "admin2@ajay.live",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.Phone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
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
                            CreatedAt = "01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            PhoneNumber = "7397142913",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("7cf56f52-1aab-4646-b090-d337aac18370")
                        },
                        new
                        {
                            Id = new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                            CreatedAt = "01-12-2023 11:50",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            PhoneNumber = "8189900410",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425")
                        },
                        new
                        {
                            Id = new Guid("9d8c0fd7-f857-4c0c-ac42-4d8aa63cd88c"),
                            CreatedAt = "02-12-2023 11:50",
                            CreatedBy = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            PhoneNumber = "2233445566",
                            TypeId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"),
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.RefSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RefSets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "Types of addresses",
                            Key = "ADDRESS_TYPE",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "Types of phonenumber",
                            Key = "PHONE_NUMBER_TYPE",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "Types of emails",
                            Key = "EMAIL_ADDRESS_TYPE",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "Types of countries",
                            Key = "COUNTRY",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.RefTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RefTerm");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "denotes personal based things",
                            Key = "PERSONAL",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "denotes work based things",
                            Key = "WORK",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "denotes country india",
                            Key = "INDIA",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "denotes country usa",
                            Key = "UNITED_STATES",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            Description = "denotes other things",
                            Key = "OTHER",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("AddressBook.Entities.Models.SetRefTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefTermId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SetRefTerms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                            RefTermId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                            RefTermId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                            RefTermId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                            RefTermId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                            RefTermId = new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                            RefTermId = new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                            RefTermId = new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"),
                            CreatedAt = @"01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            RefSetId = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                            RefTermId = new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"),
                            CreatedAt = @"02-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18371"),
                            RefSetId = new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                            RefTermId = new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            CreatedAt = "01-12-2023 11:50",
                            CreatedBy = new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                            FirstName = "Ajay",
                            LastName = "Kumar",
                            Password = "12345werWER@",
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "Ajay Kumar"
                        },
                        new
                        {
                            Id = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            CreatedAt = "01-12-2023 11:50",
                            CreatedBy = new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                            FirstName = "Ram",
                            LastName = "Kumar",
                            Password = "12345werWER@",
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "Ram Kumar"
                        },
                        new
                        {
                            Id = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            CreatedAt = "02-12-2023 11:50",
                            CreatedBy = new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                            FirstName = "Pradeep",
                            LastName = "Kumar",
                            Password = "12345werWER@",
                            UpdatedAt = "",
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserName = "Pradeep Kumar"
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

            modelBuilder.Entity("AddressBook.Entities.Models.Phone", b =>
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
