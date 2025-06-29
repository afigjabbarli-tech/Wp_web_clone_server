using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;
using File = WebWhatsAppClone.DataBase.Entities.File;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey((f) => f.id);
            builder.HasOne<FileFormat>((f) => f.file_format)
            .WithMany((ff) => ff.files)
            .HasForeignKey((f) => f.file_format_id);
        }
    }
}
