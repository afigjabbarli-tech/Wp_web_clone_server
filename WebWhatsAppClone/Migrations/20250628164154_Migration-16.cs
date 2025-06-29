using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "id", "area_km2", "created_at", "created_by", "deleted_at", "deleted_by", "description", "is_active", "is_deleted", "is_updated", "largest_country", "most_populous_country", "name", "number_of_countries", "population", "smallest_country", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 44579000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Asia is the largest continent, both in area and population.", true, false, false, "Russia", "China", "Asia", 49, 4600000000L, "Maldives", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 30370000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Africa is known for its vast natural resources and cultural diversity.", true, false, false, "Algeria", "Nigeria", "Africa", 54, 1400000000L, "Seychelles", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 24709000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "North America includes major economies like the United States, Canada, and Mexico.", true, false, false, "Canada", "United States", "North America", 23, 600000000L, "Saint Kitts and Nevis", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 17840000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "South America is known for the Amazon rainforest and Andes mountains.", true, false, false, "Brazil", "Brazil", "South America", 12, 430000000L, "Suriname", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 14000000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Antarctica is a frozen continent with no permanent population, mainly used for scientific research.", true, false, false, "", "", "Antarctica", 0, 0L, "", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 10180000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Europe has a rich cultural history and is home to the European Union.", true, false, false, "Russia", "Russia", "Europe", 44, 750000000L, "Vatican City", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000007"), 8600000.0, new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Australia (Oceania) consists of the Australian mainland and many Pacific island nations.", true, false, false, "Australia", "Australia", "Australia", 14, 42000000L, "Nauru", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"));
        }
    }
}
