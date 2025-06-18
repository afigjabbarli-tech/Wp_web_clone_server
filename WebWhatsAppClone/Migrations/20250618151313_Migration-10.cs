using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileFormat_FileCategories_file_category_id",
                table: "FileFormat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileFormat",
                table: "FileFormat");

            migrationBuilder.RenameTable(
                name: "FileFormat",
                newName: "FileFormats");

            migrationBuilder.RenameIndex(
                name: "IX_FileFormat_file_category_id",
                table: "FileFormats",
                newName: "IX_FileFormats_file_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileFormats",
                table: "FileFormats",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FileFormats_FileCategories_file_category_id",
                table: "FileFormats",
                column: "file_category_id",
                principalTable: "FileCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileFormats_FileCategories_file_category_id",
                table: "FileFormats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileFormats",
                table: "FileFormats");

            migrationBuilder.RenameTable(
                name: "FileFormats",
                newName: "FileFormat");

            migrationBuilder.RenameIndex(
                name: "IX_FileFormats_file_category_id",
                table: "FileFormat",
                newName: "IX_FileFormat_file_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileFormat",
                table: "FileFormat",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FileFormat_FileCategories_file_category_id",
                table: "FileFormat",
                column: "file_category_id",
                principalTable: "FileCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
