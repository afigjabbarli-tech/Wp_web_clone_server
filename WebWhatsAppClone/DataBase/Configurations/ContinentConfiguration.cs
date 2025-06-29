using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasData(
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    name = "Asia",
                    code = "AS",
                    un_code = "142",
                    population_density = 150,
                    area_km2 = 44579000,
                    population = 4600000000,
                    number_of_countries = 49,
                    largest_country = "Russia",
                    smallest_country = "Maldives",
                    most_populous_country = "China",
                    description = "Asia is the largest continent, both in area and population.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    name = "Africa",
                    code = "AF",
                    un_code = "002",
                    population_density = 45,
                    area_km2 = 30370000,
                    population = 1400000000,
                    number_of_countries = 54,
                    largest_country = "Algeria",
                    smallest_country = "Seychelles",
                    most_populous_country = "Nigeria",
                    description = "Africa is known for its vast natural resources and cultural diversity.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    name = "North America",
                    code = "NA",
                    un_code = "019",
                    population_density = 22,
                    area_km2 = 24709000,
                    population = 600000000,
                    number_of_countries = 23,
                    largest_country = "Canada",
                    smallest_country = "Saint Kitts and Nevis",
                    most_populous_country = "United States",
                    description = "North America includes major economies like the United States, Canada, and Mexico.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    name = "South America",
                    code = "SA",
                    un_code = "005",
                    population_density = 25,
                    area_km2 = 17840000,
                    population = 430000000,
                    number_of_countries = 12,
                    largest_country = "Brazil",
                    smallest_country = "Suriname",
                    most_populous_country = "Brazil",
                    description = "South America is known for the Amazon rainforest and Andes mountains.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    name = "Antarctica",
                    code = "AN",
                    un_code = "010",
                    population_density = 0,
                    area_km2 = 14000000,
                    population = 0,
                    number_of_countries = 0,
                    largest_country = string.Empty,
                    smallest_country = string.Empty,
                    most_populous_country = string.Empty,
                    description = "Antarctica is a frozen continent with no permanent population, mainly used for scientific research.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    name = "Europe",
                    code = "EU",
                    un_code = "150",
                    population_density = 72,
                    area_km2 = 10180000,
                    population = 750000000,
                    number_of_countries = 44,
                    largest_country = "Russia",
                    smallest_country = "Vatican City",
                    most_populous_country = "Russia",
                    description = "Europe has a rich cultural history and is home to the European Union.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Continent
                {
                    id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    name = "Australia",
                    code = "OC",
                    un_code = "009",
                    population_density = 5,
                    area_km2 = 8600000,
                    population = 42000000,
                    number_of_countries = 14,
                    largest_country = "Australia",
                    smallest_country = "Nauru",
                    most_populous_country = "Australia",
                    description = "Australia (Oceania) consists of the Australian mainland and many Pacific island nations.",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                }
            );
        }
    }
}
