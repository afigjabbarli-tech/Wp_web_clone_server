using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "naf", "Northern Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "waf", "Western Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "maf", "Middle Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "eaf", "Eastern Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "saf", "Southern Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "key", "label" },
                values: new object[] { "ssa", "Sub-Saharan Africa" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "cas", "Central Asia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "was", "Western Asia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "eas", "Eastern Asia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "sea", "South-Eastern Asia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "sas", "Southern Asia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "neu", "Northern Europe" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "seu", "Southern Europe" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "weu", "Western Europe" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "eeu", "Eastern Europe" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "nam", "Northern America" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "cam", "Central America" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "car", "Caribbean" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "sam", "South America" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "anz", "Australia and New Zealand" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "mel", "Melanesia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "mic", "Micronesia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "pol", "Polynesia" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "ant", "Antarctica" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000004"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000001"),
                columns: new[] { "key", "label" },
                values: new object[] { "", "" });
        }
    }
}
