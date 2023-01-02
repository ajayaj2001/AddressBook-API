using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class asset5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageFile",
                columns: table => new
                {
                    FileId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    File = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFile", x => x.FileId);
                });

            migrationBuilder.CreateTable(
                name: "RefSets",
                columns: table => new
                {
                    TypeId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSets", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "RefTerm",
                columns: table => new
                {
                    RefTermId = table.Column<Guid>(nullable: false),
                    Types = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefTerm", x => x.RefTermId);
                });

            migrationBuilder.CreateTable(
                name: "SetRefTerms",
                columns: table => new
                {
                    SetRefTermId = table.Column<Guid>(nullable: false),
                    RefSetId = table.Column<Guid>(nullable: false),
                    RefTermId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetRefTerms", x => x.SetRefTermId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    First_name = table.Column<string>(nullable: false),
                    Last_name = table.Column<string>(nullable: false),
                    User_name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetDtos",
                columns: table => new
                {
                    AssetId = table.Column<Guid>(nullable: false),
                    FieldId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDtos", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_AssetDtos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Phone_number = table.Column<string>(nullable: true),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDtos_UserId",
                table: "AssetDtos",
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
                name: "AssetDtos");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ImageFile");

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
