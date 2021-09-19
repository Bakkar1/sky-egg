using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class corectData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Categrie",
                value: "Air_Purifiers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SkyEggProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Categrie",
                value: "Sound_Machines");
        }
    }
}
