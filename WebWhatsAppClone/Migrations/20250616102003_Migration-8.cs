using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileFormat",
                columns: new[] { "id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "extension", "file_category_id", "is_active", "is_deleted", "is_deprecated", "key", "label", "maximum_size", "mime_type", "name", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("70f90000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "C# programming language source file.", ".cs", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "cs", "C#", 524288L, "text/plain", "C# Source Code", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "JavaScript scripting language file.", ".js", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "js", "JavaScript", 1048576L, "application/javascript", "JavaScript File", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "HyperText Markup Language file used for web pages.", ".html", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "html", "HTML", 524288L, "text/html", "HTML Document", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Python programming language script file.", ".py", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "py", "Python", 1048576L, "text/x-python", "Python Script", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "PHP Hypertext Preprocessor server-side scripting file.", ".php", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "php", "PHP", 1048576L, "application/x-httpd-php", "PHP Script", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "TypeScript superset of JavaScript with typing.", ".ts", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "ts", "TypeScript", 1048576L, "application/typescript", "TypeScript File", null, null, null, null },
                    { new Guid("70f90000-0000-0000-0000-000000000007"), new DateTimeOffset(new DateTime(2025, 5, 25, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "JavaScript Object Notation structured data file.", ".json", new Guid("70f9189f-6f15-421f-a9c9-147a0c4e40c7"), true, false, false, "json", "JSON", 2097152L, "application/json", "JSON Data", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "FileFormat",
                keyColumn: "id",
                keyValue: new Guid("70f90000-0000-0000-0000-000000000007"));
        }
    }
}
