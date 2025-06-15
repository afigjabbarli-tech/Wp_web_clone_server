using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration4SeedinitialfilecategorydataintoFileCategorytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileCategories",
                columns: new[] { "id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "is_active", "is_deleted", "key", "label", "name", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Program and installer files such as EXE, MSI, APK, SH, and APP.", true, false, "executable", "Executable", "Executable Files", null, null, null, null },
                    { new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Typeface and font formats like TTF, OTF, WOFF, and WOFF2.", true, false, "font", "Font", "Font Files", null, null, null, null },
                    { new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Compressed file containers such as ZIP, RAR, 7Z, TAR, and GZ.", true, false, "archive", "Archive", "Compressed Archives", null, null, null, null },
                    { new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Programming and scripting languages like CS, JS, HTML, PY, PHP, TS, and JSON.", true, false, "code", "Code", "Source Code Files", null, null, null, null },
                    { new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Digital book formats including EPUB, MOBI, and AZW.", true, false, "ebook", "eBook", "eBook Files", null, null, null, null },
                    { new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Virtual and backup images including ISO, IMG, VHD, DMG, and VMDK.", true, false, "disk-image", "Disk Image", "Disk Image Files", null, null, null, null },
                    { new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files.", true, false, "document", "Document", "Document Files", null, null, null, null },
                    { new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Raster and vector image formats like JPG, PNG, GIF, BMP, SVG, and WEBP.", true, false, "image", "Image", "Image Files", null, null, null, null },
                    { new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Multimedia files including MP4, AVI, MKV, MOV, and WEBM.", true, false, "video", "Video", "Video Files", null, null, null, null },
                    { new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Files used for system settings and configuration like INI, LOG, ENV, SYS, and DLL.", true, false, "system", "System", "System & Config Files", null, null, null, null },
                    { new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Structured data and database files such as DB, SQL, JSON, XML, and CSV.", true, false, "data", "Data", "Database & Data Files", null, null, null, null },
                    { new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Sound and music formats such as MP3, WAV, FLAC, AAC, and OGG.", true, false, "audio", "Audio", "Audio Files", null, null, null, null },
                    { new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Web development files such as HTML, CSS, JS, TS, and PHP.", true, false, "web", "Web", "Web Files", null, null, null, null },
                    { new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Game assets and app data like PAK, ASSET, RES, and SAV.", true, false, "game", "Game", "Game & App Resources", null, null, null, null },
                    { new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"), new DateTimeOffset(new DateTime(2025, 3, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Files used in design and 3D modeling like PSD, AI, FIG, XD, DWG, and BLEND.", true, false, "design", "Design", "Design & CAD Files", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("7db77137-1df3-4a42-a80e-f66e8b080be1"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("eef901cf-16c7-43fc-b22e-456f8794a032"));

            migrationBuilder.DeleteData(
                table: "FileCategories",
                keyColumn: "id",
                keyValue: new Guid("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"));
        }
    }
}
