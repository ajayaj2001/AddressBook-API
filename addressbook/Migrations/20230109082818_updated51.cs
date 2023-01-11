using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class updated51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "Description",
                value: @"denotes country usa
");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "Description",
                value: @"denotes personal based things
");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "Description",
                value: @"denotes country india
");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "Description",
                value: @"denotes other things
");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "Description",
                value: @"denotes work based things
");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                column: "Description",
                value: @"Types of phonenumber
");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                column: "Description",
                value: @"Types of addresses
");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                column: "Description",
                value: @"Types of emails
");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                column: "Description",
                value: @"Types of countries
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"),
                column: "Description",
                value: "denotes country usa");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"),
                column: "Description",
                value: "denotes personal based things");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"),
                column: "Description",
                value: "denotes country india");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"),
                column: "Description",
                value: "denotes other things");

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"),
                column: "Description",
                value: "denotes work based things");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                column: "Description",
                value: "Types of phonenumber");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                column: "Description",
                value: "Types of addresses");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                column: "Description",
                value: "Types of emails");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                column: "Description",
                value: "Types of countries");
        }
    }
}
