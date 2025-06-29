using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "Continents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "label",
                table: "Continents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "key",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "label",
                table: "Continents");
        }
    }
}
