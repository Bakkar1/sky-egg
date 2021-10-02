using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ProductFature", "SkyEggProductId" },
                values: new object[] { 1, "Timer & Volume Control", 1 });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ProductFature", "SkyEggProductId" },
                values: new object[] { 2, "Much Powerful Performance - CADR 189m³/h", 2 });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ProductFature", "SkyEggProductId" },
                values: new object[] { 3, "Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3);
        }
    }
}
