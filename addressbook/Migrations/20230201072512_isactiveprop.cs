using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class isactiveprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SetRefTerms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RefTerm",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RefSets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Phones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Emails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Assets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Addresses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8e3c9344-5625-4d4e-86e9-222f4a182a31"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("ee1ebeaa-f3ce-42bd-bc37-e2c86e98446d"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("9d8c0fd7-f857-4c0c-ac42-4d8aa63cd88c"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cebb335a-6786-4fc5-b980-bc3245ed0a79"),
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SetRefTerms");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RefTerm");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RefSets");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Addresses");
        }
    }
}
