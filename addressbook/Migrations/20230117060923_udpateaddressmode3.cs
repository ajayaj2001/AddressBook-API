using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class udpateaddressmode3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"), new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("147b6392-722c-4375-a396-71234fad8ece"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("2094b365-b61a-477e-a52a-36c00865962d"), new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("147b6392-722c-4375-a396-71234fad8ece"), new Guid("8d25536f-8683-4740-a39c-fbedfbab8005") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("147b6392-722c-4375-a396-71234fad8ece"), new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("190fd253-8bfc-415a-b9e0-35cfe15c852c"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("3de4b869-5363-4796-bd29-4ffa5580816f"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("94626cde-4f4c-43ec-b5ef-83a148ffb5e5"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("46a34b19-95c5-41a7-a59c-e89d63f79d0e"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("7588d112-fbc7-4fe3-af98-42147579ff0a"), new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("60802b12-c78d-4c85-980f-8098a0ff23d7"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("6d1f9b3a-c4d1-4c6d-a501-07d84600b8ee"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("9d118fca-ac40-4b05-b3be-0c3300baa8e0"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("147b6392-722c-4375-a396-71234fad8ece") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e5d19692-9936-47b3-ad37-4ef28ac69824"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("d4ef3377-de40-4425-ae06-2faf88d57b15"), new Guid("2094b365-b61a-477e-a52a-36c00865962d") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f06a2c4b-e618-4eaa-83bf-368870350a65"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("8d25536f-8683-4740-a39c-fbedfbab8005"), new Guid("147b6392-722c-4375-a396-71234fad8ece") });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f1142c16-9d91-4a7b-ad40-bd0af4ea27b4"),
                columns: new[] { "RefSetId", "RefTermId" },
                values: new object[] { new Guid("ae0b5647-b5c9-460f-a8b6-e90f11420d31"), new Guid("147b6392-722c-4375-a396-71234fad8ece") });
        }
    }
}
