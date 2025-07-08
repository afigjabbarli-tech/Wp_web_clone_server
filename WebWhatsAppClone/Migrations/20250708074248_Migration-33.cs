using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "area_km2", "capital", "created_at", "created_by", "currency_code", "currency_name", "deleted_at", "deleted_by", "demonym", "is_active", "is_deleted", "is_updated", "iso_alpha2_code", "iso_alpha3_code", "iso_numeric", "key", "name", "native_name", "official_name", "population", "population_density", "status_changed_at", "status_changed_by", "tld", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("067716d7-58c7-45d8-a8dd-ba39b5cd1ca3"), 86600.0, "Bakü", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "AZN", "Azerbaijani Manat", null, null, "Azerbaijani", true, false, false, "AZ", "AZE", 31, "AZ", "Azerbaycan", "Azərbaycan", "Azərbaycan Respublikası", 10100000L, 116.7, null, null, ".az", null, null },
                    { new Guid("4a1eadb4-b76d-448d-b8fb-95adf7734f30"), 1648195.0, "Tahran", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "IRR", "Iranian Rial", null, null, "Iranian", true, false, false, "IR", "IRN", 364, "IR", "İran", "ایران", "جمهوری اسلامی ایران", 85000000L, 51.5, null, null, ".ir", null, null },
                    { new Guid("68c58e59-6c48-490d-9a6f-d2db12644a8b"), 69700.0, "Tiflis", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "GEL", "Georgian Lari", null, null, "Georgian", true, false, false, "GE", "GEO", 268, "GE", "Gürcistan", "საქართველო", "საქართველო", 3700000L, 53.100000000000001, null, null, ".ge", null, null },
                    { new Guid("691a19d9-355d-468f-a803-147c8b0d9a2d"), 783562.0, "Ankara", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "TRY", "Turkish Lira", null, null, "Turkish", true, false, false, "TR", "TUR", 792, "TR", "Türkiye", "Türkiye", "Türkiye Cumhuriyeti", 85000000L, 108.40000000000001, null, null, ".tr", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: new Guid("067716d7-58c7-45d8-a8dd-ba39b5cd1ca3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: new Guid("4a1eadb4-b76d-448d-b8fb-95adf7734f30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: new Guid("68c58e59-6c48-490d-9a6f-d2db12644a8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: new Guid("691a19d9-355d-468f-a803-147c8b0d9a2d"));
        }
    }
}
