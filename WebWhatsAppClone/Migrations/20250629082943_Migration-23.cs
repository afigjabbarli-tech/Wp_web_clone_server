using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "Regions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "label",
                table: "Regions",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "key",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "label",
                table: "Regions");
        }
    }
}
