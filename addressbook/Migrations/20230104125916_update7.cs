using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class update7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RefSets",
                table: "RefSets");

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "TypeId",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"));

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "RefSets");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "RefSets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefSets",
                table: "RefSets",
                column: "Id");

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "denotes personal based things", "PERSONAL" },
                    { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), "denotes work based things", "WORK" },
                    { new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "denotes country india", "INDIA" },
                    { new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), "denotes country usa", "UNITED_STATES" },
                    { new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), "denotes other things", "OTHER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RefSets",
                table: "RefSets");

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"));

            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RefSets");

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "RefSets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefSets",
                table: "RefSets",
                column: "TypeId");

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "TypeId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), "denotes personal based things", "PERSONAL" },
                    { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), "denotes work based things", "WORK" },
                    { new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), "denotes country india", "INDIA" },
                    { new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), "denotes country usa", "UNITED_STATES" },
                    { new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), "denotes other things", "OTHER" }
                });
        }
    }
}
