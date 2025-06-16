using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileFormat",
                columns: new[] { "id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "extension", "file_category_id", "is_active", "is_deleted", "is_deprecated", "key", "label", "maximum_size", "mime_type", "name", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("39b70000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Scalable font format developed by Apple and Microsoft.", ".ttf", new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"), true, false, false, "ttf", "TTF", 10485760L, "font/ttf", "TrueType Font", null, null, null, null },
                    { new Guid("39b70000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Advanced font format developed by Microsoft and Adobe.", ".otf", new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"), true, false, false, "otf", "OTF", 10485760L, "font/otf", "OpenType Font", null, null, null, null },
                    { new Guid("39b70000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Font format optimized for web usage with compression.", ".woff", new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"), true, false, false, "woff", "WOFF", 5242880L, "font/woff", "Web Open Font Format", null, null, null, null },
                    { new Guid("39b70000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Improved version of WOFF with better compression for web fonts.", ".woff2", new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"), true, false, false, "woff2", "WOFF2", 5242880L, "font/woff2", "Web Open Font Format 2", null, null, null, null },
                    { new Guid("7db70000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Open standard eBook format widely supported on many devices.", ".epub", new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"), true, false, false, "epub", "EPUB", 52428800L, "application/epub+zip", "Electronic Publication", null, null, null, null },
                    { new Guid("7db70000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Older eBook format developed by Mobipocket, supported by Kindle.", ".mobi", new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"), true, false, false, "mobi", "MOBI", 52428800L, "application/x-mobipocket-ebook", "Mobipocket eBook", null, null, null, null },
                    { new Guid("7db70000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Proprietary eBook format used on Amazon Kindle devices.", ".azw", new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"), true, false, false, "azw", "AZW", 52428800L, "application/vnd.amazon.ebook", "Amazon Kindle AZW", null, null, null, null },
                    { new Guid("8f1e0000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Optical disc image of an entire CD, DVD, or Blu-ray.", ".iso", new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), true, false, false, "iso", "ISO", 10737418240L, "application/x-iso9660-image", "ISO Disk Image", null, null, null, null },
                    { new Guid("8f1e0000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Raw disk image used for drives and SD cards.", ".img", new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), true, false, false, "img", "IMG", 5368709120L, "application/octet-stream", "IMG Disk Image", null, null, null, null },
                    { new Guid("8f1e0000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Virtual hard drive format used by Microsoft virtualization.", ".vhd", new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), true, false, false, "vhd", "VHD", 17179869184L, "application/octet-stream", "Virtual Hard Disk", null, null, null, null },
                    { new Guid("8f1e0000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Mountable disk image used by macOS.", ".dmg", new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), true, false, false, "dmg", "DMG", 4294967296L, "application/x-apple-diskimage", "Apple Disk Image", null, null, null, null },
                    { new Guid("8f1e0000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Virtual Machine Disk format used by VMware products.", ".vmdk", new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), true, false, false, "vmdk", "VMDK", 21474836480L, "application/octet-stream", "VMware Disk Image", null, null, null, null },
                    { new Guid("dc6c0000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Generic binary database container file.", ".db", new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), true, false, false, "db", "Database", 10485760L, "application/octet-stream", "Generic Database File", null, null, null, null },
                    { new Guid("dc6c0000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Structured query language file used for database schema and data export.", ".sql", new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), true, false, false, "sql", "SQL", 5242880L, "application/sql", "SQL Dump File", null, null, null, null },
                    { new Guid("dc6c0000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "JavaScript Object Notation file used for structured data.", ".json", new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), true, false, false, "json", "JSON", 2097152L, "application/json", "JSON Data File", null, null, null, null },
                    { new Guid("dc6c0000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Extensible Markup Language data file used to store structured data.", ".xml", new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), true, false, false, "xml", "XML", 2097152L, "application/xml", "XML File", null, null, null, null },
                    { new Guid("dc6c0000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Comma Separated Values file used to store tabular data.", ".csv", new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), true, false, false, "csv", "CSV", 3145728L, "text/csv", "CSV File", null, null, null, null },
                    { new Guid("edc70000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Standard markup language for documents designed to be displayed in a web browser.", ".html", new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), true, false, false, "html", "HTML", 5242880L, "text/html", "HyperText Markup Language", null, null, null, null },
                    { new Guid("edc70000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Style sheet language used for describing the presentation of a document written in HTML or XML.", ".css", new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), true, false, false, "css", "CSS", 1048576L, "text/css", "Cascading Style Sheets", null, null, null, null },
                    { new Guid("edc70000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Lightweight, interpreted programming language with first-class functions.", ".js", new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), true, false, false, "js", "JS", 10485760L, "application/javascript", "JavaScript", null, null, null, null },
                    { new Guid("edc70000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "A typed superset of JavaScript that compiles to plain JavaScript.", ".ts", new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), true, false, false, "ts", "TS", 10485760L, "application/typescript", "TypeScript", null, null, null, null },
                    { new Guid("edc70000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "General-purpose scripting language especially suited to web development.", ".php", new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), true, false, false, "php", "PHP", 10485760L, "application/x-httpd-php", "PHP Hypertext Preprocessor", null, null, null, null },
                    { new Guid("eef90000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Package file used in various games to store data such as textures, models, and sounds.", ".pak", new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"), true, false, false, "pak", "PAK", 524288000L, "application/octet-stream", "Game Package File", null, null, null, null },
                    { new Guid("eef90000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Used in Unity game engine to store various types of assets for games and applications.", ".asset", new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"), true, false, false, "asset", "ASSET", 262144000L, "application/octet-stream", "Unity Asset File", null, null, null, null },
                    { new Guid("eef90000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Used to store app and game resources such as bitmaps, icons, and strings.", ".res", new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"), true, false, false, "res", "RES", 52428800L, "application/octet-stream", "Resource File", null, null, null, null },
                    { new Guid("eef90000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "File used to store saved game data and user progress in video games.", ".sav", new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"), true, false, false, "sav", "SAV", 10485760L, "application/octet-stream", "Game Save File", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Adobe Photoshop layered image file used for graphic design.", ".psd", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "psd", "PSD", 209715200L, "image/vnd.adobe.photoshop", "Photoshop Document", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Vector graphic file created by Adobe Illustrator.", ".ai", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "ai", "AI", 104857600L, "application/postscript", "Adobe Illustrator", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Design file exported from Figma design tool.", ".fig", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "fig", "FIG", 52428800L, "application/octet-stream", "Figma Design File", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "User interface design file created using Adobe XD.", ".xd", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "xd", "XD", 52428800L, "application/vnd.adobe.xd", "Adobe XD File", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "CAD drawing file used in AutoCAD for 2D and 3D design.", ".dwg", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "dwg", "DWG", 157286400L, "application/acad", "AutoCAD Drawing", null, null, null, null },
                    { new Guid("fd3f0000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "3D model file created using Blender software.", ".blend", new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), true, false, false, "blend", "BLEND", 524288000L, "application/x-blender", "Blender File", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("39b70000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("7db70000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("8f1e0000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("dc6c0000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("edc70000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("eef90000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("fd3f0000-0000-0000-0000-000000000006"));
        }
    }
}
