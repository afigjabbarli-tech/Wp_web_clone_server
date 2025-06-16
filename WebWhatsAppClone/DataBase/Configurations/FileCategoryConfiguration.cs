using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class FileCategoryConfiguration : IEntityTypeConfiguration<FileCategory>
    {
        public void Configure(EntityTypeBuilder<FileCategory> builder)
        {
            builder.HasKey((fc) => fc.id);
            builder
            .HasMany<FileFormat>((fc) => fc.file_formats)
            .WithOne((ff) => ff.file_category)
            .HasForeignKey((ff) => ff.file_category_id)
            .OnDelete(DeleteBehavior.Cascade);
            builder.HasData
            (new FileCategory
            {
                id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                key = "document",
                label = "Document",
                name = "Document Files",
                description = "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                key = "image",
                label = "Image",
                name = "Image Files",
                description = "Raster and vector image formats like JPG, PNG, GIF, BMP, SVG, and WEBP.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                key = "video",
                label = "Video",
                name = "Video Files",
                description = "Multimedia files including MP4, AVI, MKV, MOV, and WEBM.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                key = "audio",
                label = "Audio",
                name = "Audio Files",
                description = "Sound and music formats such as MP3, WAV, FLAC, AAC, and OGG.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                key = "archive",
                label = "Archive",
                name = "Compressed Archives",
                description = "Compressed file containers such as ZIP, RAR, 7Z, TAR, and GZ.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                key = "system",
                label = "System",
                name = "System & Config Files",
                description = "Files used for system settings and configuration like INI, LOG, ENV, SYS, and DLL.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                key = "executable",
                label = "Executable",
                name = "Executable Files",
                description = "Program and installer files such as EXE, MSI, APK, SH, and APP.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                key = "code",
                label = "Code",
                name = "Source Code Files",
                description = "Programming and scripting languages like CS, JS, HTML, PY, PHP, TS, and JSON.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                key = "data",
                label = "Data",
                name = "Database & Data Files",
                description = "Structured data and database files such as DB, SQL, JSON, XML, and CSV.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                key = "disk-image",
                label = "Disk Image",
                name = "Disk Image Files",
                description = "Virtual and backup images including ISO, IMG, VHD, DMG, and VMDK.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                key = "font",
                label = "Font",
                name = "Font Files",
                description = "Typeface and font formats like TTF, OTF, WOFF, and WOFF2.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("7db77137-1df3-4a42-a80e-f66e8b080be1"),
                key = "ebook",
                label = "eBook",
                name = "eBook Files",
                description = "Digital book formats including EPUB, MOBI, and AZW.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                key = "design",
                label = "Design",
                name = "Design & CAD Files",
                description = "Files used in design and 3D modeling like PSD, AI, FIG, XD, DWG, and BLEND.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                key = "web",
                label = "Web",
                name = "Web Files",
                description = "Web development files such as HTML, CSS, JS, TS, and PHP.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            },
            new FileCategory
            {
                id = Guid.Parse("eef901cf-16c7-43fc-b22e-456f8794a032"),
                key = "game",
                label = "Game",
                name = "Game & App Resources",
                description = "Game assets and app data like PAK, ASSET, RES, and SAV.",
                created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
            });
        }
    }
}
