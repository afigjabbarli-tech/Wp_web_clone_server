using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Bridge;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class CountryPhoneCodeConfiguration : IEntityTypeConfiguration<CountryPhoneCode>
    {
        public void Configure(EntityTypeBuilder<CountryPhoneCode> builder)
        {
            builder.HasKey((entity) => new { entity.country_id, entity.phone_code_id });

            builder
                .HasOne<Country>((entity) => entity.country)
                .WithMany((country) => country.country_phone_codes)
                .HasForeignKey((entity) => entity.country_id);

            builder
                .HasOne<PhoneCode>((entity) => entity.phone_code)
                .WithMany((phone_code) => phone_code.country_phone_codes)
                .HasForeignKey((entity) => entity.phone_code_id);
        }
    }
}
