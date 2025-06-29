using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "as", "Asia" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "af", "Africa" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "na", "North America" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "sa", "South America" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "an", "Antarctica" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "key", "label" },
                values: new object[] { "eu", "Europe" });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "key", "label" },
                values: new object[] { "oc", "Australia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
