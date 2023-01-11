using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class updateRefset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "RefSets");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "RefSets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Assets",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "Key",
                value: "UNITED_STATES");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "Key",
                value: "PERSONAL");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "Key",
                value: "INDIA");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "Key",
                value: "OTHER");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "Key",
                value: "WORK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                column: "CreatedAt",
                value: "11-01-2023 12:35:38 PM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "RefSets");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RefSets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Assets",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "Name",
                value: "UNITED_STATES");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "Name",
                value: "PERSONAL");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "Name",
                value: "INDIA");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "Name",
                value: "OTHER");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "Name",
                value: "WORK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                column: "CreatedAt",
                value: "09-01-2023 06:43:39 PM");
        }
    }
}
