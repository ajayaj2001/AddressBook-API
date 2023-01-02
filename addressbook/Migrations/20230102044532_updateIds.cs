using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class updateIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("859a0577-76ad-49ef-a111-346e4f978a88"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: new Guid("00793011-a986-49f0-879b-86023edaff46"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("a447a151-130e-46df-917b-d09976d2ebb5"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("173487fc-5809-4d64-8a2c-a23403127e30"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("5d14d241-437e-4819-ab01-58563d95c73c"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("68417748-6864-4866-8d9b-b82ae29da396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"));

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "TypeId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "denotes personal based things", "PERSONAL" },
                    { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), "denotes work based things", "WORK" },
                    { new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "denotes country india", "INDIA" },
                    { new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), "denotes country usa", "UNITED_STATES" },
                    { new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), "denotes other things", "OTHER" }
                });

            migrationBuilder.InsertData(
                table: "RefTerm",
                columns: new[] { "RefTermId", "Description", "Types" },
                values: new object[,]
                {
                    { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), "Types of addresses", "ADDRESS_TYPE" },
                    { new Guid("147b6392-722c-4375-a396-71234fad8ece"), "Types of phonenumber", "PHONE_NUMBER_TYPE" },
                    { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), "Types of emails", "EMAIL_ADDRESS_TYPE" },
                    { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), "Types of countries", "COUNTRY" }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "SetRefTermId", "RefSetId", "RefTermId" },
                values: new object[,]
                {
                    { new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"), new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") },
                    { new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"), new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") },
                    { new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") },
                    { new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") },
                    { new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") },
                    { new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("147b6392-722c-4375-a396-71234fad8ece") },
                    { new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("147b6392-722c-4375-a396-71234fad8ece") },
                    { new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") },
                    { new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"), new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), new Guid("147b6392-722c-4375-a396-71234fad8ece") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "First_name", "Last_name", "Password", "User_name" },
                values: new object[,]
                {
                    { new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Ajay", "Kumar", "12345werWER@", "Ajay Kumar" },
                    { new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "Ram", "Kumar", "12345werWER@", "Ram Kumar" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Line1", "Line2", "StateName", "TypeId", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"), "dindigul", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "psna college", "psna nagar", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "625422" },
                    { new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"), "virudhunagar", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "anna nagar", "aruppukottai", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "626101" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"), "admin@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"), "support@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Phone_number", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("65ec5717-5626-442a-afb5-532caedeab32"), "7397142913", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"), "8189900410", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "SetRefTermId",
                keyValue: new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"));

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "TypeId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), "It is used to the detail mentioned all about personal", "PERSONAL" },
                    { new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), "The detail mentioned is all about Work based", "WORK" },
                    { new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), "Country", "INDIA" },
                    { new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"), "Country", "UNITED_STATES" },
                    { new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"), "Alternate number", "ALTERNATE" }
                });

            migrationBuilder.InsertData(
                table: "RefTerm",
                columns: new[] { "RefTermId", "Description", "Types" },
                values: new object[,]
                {
                    { new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df"), "Types of addresses", "ADDRESS_TYPE" },
                    { new Guid("a447a151-130e-46df-917b-d09976d2ebb5"), "Types of phonenumber", "PHONE_NUMBER_TYPE" },
                    { new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687"), "Types of emails", "EMAIL_ADDRESS_TYPE" },
                    { new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1"), "Types of countries", "COUNTRY" }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "SetRefTermId", "RefSetId", "RefTermId" },
                values: new object[,]
                {
                    { new Guid("d1f520f4-976d-4ec7-a523-24985873a91b"), new Guid("e7c0cab2-367b-4b60-805f-8b20cdadc599"), new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1") },
                    { new Guid("5d14d241-437e-4819-ab01-58563d95c73c"), new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), new Guid("a673bec7-aae1-4cca-b459-fb5d5bbfe3e1") },
                    { new Guid("173487fc-5809-4d64-8a2c-a23403127e30"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687") },
                    { new Guid("2aa77699-21f7-442a-8b0d-b6e3f6b9211d"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("66ce5b88-684d-4a82-96b6-d9c8bb751687") },
                    { new Guid("d2ffc955-b24b-411a-8cdb-26516bcfe3db"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df") },
                    { new Guid("a1c2cd8c-aae4-463d-b873-841c40f4bf86"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("a447a151-130e-46df-917b-d09976d2ebb5") },
                    { new Guid("0bd3c11f-c1c5-48f5-8ece-86cfeb5ede88"), new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("a447a151-130e-46df-917b-d09976d2ebb5") },
                    { new Guid("7e9c9d23-7728-4808-975d-d07b42d8e039"), new Guid("0d80e411-064c-4025-abd3-b10373c5b0c7"), new Guid("3bbd0a04-40d0-44fb-ba4d-c25d0926d7df") },
                    { new Guid("a0229113-f803-4403-ba10-b0698d0cbbbe"), new Guid("7b135772-658f-4bdf-a01c-cedba350cb41"), new Guid("a447a151-130e-46df-917b-d09976d2ebb5") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "First_name", "Last_name", "Password", "User_name" },
                values: new object[,]
                {
                    { new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), "Ajay", "Kumar", "12345werWER@", "Ajay Kumar" },
                    { new Guid("68417748-6864-4866-8d9b-b82ae29da396"), "Ram", "Kumar", "12345werWER@", "Ram Kumar" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Line1", "Line2", "StateName", "TypeId", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("859a0577-76ad-49ef-a111-346e4f978a88"), "dindigul", new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), "psna college", "psna nagar", "tamilnadu", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), "625422" },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), "virudhunagar", new Guid("1f1f245d-c63b-42f6-b592-49b5b16bf861"), "anna nagar", "aruppukottai", "tamilnadu", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), "626101" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d019119e-245b-45d2-93df-b4cbbdfeac9f"), "admin@ajay.live", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), "support@ajay.live", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Phone_number", "TypeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00793011-a986-49f0-879b-86023edaff46"), "7397142913", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be") },
                    { new Guid("8c50f920-4b3a-4565-a8b6-0b635b429a98"), "8189900410", new Guid("abad70c5-11db-42f8-9e3a-487023f1b1cc"), new Guid("68417748-6864-4866-8d9b-b82ae29da396") }
                });
        }
    }
}
