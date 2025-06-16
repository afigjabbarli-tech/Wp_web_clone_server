using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileFormat",
                columns: new[] { "id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "extension", "file_category_id", "is_active", "is_deleted", "is_deprecated", "key", "label", "maximum_size", "mime_type", "name", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("04127520-7ef4-4cf1-8829-d70b7c3c0138"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Modern image format providing superior compression for web usage.", ".webp", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "webp", "WEBP", 16777216L, "image/webp", "WebP Image Format", null, null, null, null },
                    { new Guid("057c8055-1895-49e6-9b80-ebe78f6aabef"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Microsoft Word (Open XML) file format.", ".docx", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "docx", "DOCX", 16777216L, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Microsoft Word (Open XML)", null, null, null, null },
                    { new Guid("12ee019d-6102-4828-b0c3-00ef53941595"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Microsoft Excel 97-2003 file format.", ".xls", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "xls", "XLS", 16777216L, "application/vnd.ms-excel", "Microsoft Excel 97-2003", null, null, null, null },
                    { new Guid("19dfb162-78e9-4b4f-9b45-2d4308ed746f"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "High-quality image format often used in publishing and scanning.", ".tiff", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "tiff", "TIFF", 16777216L, "image/tiff", "Tagged Image File Format", null, null, null, null },
                    { new Guid("29eeddb3-b709-4d71-bbff-21091c52bb26"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "PowerPoint (Open XML) file format.", ".pptx", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "pptx", "PPTX", 16777216L, "application/vnd.openxmlformats-officedocument.presentationml.presentation", "PowerPoint (Open XML)", null, null, null, null },
                    { new Guid("36d5657d-801d-49ce-9f4b-ed7ea6192582"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Comma Separated Values file format.", ".csv", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "csv", "CSV", 16777216L, "text/csv", "Comma Separated Values", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Standard video format for streaming and mobile.", ".mp4", new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), true, false, false, "mp4", "MP4", 500000000L, "video/mp4", "MPEG-4 Video", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Older format developed by Microsoft.", ".avi", new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), true, false, false, "avi", "AVI", 2000000000L, "video/x-msvideo", "Audio Video Interleave", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Modern container format for high-quality video.", ".mkv", new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), true, false, false, "mkv", "MKV", 2000000000L, "video/x-matroska", "Matroska Video", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Format used by Apple's QuickTime framework.", ".mov", new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), true, false, false, "mov", "MOV", 1000000000L, "video/quicktime", "Apple QuickTime Movie", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Open, royalty-free format designed for the web.", ".webm", new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), true, false, false, "webm", "WEBM", 500000000L, "video/webm", "WebM Video", null, null, null, null },
                    { new Guid("52ed76e7-1614-47be-93f7-0f4df56c9a8a"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Uncompressed raster image format mainly used in Windows systems.", ".bmp", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "bmp", "BMP", 16777216L, "image/bmp", "Bitmap Image File", null, null, null, null },
                    { new Guid("62a3d8ae-81fa-4c8e-b2f6-41a2f90a7490"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Animated or static image format with limited color palette.", ".gif", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "gif", "GIF", 16777216L, "image/gif", "Graphics Interchange Format", null, null, null, null },
                    { new Guid("71d8ea38-900a-4ebc-9d13-31caf17544f1"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Microsoft Excel (Open XML) file format.", ".xlsx", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "xlsx", "XLSX", 16777216L, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Microsoft Excel (Open XML)", null, null, null, null },
                    { new Guid("8afb9733-28a8-483e-938c-221186ad11b0"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Microsoft Word 97-2003 file format.", ".doc", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "doc", "DOC", 16777216L, "application/msword", "Microsoft Word 97-2003", null, null, null, null },
                    { new Guid("a10c24ce-4b9d-4007-8b92-51f8c8a615eb"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Plain Text File file format.", ".txt", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "txt", "TXT", 16777216L, "text/plain", "Plain Text File", null, null, null, null },
                    { new Guid("b05f39ac-c66e-470d-bba5-850c1b10d55f"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Rich Text Format file format.", ".rtf", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "rtf", "RTF", 16777216L, "application/rtf", "Rich Text Format", null, null, null, null },
                    { new Guid("bd7dde61-9f92-42d9-9e9e-146a773234e9"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "PowerPoint Presentation file format.", ".ppt", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "ppt", "PPT", 16777216L, "application/vnd.ms-powerpoint", "PowerPoint Presentation", null, null, null, null },
                    { new Guid("c05c21be-3e27-4326-92c2-f1160c8a1501"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Used to store icons in Windows applications.", ".ico", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "ico", "ICO", 1048576L, "image/x-icon", "Icon File", null, null, null, null },
                    { new Guid("c93fe653-33d0-45d8-9611-2d82eb6bd087"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Lossless image format commonly used for web graphics and UI design.", ".png", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "png", "PNG", 16777216L, "image/png", "Portable Network Graphics", null, null, null, null },
                    { new Guid("d4a51598-b08b-496d-b3d1-38b35e7d8316"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Portable Document Format file format.", ".pdf", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "pdf", "PDF", 16777216L, "application/pdf", "Portable Document Format", null, null, null, null },
                    { new Guid("dbb4d630-4a41-4900-844c-d99483ac7237"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Vector-based image format for scalable graphics.", ".svg", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "svg", "SVG", 16777216L, "image/svg+xml", "Scalable Vector Graphics", null, null, null, null },
                    { new Guid("e8b33ff5-bdb7-4bc4-8ad8-347a71200714"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Widely used compressed image format for digital photography.", ".jpg", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "jpg", "JPG", 16777216L, "image/jpeg", "JPEG Image", null, null, null, null },
                    { new Guid("ebe9df37-84a6-42e4-b5bf-c097dba1c2d1"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "OpenDocument Text file format.", ".odt", new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), true, false, false, "odt", "ODT", 16777216L, "application/vnd.oasis.opendocument.text", "OpenDocument Text", null, null, null, null },
                    { new Guid("fd37bba4-68d3-42f6-9bdf-c248c3d3972e"), new DateTimeOffset(new DateTime(2025, 5, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Alternative extension for JPG image format.", ".jpeg", new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), true, false, false, "jpeg", "JPEG", 16777216L, "image/jpeg", "JPEG Image", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("04127520-7ef4-4cf1-8829-d70b7c3c0138"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("057c8055-1895-49e6-9b80-ebe78f6aabef"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("12ee019d-6102-4828-b0c3-00ef53941595"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("19dfb162-78e9-4b4f-9b45-2d4308ed746f"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("29eeddb3-b709-4d71-bbff-21091c52bb26"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("36d5657d-801d-49ce-9f4b-ed7ea6192582"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("52ed76e7-1614-47be-93f7-0f4df56c9a8a"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("62a3d8ae-81fa-4c8e-b2f6-41a2f90a7490"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("71d8ea38-900a-4ebc-9d13-31caf17544f1"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8afb9733-28a8-483e-938c-221186ad11b0"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("a10c24ce-4b9d-4007-8b92-51f8c8a615eb"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("b05f39ac-c66e-470d-bba5-850c1b10d55f"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("bd7dde61-9f92-42d9-9e9e-146a773234e9"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("c05c21be-3e27-4326-92c2-f1160c8a1501"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("c93fe653-33d0-45d8-9611-2d82eb6bd087"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d4a51598-b08b-496d-b3d1-38b35e7d8316"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dbb4d630-4a41-4900-844c-d99483ac7237"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("e8b33ff5-bdb7-4bc4-8ad8-347a71200714"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("ebe9df37-84a6-42e4-b5bf-c097dba1c2d1"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd37bba4-68d3-42f6-9bdf-c248c3d3972e"));
        }
    }
}
