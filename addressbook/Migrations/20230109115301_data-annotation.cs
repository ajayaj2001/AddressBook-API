using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class dataannotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "First_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Last_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "User_name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone_number",
                table: "Phones");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Phones",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "09-01-2023 05:23:00 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "09-01-2023 05:23:00 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "09-01-2023 05:23:00 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "09-01-2023 05:23:00 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { "09-01-2023 05:23:00 PM", "8189900410" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                columns: new[] { "CreatedAt", "PhoneNumber" },
                values: new object[] { "09-01-2023 05:23:00 PM", "7397142913" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                columns: new[] { "CreatedAt", "FirstName", "LastName", "UserName" },
                values: new object[] { "09-01-2023 05:23:00 PM", "Ram", "Kumar", "Ram Kumar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                columns: new[] { "CreatedAt", "FirstName", "LastName", "UserName" },
                values: new object[] { "09-01-2023 05:23:00 PM", "Ajay", "Kumar", "Ajay Kumar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Phones");

            migrationBuilder.AddColumn<string>(
                name: "First_name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Last_name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User_name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone_number",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                column: "CreatedAt",
                value: "09-01-2023 03:41:49 PM");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                column: "CreatedAt",
                value: "09-01-2023 03:41:49 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                column: "CreatedAt",
                value: "09-01-2023 03:41:49 PM");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                column: "CreatedAt",
                value: "09-01-2023 03:41:49 PM");

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                columns: new[] { "CreatedAt", "Phone_number" },
                values: new object[] { "09-01-2023 03:41:49 PM", "8189900410" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                columns: new[] { "CreatedAt", "Phone_number" },
                values: new object[] { "09-01-2023 03:41:49 PM", "7397142913" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                columns: new[] { "CreatedAt", "First_name", "Last_name", "User_name" },
                values: new object[] { "09-01-2023 03:41:49 PM", "Ram", "Kumar", "Ram Kumar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                columns: new[] { "CreatedAt", "First_name", "Last_name", "User_name" },
                values: new object[] { "09-01-2023 03:41:49 PM", "Ajay", "Kumar", "Ajay Kumar" });
        }
    }
}
