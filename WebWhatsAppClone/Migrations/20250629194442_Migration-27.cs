using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubRegion_Regions_region_id",
                table: "SubRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubRegion",
                table: "SubRegion");

            migrationBuilder.RenameTable(
                name: "SubRegion",
                newName: "SubRegions");

            migrationBuilder.RenameIndex(
                name: "IX_SubRegion_region_id",
                table: "SubRegions",
                newName: "IX_SubRegions_region_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubRegions",
                table: "SubRegions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubRegions_Regions_region_id",
                table: "SubRegions",
                column: "region_id",
                principalTable: "Regions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubRegions_Regions_region_id",
                table: "SubRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubRegions",
                table: "SubRegions");

            migrationBuilder.RenameTable(
                name: "SubRegions",
                newName: "SubRegion");

            migrationBuilder.RenameIndex(
                name: "IX_SubRegions_region_id",
                table: "SubRegion",
                newName: "IX_SubRegion_region_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubRegion",
                table: "SubRegion",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubRegion_Regions_region_id",
                table: "SubRegion",
                column: "region_id",
                principalTable: "Regions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
