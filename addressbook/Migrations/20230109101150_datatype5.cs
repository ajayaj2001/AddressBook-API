using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class datatype5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"), "" });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("7cf56f52-1aab-4646-b090-d337aac18370"), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { "09-01-2023 03:41:49 PM", new Guid("7cf56f52-1aab-4646-b090-d337aac18370") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("616b9e80-7d3f-476f-b3a6-3b2c8bbccaad"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9ef2a16e-f3c7-4892-ae22-948fc2345ff4"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("69ae7ec4-2765-46bb-a7d7-82fb69115beb"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: new Guid("e33b64fe-7f35-484e-961b-f23ba51cd742"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("59a2a070-d4c2-4cc4-b623-11340c25d883"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: new Guid("65ec5717-5626-442a-afb5-532caedeab32"),
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fad8d04-6126-47f8-bac7-409c0cee5425"),
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { "09-01-2023 03:35:39 PM", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cf56f52-1aab-4646-b090-d337aac18370"),
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { "09-01-2023 03:35:39 PM", new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
