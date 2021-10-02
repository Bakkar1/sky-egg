using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class corectDMLmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ProductFature", "SkyEggProductId" },
                values: new object[] { 4, "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4);
        }
    }
}
