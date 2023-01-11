﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "RefTerm");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "RefTerm",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                column: "Key",
                value: "PHONE_NUMBER_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                column: "Key",
                value: "ADDRESS_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                column: "Key",
                value: "EMAIL_ADDRESS_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                column: "Key",
                value: "COUNTRY");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "RefTerm");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "RefTerm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("147b6392-722c-4375-a396-71234fad8ece"),
                column: "Type",
                value: "PHONE_NUMBER_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("2094b365-b61a-477e-a52a-36c00865962d"),
                column: "Type",
                value: "ADDRESS_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("4e35b1db-7d50-4bc0-b10a-566d4a236b45"),
                column: "Type",
                value: "EMAIL_ADDRESS_TYPE");

            migrationBuilder.UpdateData(
                table: "RefTerm",
                keyColumn: "RefTermId",
                keyValue: new Guid("88f4dd40-59b3-4e81-a418-6af1d1660adf"),
                column: "Type",
                value: "COUNTRY");
        }
    }
}