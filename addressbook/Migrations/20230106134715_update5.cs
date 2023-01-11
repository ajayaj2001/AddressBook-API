using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos");

            migrationBuilder.DropTable(
                name: "ImageFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "AssetDtos");

            migrationBuilder.RenameTable(
                name: "AssetDtos",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_AssetDtos_UserId",
                table: "Assets",
                newName: "IX_Assets_UserId");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Assets",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Users_UserId",
                table: "Assets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Users_UserId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Assets");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "AssetDtos");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_UserId",
                table: "AssetDtos",
                newName: "IX_AssetDtos_UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "FieldId",
                table: "AssetDtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetDtos",
                table: "AssetDtos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ImageFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDateUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "varchar(max)", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFile", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDtos_Users_UserId",
                table: "AssetDtos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
