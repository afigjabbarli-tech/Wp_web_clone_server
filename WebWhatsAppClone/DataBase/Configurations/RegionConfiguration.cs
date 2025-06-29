using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey((r) => r.id);
            builder.HasOne<Continent>((r) => r.continent)
            .WithMany((c) => c.regions)
            .HasForeignKey((r) => r.continent_id);

            builder.HasData(
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    name = "Northern Africa",
                    code = "NAF",
                    geo_code = "015",
                    area_km2 = 7091800,
                    population = 246000000,
                    number_of_countries = 7,
                    largest_country = "Algeria",
                    smallest_country = "Tunisia",
                    most_populous_country = "Egypt",
                    population_density = 30.5,
                    description = "Northern Africa region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    name = "Western Africa",
                    code = "WAF",
                    geo_code = "011",
                    area_km2 = 5110000,
                    population = 422000000,
                    number_of_countries = 16,
                    largest_country = "Niger",
                    smallest_country = "Gambia",
                    most_populous_country = "Nigeria",
                    population_density = 82.6,
                    description = "Western Africa region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    name = "Middle Africa",
                    code = "MAF",
                    geo_code = "017",
                    area_km2 = 6400000,
                    population = 168000000,
                    number_of_countries = 9,
                    largest_country = "DR Congo",
                    smallest_country = "Equatorial Guinea",
                    most_populous_country = "DR Congo",
                    population_density = 26.3,
                    description = "Middle Africa (Central Africa)",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    name = "Eastern Africa",
                    code = "EAF",
                    geo_code = "014",
                    area_km2 = 6210000,
                    population = 445000000,
                    number_of_countries = 18,
                    largest_country = "Tanzania",
                    smallest_country = "Djibouti",
                    most_populous_country = "Ethiopia",
                    population_density = 71.6,
                    description = "Eastern Africa region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    name = "Southern Africa",
                    code = "SAF",
                    geo_code = "018",
                    area_km2 = 2675000,
                    population = 69000000,
                    number_of_countries = 5,
                    largest_country = "South Africa",
                    smallest_country = "Eswatini",
                    most_populous_country = "South Africa",
                    population_density = 25.8,
                    description = "Southern Africa region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    name = "Sub-Saharan Africa",
                    code = "SSA",
                    geo_code = "202",
                    area_km2 = 23278000,
                    population = 1154000000,
                    number_of_countries = 47,
                    largest_country = "Democratic Republic of the Congo",
                    smallest_country = "São Tomé and Príncipe",
                    most_populous_country = "Nigeria",
                    population_density = 49.6,
                    description = "Sub-Saharan Africa (composite region)",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("20000000-0000-0000-0000-000000000001"),
                    name = "Central Asia",
                    code = "CAS",
                    geo_code = "143",
                    area_km2 = 4000000,
                    population = 75000000,
                    number_of_countries = 5,
                    largest_country = "Kazakhstan",
                    smallest_country = "Tajikistan",
                    most_populous_country = "Uzbekistan",
                    population_density = 18.8,
                    description = "Central Asia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("20000000-0000-0000-0000-000000000002"),
                    name = "Western Asia",
                    code = "WAS",
                    geo_code = "145",
                    area_km2 = 6720000,
                    population = 280000000,
                    number_of_countries = 12,
                    largest_country = "Saudi Arabia",
                    smallest_country = "Bahrain",
                    most_populous_country = "Turkey",
                    population_density = 41.7,
                    description = "Western Asia region (Middle East)",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("20000000-0000-0000-0000-000000000003"),
                    name = "Eastern Asia",
                    code = "EAS",
                    geo_code = "030",
                    area_km2 = 11600000,
                    population = 1600000000,
                    number_of_countries = 6,
                    largest_country = "China",
                    smallest_country = "Macau",
                    most_populous_country = "China",
                    population_density = 137.9,
                    description = "Eastern Asia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("20000000-0000-0000-0000-000000000004"),
                    name = "South-Eastern Asia",
                    code = "SEA",
                    geo_code = "035",
                    area_km2 = 4490000,
                    population = 690000000,
                    number_of_countries = 11,
                    largest_country = "Indonesia",
                    smallest_country = "Brunei",
                    most_populous_country = "Indonesia",
                    population_density = 153.7,
                    description = "South-Eastern Asia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("20000000-0000-0000-0000-000000000005"),
                    name = "Southern Asia",
                    code = "SAS",
                    geo_code = "034",
                    area_km2 = 5040000,
                    population = 1900000000,
                    number_of_countries = 8,
                    largest_country = "India",
                    smallest_country = "Bhutan",
                    most_populous_country = "India",
                    population_density = 374.1,
                    description = "Southern Asia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("30000000-0000-0000-0000-000000000001"),
                    name = "Northern Europe",
                    code = "NEU",
                    geo_code = "154",
                    area_km2 = 1300000,
                    population = 106000000,
                    number_of_countries = 10,
                    largest_country = "United Kingdom",
                    smallest_country = "Iceland",
                    most_populous_country = "United Kingdom",
                    population_density = 81.5,
                    description = "Northern Europe region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("30000000-0000-0000-0000-000000000002"),
                    name = "Southern Europe",
                    code = "SEU",
                    geo_code = "039",
                    area_km2 = 1300000,
                    population = 152000000,
                    number_of_countries = 15,
                    largest_country = "Spain",
                    smallest_country = "San Marino",
                    most_populous_country = "Italy",
                    population_density = 117.0,
                    description = "Southern Europe region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("30000000-0000-0000-0000-000000000003"),
                    name = "Western Europe",
                    code = "WEU",
                    geo_code = "155",
                    area_km2 = 1000000,
                    population = 196000000,
                    number_of_countries = 9,
                    largest_country = "France",
                    smallest_country = "Luxembourg",
                    most_populous_country = "Germany",
                    population_density = 196.0,
                    description = "Western Europe region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("30000000-0000-0000-0000-000000000004"),
                    name = "Eastern Europe",
                    code = "EEU",
                    geo_code = "151",
                    area_km2 = 1800000,
                    population = 293000000,
                    number_of_countries = 10,
                    largest_country = "Russia",
                    smallest_country = "Moldova",
                    most_populous_country = "Russia",
                    population_density = 23.7,
                    description = "Eastern Europe region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                 new Region
                 {
                     id = Guid.Parse("40000000-0000-0000-0000-000000000001"),
                     name = "Northern America",
                     code = "NAM",
                     geo_code = "021",
                     area_km2 = 21000000,
                     population = 370000000,
                     number_of_countries = 3,
                     largest_country = "Canada",
                     smallest_country = "Saint Pierre and Miquelon",
                     most_populous_country = "United States",
                     population_density = 17.6,
                     description = "Northern America region",
                     continent_id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                     created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                 },
                new Region
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000002"),
                    name = "Central America",
                    code = "CAM",
                    geo_code = "013",
                    area_km2 = 524000,
                    population = 180000000,
                    number_of_countries = 7,
                    largest_country = "Nicaragua",
                    smallest_country = "Belize",
                    most_populous_country = "Guatemala",
                    population_density = 343.0,
                    description = "Central America region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000003"),
                    name = "Caribbean",
                    code = "CAR",
                    geo_code = "029",
                    area_km2 = 275400,
                    population = 44000000,
                    number_of_countries = 13,
                    largest_country = "Cuba",
                    smallest_country = "Saint Kitts and Nevis",
                    most_populous_country = "Cuba",
                    population_density = 159.6,
                    description = "Caribbean region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000001"),
                    name = "South America",
                    code = "SAM",
                    geo_code = "005",
                    area_km2 = 17840000,
                    population = 430000000,
                    number_of_countries = 12,
                    largest_country = "Brazil",
                    smallest_country = "Suriname",
                    most_populous_country = "Brazil",
                    population_density = 24.1,
                    description = "South America region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("60000000-0000-0000-0000-000000000001"),
                    name = "Australia and New Zealand",
                    code = "ANZ",
                    geo_code = "053",
                    area_km2 = 8800000,
                    population = 30000000,
                    number_of_countries = 2,
                    largest_country = "Australia",
                    smallest_country = "New Zealand",
                    most_populous_country = "Australia",
                    population_density = 3.4,
                    description = "Australia and New Zealand region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("60000000-0000-0000-0000-000000000002"),
                    name = "Melanesia",
                    code = "MEL",
                    geo_code = "054",
                    area_km2 = 450000,
                    population = 12000000,
                    number_of_countries = 4,
                    largest_country = "Papua New Guinea",
                    smallest_country = "Nauru",
                    most_populous_country = "Papua New Guinea",
                    population_density = 26.7,
                    description = "Melanesia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("60000000-0000-0000-0000-000000000003"),
                    name = "Micronesia",
                    code = "MIC",
                    geo_code = "057",
                    area_km2 = 27000,
                    population = 500000,
                    number_of_countries = 7,
                    largest_country = "Guam",
                    smallest_country = "Nauru",
                    most_populous_country = "Guam",
                    population_density = 18.5,
                    description = "Micronesia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("60000000-0000-0000-0000-000000000004"),
                    name = "Polynesia",
                    code = "POL",
                    geo_code = "061",
                    area_km2 = 4500000,
                    population = 1000000,
                    number_of_countries = 14,
                    largest_country = "Samoa",
                    smallest_country = "Tokelau",
                    most_populous_country = "Samoa",
                    population_density = 0.22,
                    description = "Polynesia region",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                },
                new Region
                {
                    id = Guid.Parse("70000000-0000-0000-0000-000000000001"),
                    name = "Antarctica",
                    code = "ANT",
                    geo_code = "010",
                    area_km2 = 14000000,
                    population = 0,
                    number_of_countries = 0,
                    largest_country = string.Empty,
                    smallest_country = string.Empty,
                    most_populous_country = string.Empty,
                    population_density = 0,
                    description = "Antarctica is a frozen continent with no permanent population.",
                    continent_id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    created_at = new DateTimeOffset(2025, 1, 30, 13, 45, 23, TimeSpan.Zero)
                }
            );
        }
    }
}
