using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class changeId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Users_UserId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Users_UserId",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

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
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Addresses");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Phones",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Phones",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Phones",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ImageFile",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ImageFile",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "ImageFile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "ImageFile",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "ImageFile",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Emails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Emails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "Emails",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Emails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AssetDtos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "AssetDtos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "AssetDtos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "AssetDtos",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "AssetDtos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Addresses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Addresses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DateCreated",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateDateUpdated",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Addresses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDateUpdated", "First_name", "Last_name", "Password", "UpdatedBy", "User_name" },
                values: new object[] { new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Ajay", "Kumar", "12345werWER@", new Guid("00000000-0000-0000-0000-000000000000"), "Ajay Kumar" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDateUpdated", "First_name", "Last_name", "Password", "UpdatedBy", "User_name" },
                values: new object[] { new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Ram", "Kumar", "12345werWER@", new Guid("00000000-0000-0000-0000-000000000000"), "Ram Kumar" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "DateCreated", "DateDateUpdated", "Line1", "Line2", "StateName", "TypeId", "UpdatedBy", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"), "dindigul", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "psna college", "psna nagar", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "625422" },
                    { new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"), "virudhunagar", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "anna nagar", "aruppukottai", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "626101" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDateUpdated", "EmailAddress", "TypeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "admin@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "support@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDateUpdated", "Phone_number", "TypeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("65ec5717-5626-442a-afb5-532caedeab32"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "7397142913", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "8189900410", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Users_UserId",
                table: "Emails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Users_UserId",
                table: "Phones",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Users_UserId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Users_UserId",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"));

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ImageFile");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DateDateUpdated",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Addresses");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PhoneId",
                table: "Phones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "ImageFile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmailId",
                table: "Emails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssetId",
                table: "AssetDtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFile",
                table: "ImageFile",
                column: "FileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos",
                column: "AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "First_name", "Last_name", "Password", "User_name" },
                values: new object[] { new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Ajay", "Kumar", "12345werWER@", "Ajay Kumar" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "First_name", "Last_name", "Password", "User_name" },
                values: new object[] { new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "Ram", "Kumar", "12345werWER@", "Ram Kumar" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Users_UserId",
                table: "Emails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Users_UserId",
                table: "Phones",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
