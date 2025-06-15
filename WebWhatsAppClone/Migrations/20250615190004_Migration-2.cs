using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "FileCategories",
                newName: "label");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "label",
                table: "FileCategories",
                newName: "name");
        }
    }
}
