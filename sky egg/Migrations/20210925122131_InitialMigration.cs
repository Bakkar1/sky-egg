using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class InitialMigration : Migration
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
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categrie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkyEggProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkyEggProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                    table.ForeignKey(
                        name: "FK_Features_SkyEggProducts_SkyEggProductId",
                        column: x => x.SkyEggProductId,
                        principalTable: "SkyEggProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkyEggProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                        column: x => x.SkyEggProductId,
                        principalTable: "SkyEggProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Prise", "ProductName" },
                values: new object[] { 1, "Sound_Machines", "Grey", 30.99f, "Dreamegg D3 Sound Machine" });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Prise", "ProductName" },
                values: new object[] { 2, "Air_Purifiers", null, 119.99f, "HEPA Air Purifier 4-in-1 for Home" });

            migrationBuilder.InsertData(
                table: "SkyEggProducts",
                columns: new[] { "Id", "Categrie", "Colors", "Prise", "ProductName" },
                values: new object[] { 3, "Humidifiers", null, 39.99f, "Dreamegg 2L Cool Mist Humidifier - Grey" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "PhotoPath", "SkyEggProductId" },
                values: new object[,]
                {
                    { 1, "d8789136-410e-4115-95b9-4fbabc0a35fdD1 Sound Machine3.jpg", 1 },
                    { 2, "d7ac2bd4-8645-4291-be0b-ec91afaab4c1D1 Sound Machine2.jpg", 1 },
                    { 3, "d3fd7c36-7186-4a40-b045-b55eb71b076bD1 Sound Machine.jpg", 1 },
                    { 4, "dc36cfbe-9fbf-455a-a4e5-7187809bdc00hepa6.png", 2 },
                    { 5, "dfe9c871-a6fd-41d8-88cd-9b2c61aa0d50hepa5.jpg", 2 },
                    { 6, "754fe19f-d3a4-4686-8665-c6f8c64b288ehepa4.jpg", 2 },
                    { 7, "02826809-730c-4080-a3d3-53e9dcebbb12hepa3.png", 2 },
                    { 8, "c13cdd4d-b4eb-4178-853c-3f6483d7208eDreamegg 2L.jpg", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Features_SkyEggProductId",
                table: "Features",
                column: "SkyEggProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SkyEggProductId",
                table: "Photos",
                column: "SkyEggProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "SkyEggProducts");
        }
    }
}
