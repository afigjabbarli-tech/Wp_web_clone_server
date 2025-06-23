using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_updated",
                table: "FileFormats",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_updated",
                table: "FileCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("04127520-7ef4-4cf1-8829-d70b7c3c0138"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("057c8055-1895-49e6-9b80-ebe78f6aabef"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("12ee019d-6102-4828-b0c3-00ef53941595"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("19dfb162-78e9-4b4f-9b45-2d4308ed746f"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("29eeddb3-b709-4d71-bbff-21091c52bb26"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("36d5657d-801d-49ce-9f4b-ed7ea6192582"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("52ed76e7-1614-47be-93f7-0f4df56c9a8a"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("62a3d8ae-81fa-4c8e-b2f6-41a2f90a7490"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000006"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000007"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("71d8ea38-900a-4ebc-9d13-31caf17544f1"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8afb9733-28a8-483e-938c-221186ad11b0"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("a10c24ce-4b9d-4007-8b92-51f8c8a615eb"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("b05f39ac-c66e-470d-bba5-850c1b10d55f"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("bd7dde61-9f92-42d9-9e9e-146a773234e9"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("c05c21be-3e27-4326-92c2-f1160c8a1501"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("c93fe653-33d0-45d8-9611-2d82eb6bd087"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d4a51598-b08b-496d-b3d1-38b35e7d8316"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dbb4d630-4a41-4900-844c-d99483ac7237"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("e8b33ff5-bdb7-4bc4-8ad8-347a71200714"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("ebe9df37-84a6-42e4-b5bf-c097dba1c2d1"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd37bba4-68d3-42f6-9bdf-c248c3d3972e"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000001"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000002"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000003"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000004"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000005"),
                column: "is_updated",
                value: false);

            migrationBuilder.UpdateData(
                table: "FileFormats",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000006"),
                column: "is_updated",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_updated",
                table: "FileFormats");

            migrationBuilder.DropColumn(
                name: "is_updated",
                table: "FileCategories");
        }
    }
}
