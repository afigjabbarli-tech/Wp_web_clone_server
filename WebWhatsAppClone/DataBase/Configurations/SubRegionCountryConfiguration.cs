using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Bridge;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class SubRegionCountryConfiguration : IEntityTypeConfiguration<SubRegionCountry>
    {
        public void Configure(EntityTypeBuilder<SubRegionCountry> builder)
        {
            builder.HasKey((entity) => new { entity.sub_region_id, entity.country_id });

            builder
                .HasOne<SubRegion>((entity) => entity.sub_region)
                .WithMany((sub_region) => sub_region.sub_region_countries)
                .HasForeignKey((entity) => entity.sub_region_id);

            builder
                .HasOne<Country>((entity) => entity.country)
                .WithMany((country) => country.sub_region_countries)
                .HasForeignKey((entity) => entity.country_id);
        }
    }
}
