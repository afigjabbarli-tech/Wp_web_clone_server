using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                column: "maximum_size",
                value: 524288000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                column: "maximum_size",
                value: 2097152000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                column: "maximum_size",
                value: 2097152000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                column: "maximum_size",
                value: 1073741824L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                column: "maximum_size",
                value: 524288000L);

            migrationBuilder.InsertData(
                table: "FileFormat",
                columns: new[] { "id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "extension", "file_category_id", "is_active", "is_deleted", "is_deprecated", "key", "label", "maximum_size", "mime_type", "name", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("2f180000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Standard executable file format used by Windows.", ".exe", new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), true, false, false, "exe", "EXE", 52428800L, "application/vnd.microsoft.portable-executable", "Windows Executable", null, null, null, null },
                    { new Guid("2f180000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Installer package used by Windows for software installation.", ".msi", new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), true, false, false, "msi", "MSI", 104857600L, "application/x-msi", "Microsoft Installer", null, null, null, null },
                    { new Guid("2f180000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Application package used by Android OS for installing mobile apps.", ".apk", new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), true, false, false, "apk", "APK", 104857600L, "application/vnd.android.package-archive", "Android Package", null, null, null, null },
                    { new Guid("2f180000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Shell script used in Unix/Linux systems to execute commands.", ".sh", new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), true, false, false, "sh", "SH", 1048576L, "application/x-sh", "Shell Script", null, null, null, null },
                    { new Guid("2f180000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Executable bundle used in macOS systems.", ".app", new Guid("2f181b9f-7a31-41bb-8f17-7418f6944a7b"), true, false, false, "app", "APP", 157286400L, "application/octet-stream", "Mac Application Bundle", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Widely used lossy audio format.", ".mp3", new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), true, false, false, "mp3", "MP3", 104857600L, "audio/mpeg", "MPEG Audio Layer III", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Uncompressed audio format for high quality.", ".wav", new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), true, false, false, "wav", "WAV", 524288000L, "audio/wav", "Waveform Audio File Format", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Lossless compression audio format.", ".flac", new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), true, false, false, "flac", "FLAC", 524288000L, "audio/flac", "Free Lossless Audio Codec", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Lossy audio format with better compression than MP3.", ".aac", new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), true, false, false, "aac", "AAC", 104857600L, "audio/aac", "Advanced Audio Coding", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Open-source lossy audio format.", ".ogg", new Guid("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"), true, false, false, "ogg", "OGG", 104857600L, "audio/ogg", "Ogg Vorbis Audio", null, null, null, null },
                    { new Guid("61000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Widely used compressed archive format.", ".zip", new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), true, false, false, "zip", "ZIP", 1073741824L, "application/zip", "ZIP Archive", null, null, null, null },
                    { new Guid("61000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Popular proprietary compressed archive format.", ".rar", new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), true, false, false, "rar", "RAR", 2147483648L, "application/x-rar-compressed", "RAR Archive", null, null, null, null },
                    { new Guid("61000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "High compression ratio archive format.", ".7z", new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), true, false, false, "7z", "7Z", 3221225472L, "application/x-7z-compressed", "7-Zip Archive", null, null, null, null },
                    { new Guid("61000000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Unix archive file, often combined with compression.", ".tar", new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), true, false, false, "tar", "TAR", 4294967296L, "application/x-tar", "Tape Archive", null, null, null, null },
                    { new Guid("61000000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Compression format commonly used on Unix systems.", ".gz", new Guid("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"), true, false, false, "gz", "GZ", 2147483648L, "application/gzip", "Gzip Compressed Archive", null, null, null, null },
                    { new Guid("d9800000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Configuration file format for software and system settings.", ".ini", new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), true, false, false, "ini", "INI", 102400L, "text/plain", "Initialization File", null, null, null, null },
                    { new Guid("d9800000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "File used to record system or application events.", ".log", new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), true, false, false, "log", "LOG", 10485760L, "text/plain", "Log File", null, null, null, null },
                    { new Guid("d9800000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "File to define environment variables, often used in development.", ".env", new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), true, false, false, "env", "ENV", 51200L, "text/plain", "Environment Variables File", null, null, null, null },
                    { new Guid("d9800000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Windows system file used by the operating system.", ".sys", new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), true, false, false, "sys", "SYS", 52428800L, "application/octet-stream", "System File", null, null, null, null },
                    { new Guid("d9800000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Library file containing code and data used by multiple programs.", ".dll", new Guid("d98fd5b0-3b70-4428-b690-d6886d2bb40d"), true, false, false, "dll", "DLL", 104857600L, "application/octet-stream", "Dynamic Link Library", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("2f180000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("61000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("d9800000-0000-0000-0000-000000000005"));

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                column: "maximum_size",
                value: 500000000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                column: "maximum_size",
                value: 2000000000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                column: "maximum_size",
                value: 2000000000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                column: "maximum_size",
                value: 1000000000L);

            migrationBuilder.UpdateData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                column: "maximum_size",
                value: 500000000L);
        }
    }
}
