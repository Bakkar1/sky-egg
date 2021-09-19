using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkyEggProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prise = table.Column<float>(type: "real", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categrie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkyEggProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Features", "PhotoPath", "Prise", "ProductName" },
                values: new object[] { 1, "Sound_Machines", "Grey", ";Timer & Volume Control", "392bbac0-796d-4c73-b0a4-5e1eb34d6b04Sound_Machines .jpg", 30.99f, "Dreamegg D11 Sound Machine" });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Features", "PhotoPath", "Prise", "ProductName" },
                values: new object[] { 2, "Humidifiers", null, "Much Powerful Performance - CADR 189m³/h + True HEPA Filter;Effective Air Filtration - Refresh the Air in a Small or Mid-Size Room(250 Sq Ft (23 m²) )in 20 Min", "56e1d082-b379-4f50-a882-56225abdddd3HEPA.jpg", 119.99f, "HEPA Air Purifier 4-in-1 for Home" });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Features", "PhotoPath", "Prise", "ProductName" },
                values: new object[] { 3, "Sound_Machines", null, "EFFECTIVELY COMBAT DRYNESS;HOUGHTFUL TIMER FUNCTION", "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg", 39.99f, "Dreamegg 2L Cool Mist Humidifier - Grey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkyEggProducts");
        }
    }
}
