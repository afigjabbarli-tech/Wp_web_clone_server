using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_File_FileFormats_file_format_id",
                table: "File");

            migrationBuilder.DropPrimaryKey(
                name: "PK_File",
                table: "File");

            migrationBuilder.RenameTable(
                name: "File",
                newName: "Files");

            migrationBuilder.RenameIndex(
                name: "IX_File_file_format_id",
                table: "Files",
                newName: "IX_Files_file_format_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_FileFormats_file_format_id",
                table: "Files",
                column: "file_format_id",
                principalTable: "FileFormats",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_FileFormats_file_format_id",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "File");

            migrationBuilder.RenameIndex(
                name: "IX_Files_file_format_id",
                table: "File",
                newName: "IX_File_file_format_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_File",
                table: "File",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_File_FileFormats_file_format_id",
                table: "File",
                column: "file_format_id",
                principalTable: "FileFormats",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
