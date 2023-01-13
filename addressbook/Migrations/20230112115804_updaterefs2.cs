using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class updaterefs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SetRefTerms",
                table: "SetRefTerms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefTerm",
                table: "RefTerm");

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

            migrationBuilder.DropColumn(
                name: "SetRefTermId",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "RefTermId",
                table: "RefTerm");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "SetRefTerms",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "SetRefTerms",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SetRefTerms",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "SetRefTerms",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "SetRefTerms",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "RefTerm",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "RefTerm",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "RefTerm",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "RefTerm",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "RefTerm",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "RefSets",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "RefSets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "RefSets",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "RefSets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SetRefTerms",
                table: "SetRefTerms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefTerm",
                table: "RefTerm",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                columns: new[] { "CreatedAt", "CreatedBy", "Description" },
                values: new object[] { @"01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes country usa" });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                columns: new[] { "CreatedAt", "CreatedBy", "Description" },
                values: new object[] { @"01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes personal based things" });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                columns: new[] { "CreatedAt", "CreatedBy", "Description" },
                values: new object[] { @"01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes country india" });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                columns: new[] { "CreatedAt", "CreatedBy", "Description" },
                values: new object[] { @"01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes other things" });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                columns: new[] { "CreatedAt", "CreatedBy", "Description" },
                values: new object[] { @"01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes work based things" });

            migrationBuilder.InsertData(
                table: "RefTerm",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Key", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of addresses", "ADDRESS_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of countries", "COUNTRY", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of emails", "EMAIL_ADDRESS_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("147b6392-722c-4375-a396-71234fad8ece"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of phonenumber", "PHONE_NUMBER_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "RefSetId", "RefTermId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("2094b365-b61a-477e-a52a-36c00865962d"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("2094b365-b61a-477e-a52a-36c00865962d"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"), @"02-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18371"), new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                column: "CreatedAt",
                value: "12-01-2023 05:28:04 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SetRefTerms",
                table: "SetRefTerms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefTerm",
                table: "RefTerm");

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"));

            migrationBuilder.DeleteData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RefSets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RefSets");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RefSets");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RefSets");

            migrationBuilder.AddColumn<Guid>(
                name: "SetRefTermId",
                table: "SetRefTerms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RefTermId",
                table: "RefTerm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SetRefTerms",
                table: "SetRefTerms",
                column: "SetRefTermId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefTerm",
                table: "RefTerm",
                column: "RefTermId");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "Description",
                value: @"denotes country usa");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "Description",
                value: @"denotes personal based things");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "Description",
                value: @"denotes country india");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "Description",
                value: @"denotes other things");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "Description",
                value: @"denotes work based things");

            migrationBuilder.InsertData(
                table: "RefTerm",
                columns: new[] { "RefTermId", "Description", "Key" },
                values: new object[,]
                {
                    { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), @"Types of addresses
                ", "ADDRESS_TYPE" },
                    { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), @"Types of countries
                ", "COUNTRY" },
                    { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), @"Types of emails
                ", "EMAIL_ADDRESS_TYPE" },
                    { new Guid("147b6392-722c-4375-a396-71234fad8ece"), @"Types of phonenumber
                ", "PHONE_NUMBER_TYPE" }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "SetRefTermId", "RefSetId", "RefTermId" },
                values: new object[,]
                {
                    { new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") },
                    { new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") },
                    { new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"), new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), new Guid("147b6392-722c-4375-a396-71234fad8ece") },
                    { new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("147b6392-722c-4375-a396-71234fad8ece") },
                    { new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("147b6392-722c-4375-a396-71234fad8ece") },
                    { new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") },
                    { new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") },
                    { new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"), new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") },
                    { new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"), new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                column: "CreatedAt",
                value: "11-01-2023 04:32:35 PM");
        }
    }
}
