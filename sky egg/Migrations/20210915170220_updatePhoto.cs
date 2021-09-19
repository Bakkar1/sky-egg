﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class updatePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_SkyEggProducts_SkyEggProductId",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_SkyEggProductId",
                table: "Photos",
                newName: "IX_Photos_SkyEggProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos",
                column: "SkyEggProductId",
                principalTable: "SkyEggProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_SkyEggProductId",
                table: "Photo",
                newName: "IX_Photo_SkyEggProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_SkyEggProducts_SkyEggProductId",
                table: "Photo",
                column: "SkyEggProductId",
                principalTable: "SkyEggProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
