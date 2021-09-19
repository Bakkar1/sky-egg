using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class modifyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Categrie",
                value: "Air_Purifiers");

            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Categrie",
                value: "Humidifiers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Categrie",
                value: "Humidifiers");

            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Categrie",
                value: "Air_Purifiers");
        }
    }
}
