using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class udpateaddressmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefTerm",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefTerm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetRefTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    RefSetId = table.Column<Guid>(nullable: false),
                    RefTermId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetRefTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    TypeId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StateName = table.Column<string>(nullable: true),
                    Country = table.Column<Guid>(nullable: false),
                    Zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    File = table.Column<string>(type: "varchar(max)", nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Key", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of addresses", "ADDRESS_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("147b6392-722c-4375-a396-71234fad8ece"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of phonenumber", "PHONE_NUMBER_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of emails", "EMAIL_ADDRESS_TYPE", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Types of countries", "COUNTRY", null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "RefTerm",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Key", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes personal based things", "PERSONAL", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes work based things", "WORK", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes country india", "INDIA", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes country usa", "UNITED_STATES", null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "denotes other things", "OTHER", null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "RefSetId", "RefTermId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"), @"02-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18371"), new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("2094b365-b61a-477e-a52a-36c00865962d"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("2094b365-b61a-477e-a52a-36c00865962d"), null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), new Guid("147b6392-722c-4375-a396-71234fad8ece"), null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "FirstName", "LastName", "Password", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "01-12-2023 11:50", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "Ram", "Kumar", "12345werWER@", "", new Guid("00000000-0000-0000-0000-000000000000"), "Ram Kumar" },
                    { new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "Ajay", "Kumar", "12345werWER@", "", new Guid("00000000-0000-0000-0000-000000000000"), "Ajay Kumar" },
                    { new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "02-12-2023 11:50", new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "Pradeep", "Kumar", "12345werWER@", "", new Guid("00000000-0000-0000-0000-000000000000"), "Pradeep Kumar" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "CreatedBy", "Line1", "Line2", "StateName", "TypeId", "UpdatedAt", "UpdatedBy", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"), "dindigul", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "psna college", "psna nagar", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "625422" },
                    { new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"), "virudhunagar", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "01-12-2023 11:50", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "anna nagar", "aruppukottai", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "626101" },
                    { new Guid("8e3c9344-5625-4d4e-86e9-222f4a182a31"), "dindigul", new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e6"), "02-12-2023 11:50", new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "kk nagar", "dindigul", "tamilnadu", new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "921001" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EmailAddress", "TypeId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"), @"01-12-2023 11:50
                ", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "admin@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"), @"01-12-2023 11:50
                ", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "support@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") },
                    { new Guid("ee1ebeaa-f3ce-42bd-bc37-e2c86e98446d"), @"02-12-2023 11:50
                ", new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "admin2@ajay.live", new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79") }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "PhoneNumber", "TypeId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("65ec5717-5626-442a-afb5-532caedeab32"), "01-12-2023 11:50", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "7397142913", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cf56f52-1aab-4646-b090-d337aac18370") },
                    { new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"), "01-12-2023 11:50", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "8189900410", new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") },
                    { new Guid("9d8c0fd7-f857-4c0c-ac42-4d8aa63cd88c"), "02-12-2023 11:50", new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"), "2233445566", new Guid("8d25536f-8683-4740-a39c-fbedfbab8006"), "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UserId",
                table: "Assets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_UserId",
                table: "Phones",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "RefSets");

            migrationBuilder.DropTable(
                name: "RefTerm");

            migrationBuilder.DropTable(
                name: "SetRefTerms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
