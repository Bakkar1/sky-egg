using Microsoft.EntityFrameworkCore.Migrations;

namespace sky_egg.Migrations
{
    public partial class updatfoerigkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "SkyEggProductId",
                table: "Photos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos",
                column: "SkyEggProductId",
                principalTable: "SkyEggProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos");

            migrationBuilder.AlterColumn<int>(
                name: "SkyEggProductId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_SkyEggProducts_SkyEggProductId",
                table: "Photos",
                column: "SkyEggProductId",
                principalTable: "SkyEggProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
