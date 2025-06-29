using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "id", "area_km2", "code", "continent_id", "created_at", "created_by", "deleted_at", "deleted_by", "description", "geo_code", "is_active", "is_deleted", "is_updated", "largest_country", "most_populous_country", "name", "number_of_countries", "population", "population_density", "smallest_country", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 7091800.0, "NAF", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Northern Africa region", "015", true, false, false, "Algeria", "Egypt", "Northern Africa", 7, 246000000L, 30.5, "Tunisia", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 5110000.0, "WAF", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Western Africa region", "011", true, false, false, "Niger", "Nigeria", "Western Africa", 16, 422000000L, 82.599999999999994, "Gambia", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 6400000.0, "MAF", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Middle Africa (Central Africa)", "017", true, false, false, "DR Congo", "DR Congo", "Middle Africa", 9, 168000000L, 26.300000000000001, "Equatorial Guinea", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 6210000.0, "EAF", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Eastern Africa region", "014", true, false, false, "Tanzania", "Ethiopia", "Eastern Africa", 18, 445000000L, 71.599999999999994, "Djibouti", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 2675000.0, "SAF", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southern Africa region", "018", true, false, false, "South Africa", "South Africa", "Southern Africa", 5, 69000000L, 25.800000000000001, "Eswatini", null, null, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 23278000.0, "SSA", new Guid("00000000-0000-0000-0000-000000000002"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Sub-Saharan Africa (composite region)", "202", true, false, false, "Democratic Republic of the Congo", "Nigeria", "Sub-Saharan Africa", 47, 1154000000L, 49.600000000000001, "São Tomé and Príncipe", null, null, null, null },
                    { new Guid("20000000-0000-0000-0000-000000000001"), 4000000.0, "CAS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Central Asia region", "143", true, false, false, "Kazakhstan", "Uzbekistan", "Central Asia", 5, 75000000L, 18.800000000000001, "Tajikistan", null, null, null, null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), 6720000.0, "WAS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Western Asia region (Middle East)", "145", true, false, false, "Saudi Arabia", "Turkey", "Western Asia", 12, 280000000L, 41.700000000000003, "Bahrain", null, null, null, null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), 11600000.0, "EAS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Eastern Asia region", "030", true, false, false, "China", "China", "Eastern Asia", 6, 1600000000L, 137.90000000000001, "Macau", null, null, null, null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), 4490000.0, "SEA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "South-Eastern Asia region", "035", true, false, false, "Indonesia", "Indonesia", "South-Eastern Asia", 11, 690000000L, 153.69999999999999, "Brunei", null, null, null, null },
                    { new Guid("20000000-0000-0000-0000-000000000005"), 5040000.0, "SAS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southern Asia region", "034", true, false, false, "India", "India", "Southern Asia", 8, 1900000000L, 374.10000000000002, "Bhutan", null, null, null, null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), 1300000.0, "NEU", new Guid("00000000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Northern Europe region", "154", true, false, false, "United Kingdom", "United Kingdom", "Northern Europe", 10, 106000000L, 81.5, "Iceland", null, null, null, null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), 1300000.0, "SEU", new Guid("00000000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southern Europe region", "039", true, false, false, "Spain", "Italy", "Southern Europe", 15, 152000000L, 117.0, "San Marino", null, null, null, null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), 1000000.0, "WEU", new Guid("00000000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Western Europe region", "155", true, false, false, "France", "Germany", "Western Europe", 9, 196000000L, 196.0, "Luxembourg", null, null, null, null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), 1800000.0, "EEU", new Guid("00000000-0000-0000-0000-000000000006"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Eastern Europe region", "151", true, false, false, "Russia", "Russia", "Eastern Europe", 10, 293000000L, 23.699999999999999, "Moldova", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000001"), 21000000.0, "NAM", new Guid("00000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Northern America region", "021", true, false, false, "Canada", "United States", "Northern America", 3, 370000000L, 17.600000000000001, "Saint Pierre and Miquelon", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000002"), 524000.0, "CAM", new Guid("00000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Central America region", "013", true, false, false, "Nicaragua", "Guatemala", "Central America", 7, 180000000L, 343.0, "Belize", null, null, null, null },
                    { new Guid("40000000-0000-0000-0000-000000000003"), 275400.0, "CAR", new Guid("00000000-0000-0000-0000-000000000003"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Caribbean region", "029", true, false, false, "Cuba", "Cuba", "Caribbean", 13, 44000000L, 159.59999999999999, "Saint Kitts and Nevis", null, null, null, null },
                    { new Guid("50000000-0000-0000-0000-000000000001"), 17840000.0, "SAM", new Guid("00000000-0000-0000-0000-000000000004"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "South America region", "005", true, false, false, "Brazil", "Brazil", "South America", 12, 430000000L, 24.100000000000001, "Suriname", null, null, null, null },
                    { new Guid("60000000-0000-0000-0000-000000000001"), 8800000.0, "ANZ", new Guid("00000000-0000-0000-0000-000000000007"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Australia and New Zealand region", "053", true, false, false, "Australia", "Australia", "Australia and New Zealand", 2, 30000000L, 3.3999999999999999, "New Zealand", null, null, null, null },
                    { new Guid("60000000-0000-0000-0000-000000000002"), 450000.0, "MEL", new Guid("00000000-0000-0000-0000-000000000007"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Melanesia region", "054", true, false, false, "Papua New Guinea", "Papua New Guinea", "Melanesia", 4, 12000000L, 26.699999999999999, "Nauru", null, null, null, null },
                    { new Guid("60000000-0000-0000-0000-000000000003"), 27000.0, "MIC", new Guid("00000000-0000-0000-0000-000000000007"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Micronesia region", "057", true, false, false, "Guam", "Guam", "Micronesia", 7, 500000L, 18.5, "Nauru", null, null, null, null },
                    { new Guid("60000000-0000-0000-0000-000000000004"), 4500000.0, "POL", new Guid("00000000-0000-0000-0000-000000000007"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Polynesia region", "061", true, false, false, "Samoa", "Samoa", "Polynesia", 14, 1000000L, 0.22, "Tokelau", null, null, null, null },
                    { new Guid("70000000-0000-0000-0000-000000000001"), 14000000.0, "ANT", new Guid("00000000-0000-0000-0000-000000000005"), new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Antarctica is a frozen continent with no permanent population.", "010", true, false, false, "", "", "Antarctica", 0, 0L, 0.0, "", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "id",
                keyValue: new Guid("70000000-0000-0000-0000-000000000001"));
        }
    }
}
