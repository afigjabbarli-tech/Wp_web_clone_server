using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;
using System;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData
            (
                new Country
                {
                    id = Guid.Parse("691a19d9-355d-468f-a803-147c8b0d9a2d"),
                    name = "Türkiye",
                    key = "TR",
                    official_name = "Türkiye Cumhuriyeti",
                    native_name = "Türkiye",
                    iso_alpha2_code = "TR",
                    iso_alpha3_code = "TUR",
                    iso_numeric = 792,
                    tld = ".tr",
                    capital = "Ankara",
                    currency_code = "TRY",
                    currency_name = "Turkish Lira",
                    area_km2 = 783562,
                    population = 85000000,
                    population_density = 108.4,
                    demonym = "Turkish",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Country
                {
                    id = Guid.Parse("067716d7-58c7-45d8-a8dd-ba39b5cd1ca3"),
                    name = "Azerbaycan",
                    key = "AZ",
                    official_name = "Azərbaycan Respublikası",
                    native_name = "Azərbaycan",
                    iso_alpha2_code = "AZ",
                    iso_alpha3_code = "AZE",
                    iso_numeric = 31,
                    tld = ".az",
                    capital = "Bakü",
                    currency_code = "AZN",
                    currency_name = "Azerbaijani Manat",
                    area_km2 = 86600,
                    population = 10100000,
                    population_density = 116.7,
                    demonym = "Azerbaijani",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Country
                {
                    id = Guid.Parse("68c58e59-6c48-490d-9a6f-d2db12644a8b"),
                    name = "Gürcistan",
                    key = "GE",
                    official_name = "საქართველო",
                    native_name = "საქართველო",
                    iso_alpha2_code = "GE",
                    iso_alpha3_code = "GEO",
                    iso_numeric = 268,
                    tld = ".ge",
                    capital = "Tiflis",
                    currency_code = "GEL",
                    currency_name = "Georgian Lari",
                    area_km2 = 69700,
                    population = 3700000,
                    population_density = 53.1,
                    demonym = "Georgian",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                },
                new Country
                {
                    id = Guid.Parse("4a1eadb4-b76d-448d-b8fb-95adf7734f30"),
                    name = "İran",
                    key = "IR",
                    official_name = "جمهوری اسلامی ایران",
                    native_name = "ایران",
                    iso_alpha2_code = "IR",
                    iso_alpha3_code = "IRN",
                    iso_numeric = 364,
                    tld = ".ir",
                    capital = "Tahran",
                    currency_code = "IRR",
                    currency_name = "Iranian Rial",
                    area_km2 = 1648195,
                    population = 85000000,
                    population_density = 51.5,
                    demonym = "Iranian",
                    created_at = new DateTimeOffset(new DateTime(2025, 01, 30, 13, 45, 23), TimeSpan.Zero)
                }
            );
        }
    }
}
