using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class updateRefset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
