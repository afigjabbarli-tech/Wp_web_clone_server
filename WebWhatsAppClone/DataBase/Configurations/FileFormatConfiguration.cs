using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Configurations
{
    public class FileFormatConfiguration : IEntityTypeConfiguration<FileFormat>
    {
        public void Configure(EntityTypeBuilder<FileFormat> builder)
        {
            builder.HasKey((ff) => ff.id);
            builder.HasOne<FileCategory>((ff) => ff.file_category)
            .WithMany((fc) => fc.file_formats)
            .HasForeignKey((ff) => ff.file_category_id);
            builder.HasData
            (
                new FileFormat
                {
                    id = Guid.Parse("d4a51598-b08b-496d-b3d1-38b35e7d8316"),
                    key = "pdf",
                    label = "PDF",
                    name = "Portable Document Format",
                    description = "Portable Document Format file format.",
                    mime_type = "application/pdf",
                    extension = ".pdf",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8afb9733-28a8-483e-938c-221186ad11b0"),
                    key = "doc",
                    label = "DOC",
                    name = "Microsoft Word 97-2003",
                    description = "Microsoft Word 97-2003 file format.",
                    mime_type = "application/msword",
                    extension = ".doc",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("057c8055-1895-49e6-9b80-ebe78f6aabef"),
                    key = "docx",
                    label = "DOCX",
                    name = "Microsoft Word (Open XML)",
                    description = "Microsoft Word (Open XML) file format.",
                    mime_type = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                    extension = ".docx",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("12ee019d-6102-4828-b0c3-00ef53941595"),
                    key = "xls",
                    label = "XLS",
                    name = "Microsoft Excel 97-2003",
                    description = "Microsoft Excel 97-2003 file format.",
                    mime_type = "application/vnd.ms-excel",
                    extension = ".xls",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("71d8ea38-900a-4ebc-9d13-31caf17544f1"),
                    key = "xlsx",
                    label = "XLSX",
                    name = "Microsoft Excel (Open XML)",
                    description = "Microsoft Excel (Open XML) file format.",
                    mime_type = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    extension = ".xlsx",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("bd7dde61-9f92-42d9-9e9e-146a773234e9"),
                    key = "ppt",
                    label = "PPT",
                    name = "PowerPoint Presentation",
                    description = "PowerPoint Presentation file format.",
                    mime_type = "application/vnd.ms-powerpoint",
                    extension = ".ppt",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("29eeddb3-b709-4d71-bbff-21091c52bb26"),
                    key = "pptx",
                    label = "PPTX",
                    name = "PowerPoint (Open XML)",
                    description = "PowerPoint (Open XML) file format.",
                    mime_type = "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                    extension = ".pptx",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("a10c24ce-4b9d-4007-8b92-51f8c8a615eb"),
                    key = "txt",
                    label = "TXT",
                    name = "Plain Text File",
                    description = "Plain Text File file format.",
                    mime_type = "text/plain",
                    extension = ".txt",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("36d5657d-801d-49ce-9f4b-ed7ea6192582"),
                    key = "csv",
                    label = "CSV",
                    name = "Comma Separated Values",
                    description = "Comma Separated Values file format.",
                    mime_type = "text/csv",
                    extension = ".csv",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("b05f39ac-c66e-470d-bba5-850c1b10d55f"),
                    key = "rtf",
                    label = "RTF",
                    name = "Rich Text Format",
                    description = "Rich Text Format file format.",
                    mime_type = "application/rtf",
                    extension = ".rtf",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("ebe9df37-84a6-42e4-b5bf-c097dba1c2d1"),
                    key = "odt",
                    label = "ODT",
                    name = "OpenDocument Text",
                    description = "OpenDocument Text file format.",
                    mime_type = "application/vnd.oasis.opendocument.text",
                    extension = ".odt",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("a2c99e82-bbd5-40fe-976a-83c8f81f18f0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("e8b33ff5-bdb7-4bc4-8ad8-347a71200714"),
                    key = "jpg",
                    label = "JPG",
                    name = "JPEG Image",
                    description = "Widely used compressed image format for digital photography.",
                    mime_type = "image/jpeg",
                    extension = ".jpg",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd37bba4-68d3-42f6-9bdf-c248c3d3972e"),
                    key = "jpeg",
                    label = "JPEG",
                    name = "JPEG Image",
                    description = "Alternative extension for JPG image format.",
                    mime_type = "image/jpeg",
                    extension = ".jpeg",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("c93fe653-33d0-45d8-9611-2d82eb6bd087"),
                    key = "png",
                    label = "PNG",
                    name = "Portable Network Graphics",
                    description = "Lossless image format commonly used for web graphics and UI design.",
                    mime_type = "image/png",
                    extension = ".png",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("62a3d8ae-81fa-4c8e-b2f6-41a2f90a7490"),
                    key = "gif",
                    label = "GIF",
                    name = "Graphics Interchange Format",
                    description = "Animated or static image format with limited color palette.",
                    mime_type = "image/gif",
                    extension = ".gif",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dbb4d630-4a41-4900-844c-d99483ac7237"),
                    key = "svg",
                    label = "SVG",
                    name = "Scalable Vector Graphics",
                    description = "Vector-based image format for scalable graphics.",
                    mime_type = "image/svg+xml",
                    extension = ".svg",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("52ed76e7-1614-47be-93f7-0f4df56c9a8a"),
                    key = "bmp",
                    label = "BMP",
                    name = "Bitmap Image File",
                    description = "Uncompressed raster image format mainly used in Windows systems.",
                    mime_type = "image/bmp",
                    extension = ".bmp",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("19dfb162-78e9-4b4f-9b45-2d4308ed746f"),
                    key = "tiff",
                    label = "TIFF",
                    name = "Tagged Image File Format",
                    description = "High-quality image format often used in publishing and scanning.",
                    mime_type = "image/tiff",
                    extension = ".tiff",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("04127520-7ef4-4cf1-8829-d70b7c3c0138"),
                    key = "webp",
                    label = "WEBP",
                    name = "WebP Image Format",
                    description = "Modern image format providing superior compression for web usage.",
                    mime_type = "image/webp",
                    extension = ".webp",
                    maximum_size = 16_777_216,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("c05c21be-3e27-4326-92c2-f1160c8a1501"),
                    key = "ico",
                    label = "ICO",
                    name = "Icon File",
                    description = "Used to store icons in Windows applications.",
                    mime_type = "image/x-icon",
                    extension = ".ico",
                    maximum_size = 1_048_576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("b382c1a1-0b1d-4b2c-97ad-77d5f4f43bfc"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 14, 10, 00), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000001"),
                    key = "mp4",
                    label = "MP4",
                    name = "MPEG-4 Video",
                    description = "Standard video format for streaming and mobile.",
                    mime_type = "video/mp4",
                    extension = ".mp4",
                    maximum_size = 524_288_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000002"),
                    key = "avi",
                    label = "AVI",
                    name = "Audio Video Interleave",
                    description = "Older format developed by Microsoft.",
                    mime_type = "video/x-msvideo",
                    extension = ".avi",
                    maximum_size = 2_097_152_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000003"),
                    key = "mkv",
                    label = "MKV",
                    name = "Matroska Video",
                    description = "Modern container format for high-quality video.",
                    mime_type = "video/x-matroska",
                    extension = ".mkv",
                    maximum_size = 2_097_152_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000004"),
                    key = "mov",
                    label = "MOV",
                    name = "Apple QuickTime Movie",
                    description = "Format used by Apple's QuickTime framework.",
                    mime_type = "video/quicktime",
                    extension = ".mov",
                    maximum_size = 1_073_741_824,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("40000000-0000-0000-0000-000000000005"),
                    key = "webm",
                    label = "WEBM",
                    name = "WebM Video",
                    description = "Open, royalty-free format designed for the web.",
                    mime_type = "video/webm",
                    extension = ".webm",
                    maximum_size = 524_288_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("c611b50f-662a-4a3b-a6f4-8b298fa33c3f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000001"),
                    key = "mp3",
                    label = "MP3",
                    name = "MPEG Audio Layer III",
                    description = "Widely used lossy audio format.",
                    mime_type = "audio/mpeg",
                    extension = ".mp3",
                    maximum_size = 104_857_600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000002"),
                    key = "wav",
                    label = "WAV",
                    name = "Waveform Audio File Format",
                    description = "Uncompressed audio format for high quality.",
                    mime_type = "audio/wav",
                    extension = ".wav",
                    maximum_size = 524_288_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000003"),
                    key = "flac",
                    label = "FLAC",
                    name = "Free Lossless Audio Codec",
                    description = "Lossless compression audio format.",
                    mime_type = "audio/flac",
                    extension = ".flac",
                    maximum_size = 524_288_000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000004"),
                    key = "aac",
                    label = "AAC",
                    name = "Advanced Audio Coding",
                    description = "Lossy audio format with better compression than MP3.",
                    mime_type = "audio/aac",
                    extension = ".aac",
                    maximum_size = 104_857_600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("50000000-0000-0000-0000-000000000005"),
                    key = "ogg",
                    label = "OGG",
                    name = "Ogg Vorbis Audio",
                    description = "Open-source lossy audio format.",
                    mime_type = "audio/ogg",
                    extension = ".ogg",
                    maximum_size = 104_857_600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("de5e9a6d-7ad0-4c40-a99a-1fa9876fa15f"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("61000000-0000-0000-0000-000000000001"),
                    key = "zip",
                    label = "ZIP",
                    name = "ZIP Archive",
                    description = "Widely used compressed archive format.",
                    mime_type = "application/zip",
                    extension = ".zip",
                    maximum_size = 1_073_741_824,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("61000000-0000-0000-0000-000000000002"),
                    key = "rar",
                    label = "RAR",
                    name = "RAR Archive",
                    description = "Popular proprietary compressed archive format.",
                    mime_type = "application/x-rar-compressed",
                    extension = ".rar",
                    maximum_size = 2_147_483_648,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("61000000-0000-0000-0000-000000000003"),
                    key = "7z",
                    label = "7Z",
                    name = "7-Zip Archive",
                    description = "High compression ratio archive format.",
                    mime_type = "application/x-7z-compressed",
                    extension = ".7z",
                    maximum_size = 3_221_225_472,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("61000000-0000-0000-0000-000000000004"),
                    key = "tar",
                    label = "TAR",
                    name = "Tape Archive",
                    description = "Unix archive file, often combined with compression.",
                    mime_type = "application/x-tar",
                    extension = ".tar",
                    maximum_size = 4_294_967_296,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("61000000-0000-0000-0000-000000000005"),
                    key = "gz",
                    label = "GZ",
                    name = "Gzip Compressed Archive",
                    description = "Compression format commonly used on Unix systems.",
                    mime_type = "application/gzip",
                    extension = ".gz",
                    maximum_size = 2_147_483_648,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("60e9e9d5-11dc-44e7-b62e-5ecf399fc381"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("d9800000-0000-0000-0000-000000000001"),
                    key = "ini",
                    label = "INI",
                    name = "Initialization File",
                    description = "Configuration file format for software and system settings.",
                    mime_type = "text/plain",
                    extension = ".ini",
                    maximum_size = 102_400,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("d9800000-0000-0000-0000-000000000002"),
                    key = "log",
                    label = "LOG",
                    name = "Log File",
                    description = "File used to record system or application events.",
                    mime_type = "text/plain",
                    extension = ".log",
                    maximum_size = 10_485_760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("d9800000-0000-0000-0000-000000000003"),
                    key = "env",
                    label = "ENV",
                    name = "Environment Variables File",
                    description = "File to define environment variables, often used in development.",
                    mime_type = "text/plain",
                    extension = ".env",
                    maximum_size = 51_200,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("d9800000-0000-0000-0000-000000000004"),
                    key = "sys",
                    label = "SYS",
                    name = "System File",
                    description = "Windows system file used by the operating system.",
                    mime_type = "application/octet-stream",
                    extension = ".sys",
                    maximum_size = 52_428_800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("d9800000-0000-0000-0000-000000000005"),
                    key = "dll",
                    label = "DLL",
                    name = "Dynamic Link Library",
                    description = "Library file containing code and data used by multiple programs.",
                    mime_type = "application/octet-stream",
                    extension = ".dll",
                    maximum_size = 104_857_600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("d98fd5b0-3b70-4428-b690-d6886d2bb40d"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("2f180000-0000-0000-0000-000000000001"),
                    key = "exe",
                    label = "EXE",
                    name = "Windows Executable",
                    description = "Standard executable file format used by Windows.",
                    mime_type = "application/vnd.microsoft.portable-executable",
                    extension = ".exe",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("2f180000-0000-0000-0000-000000000002"),
                    key = "msi",
                    label = "MSI",
                    name = "Microsoft Installer",
                    description = "Installer package used by Windows for software installation.",
                    mime_type = "application/x-msi",
                    extension = ".msi",
                    maximum_size = 104857600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("2f180000-0000-0000-0000-000000000003"),
                    key = "apk",
                    label = "APK",
                    name = "Android Package",
                    description = "Application package used by Android OS for installing mobile apps.",
                    mime_type = "application/vnd.android.package-archive",
                    extension = ".apk",
                    maximum_size = 104857600, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("2f180000-0000-0000-0000-000000000004"),
                    key = "sh",
                    label = "SH",
                    name = "Shell Script",
                    description = "Shell script used in Unix/Linux systems to execute commands.",
                    mime_type = "application/x-sh",
                    extension = ".sh",
                    maximum_size = 1048576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("2f180000-0000-0000-0000-000000000005"),
                    key = "app",
                    label = "APP",
                    name = "Mac Application Bundle",
                    description = "Executable bundle used in macOS systems.",
                    mime_type = "application/octet-stream",
                    extension = ".app",
                    maximum_size = 157286400,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("2f181b9f-7a31-41bb-8f17-7418f6944a7b"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000001"),
                    key = "cs",
                    label = "C#",
                    name = "C# Source Code",
                    description = "C# programming language source file.",
                    mime_type = "text/plain",
                    extension = ".cs",
                    maximum_size = 524288,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000002"),
                    key = "js",
                    label = "JavaScript",
                    name = "JavaScript File",
                    description = "JavaScript scripting language file.",
                    mime_type = "application/javascript",
                    extension = ".js",
                    maximum_size = 1048576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000003"),
                    key = "html",
                    label = "HTML",
                    name = "HTML Document",
                    description = "HyperText Markup Language file used for web pages.",
                    mime_type = "text/html",
                    extension = ".html",
                    maximum_size = 524288,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000004"),
                    key = "py",
                    label = "Python",
                    name = "Python Script",
                    description = "Python programming language script file.",
                    mime_type = "text/x-python",
                    extension = ".py",
                    maximum_size = 1048576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000005"),
                    key = "php",
                    label = "PHP",
                    name = "PHP Script",
                    description = "PHP Hypertext Preprocessor server-side scripting file.",
                    mime_type = "application/x-httpd-php",
                    extension = ".php",
                    maximum_size = 1048576, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000006"),
                    key = "ts",
                    label = "TypeScript",
                    name = "TypeScript File",
                    description = "TypeScript superset of JavaScript with typing.",
                    mime_type = "application/typescript",
                    extension = ".ts",
                    maximum_size = 1048576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("70f90000-0000-0000-0000-000000000007"),
                    key = "json",
                    label = "JSON",
                    name = "JSON Data",
                    description = "JavaScript Object Notation structured data file.",
                    mime_type = "application/json",
                    extension = ".json",
                    maximum_size = 2097152, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("70f9189f-6f15-421f-a9c9-147a0c4e40c7"),
                    created_at = new DateTimeOffset(new DateTime(2025, 05, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dc6c0000-0000-0000-0000-000000000001"),
                    key = "db",
                    label = "Database",
                    name = "Generic Database File",
                    description = "Generic binary database container file.",
                    mime_type = "application/octet-stream",
                    extension = ".db",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dc6c0000-0000-0000-0000-000000000002"),
                    key = "sql",
                    label = "SQL",
                    name = "SQL Dump File",
                    description = "Structured query language file used for database schema and data export.",
                    mime_type = "application/sql",
                    extension = ".sql",
                    maximum_size = 5242880,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dc6c0000-0000-0000-0000-000000000003"),
                    key = "json",
                    label = "JSON",
                    name = "JSON Data File",
                    description = "JavaScript Object Notation file used for structured data.",
                    mime_type = "application/json",
                    extension = ".json",
                    maximum_size = 2097152,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dc6c0000-0000-0000-0000-000000000004"),
                    key = "xml",
                    label = "XML",
                    name = "XML File",
                    description = "Extensible Markup Language data file used to store structured data.",
                    mime_type = "application/xml",
                    extension = ".xml",
                    maximum_size = 2097152,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("dc6c0000-0000-0000-0000-000000000005"),
                    key = "csv",
                    label = "CSV",
                    name = "CSV File",
                    description = "Comma Separated Values file used to store tabular data.",
                    mime_type = "text/csv",
                    extension = ".csv",
                    maximum_size = 3145728,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("dc6c4f2a-cf57-4a4b-86b2-51e368b0d0b3"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8f1e0000-0000-0000-0000-000000000001"),
                    key = "iso",
                    label = "ISO",
                    name = "ISO Disk Image",
                    description = "Optical disc image of an entire CD, DVD, or Blu-ray.",
                    mime_type = "application/x-iso9660-image",
                    extension = ".iso",
                    maximum_size = 10737418240, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8f1e0000-0000-0000-0000-000000000002"),
                    key = "img",
                    label = "IMG",
                    name = "IMG Disk Image",
                    description = "Raw disk image used for drives and SD cards.",
                    mime_type = "application/octet-stream",
                    extension = ".img",
                    maximum_size = 5368709120,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8f1e0000-0000-0000-0000-000000000003"),
                    key = "vhd",
                    label = "VHD",
                    name = "Virtual Hard Disk",
                    description = "Virtual hard drive format used by Microsoft virtualization.",
                    mime_type = "application/octet-stream",
                    extension = ".vhd",
                    maximum_size = 17179869184,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8f1e0000-0000-0000-0000-000000000004"),
                    key = "dmg",
                    label = "DMG",
                    name = "Apple Disk Image",
                    description = "Mountable disk image used by macOS.",
                    mime_type = "application/x-apple-diskimage",
                    extension = ".dmg",
                    maximum_size = 4294967296,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("8f1e0000-0000-0000-0000-000000000005"),
                    key = "vmdk",
                    label = "VMDK",
                    name = "VMware Disk Image",
                    description = "Virtual Machine Disk format used by VMware products.",
                    mime_type = "application/octet-stream",
                    extension = ".vmdk",
                    maximum_size = 21474836480,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("8f1e33ff-1d5e-4b3e-84f8-1e922e3be39a"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("39b70000-0000-0000-0000-000000000001"),
                    key = "ttf",
                    label = "TTF",
                    name = "TrueType Font",
                    description = "Scalable font format developed by Apple and Microsoft.",
                    mime_type = "font/ttf",
                    extension = ".ttf",
                    maximum_size = 10485760, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("39b70000-0000-0000-0000-000000000002"),
                    key = "otf",
                    label = "OTF",
                    name = "OpenType Font",
                    description = "Advanced font format developed by Microsoft and Adobe.",
                    mime_type = "font/otf",
                    extension = ".otf",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("39b70000-0000-0000-0000-000000000003"),
                    key = "woff",
                    label = "WOFF",
                    name = "Web Open Font Format",
                    description = "Font format optimized for web usage with compression.",
                    mime_type = "font/woff",
                    extension = ".woff",
                    maximum_size = 5242880, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("39b70000-0000-0000-0000-000000000004"),
                    key = "woff2",
                    label = "WOFF2",
                    name = "Web Open Font Format 2",
                    description = "Improved version of WOFF with better compression for web fonts.",
                    mime_type = "font/woff2",
                    extension = ".woff2",
                    maximum_size = 5242880, 
                    is_deprecated = false,
                    file_category_id = Guid.Parse("39b7ed68-ecb6-4c5e-b28c-eec22be967c0"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("7db70000-0000-0000-0000-000000000001"),
                    key = "epub",
                    label = "EPUB",
                    name = "Electronic Publication",
                    description = "Open standard eBook format widely supported on many devices.",
                    mime_type = "application/epub+zip",
                    extension = ".epub",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("7db77137-1df3-4a42-a80e-f66e8b080be1"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("7db70000-0000-0000-0000-000000000002"),
                    key = "mobi",
                    label = "MOBI",
                    name = "Mobipocket eBook",
                    description = "Older eBook format developed by Mobipocket, supported by Kindle.",
                    mime_type = "application/x-mobipocket-ebook",
                    extension = ".mobi",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("7db77137-1df3-4a42-a80e-f66e8b080be1"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("7db70000-0000-0000-0000-000000000003"),
                    key = "azw",
                    label = "AZW",
                    name = "Amazon Kindle AZW",
                    description = "Proprietary eBook format used on Amazon Kindle devices.",
                    mime_type = "application/vnd.amazon.ebook",
                    extension = ".azw",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("7db77137-1df3-4a42-a80e-f66e8b080be1"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000001"),
                    key = "psd",
                    label = "PSD",
                    name = "Photoshop Document",
                    description = "Adobe Photoshop layered image file used for graphic design.",
                    mime_type = "image/vnd.adobe.photoshop",
                    extension = ".psd",
                    maximum_size = 209715200,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000002"),
                    key = "ai",
                    label = "AI",
                    name = "Adobe Illustrator",
                    description = "Vector graphic file created by Adobe Illustrator.",
                    mime_type = "application/postscript",
                    extension = ".ai",
                    maximum_size = 104857600,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000003"),
                    key = "fig",
                    label = "FIG",
                    name = "Figma Design File",
                    description = "Design file exported from Figma design tool.",
                    mime_type = "application/octet-stream",
                    extension = ".fig",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000004"),
                    key = "xd",
                    label = "XD",
                    name = "Adobe XD File",
                    description = "User interface design file created using Adobe XD.",
                    mime_type = "application/vnd.adobe.xd",
                    extension = ".xd",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000005"),
                    key = "dwg",
                    label = "DWG",
                    name = "AutoCAD Drawing",
                    description = "CAD drawing file used in AutoCAD for 2D and 3D design.",
                    mime_type = "application/acad",
                    extension = ".dwg",
                    maximum_size = 157286400,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("fd3f0000-0000-0000-0000-000000000006"),
                    key = "blend",
                    label = "BLEND",
                    name = "Blender File",
                    description = "3D model file created using Blender software.",
                    mime_type = "application/x-blender",
                    extension = ".blend",
                    maximum_size = 524288000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("fd3ff760-5fc9-4ab2-b1f3-d110db8d1c20"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("edc70000-0000-0000-0000-000000000001"),
                    key = "html",
                    label = "HTML",
                    name = "HyperText Markup Language",
                    description = "Standard markup language for documents designed to be displayed in a web browser.",
                    mime_type = "text/html",
                    extension = ".html",
                    maximum_size = 5242880,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("edc70000-0000-0000-0000-000000000002"),
                    key = "css",
                    label = "CSS",
                    name = "Cascading Style Sheets",
                    description = "Style sheet language used for describing the presentation of a document written in HTML or XML.",
                    mime_type = "text/css",
                    extension = ".css",
                    maximum_size = 1048576,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("edc70000-0000-0000-0000-000000000003"),
                    key = "js",
                    label = "JS",
                    name = "JavaScript",
                    description = "Lightweight, interpreted programming language with first-class functions.",
                    mime_type = "application/javascript",
                    extension = ".js",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("edc70000-0000-0000-0000-000000000004"),
                    key = "ts",
                    label = "TS",
                    name = "TypeScript",
                    description = "A typed superset of JavaScript that compiles to plain JavaScript.",
                    mime_type = "application/typescript",
                    extension = ".ts",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("edc70000-0000-0000-0000-000000000005"),
                    key = "php",
                    label = "PHP",
                    name = "PHP Hypertext Preprocessor",
                    description = "General-purpose scripting language especially suited to web development.",
                    mime_type = "application/x-httpd-php",
                    extension = ".php",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("edc71b6e-cf84-44aa-b18e-7c7852a5d3a9"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("eef90000-0000-0000-0000-000000000001"),
                    key = "pak",
                    label = "PAK",
                    name = "Game Package File",
                    description = "Package file used in various games to store data such as textures, models, and sounds.",
                    mime_type = "application/octet-stream",
                    extension = ".pak",
                    maximum_size = 524288000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("eef901cf-16c7-43fc-b22e-456f8794a032"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("eef90000-0000-0000-0000-000000000002"),
                    key = "asset",
                    label = "ASSET",
                    name = "Unity Asset File",
                    description = "Used in Unity game engine to store various types of assets for games and applications.",
                    mime_type = "application/octet-stream",
                    extension = ".asset",
                    maximum_size = 262144000,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("eef901cf-16c7-43fc-b22e-456f8794a032"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("eef90000-0000-0000-0000-000000000003"),
                    key = "res",
                    label = "RES",
                    name = "Resource File",
                    description = "Used to store app and game resources such as bitmaps, icons, and strings.",
                    mime_type = "application/octet-stream",
                    extension = ".res",
                    maximum_size = 52428800,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("eef901cf-16c7-43fc-b22e-456f8794a032"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                },
                new FileFormat
                {
                    id = Guid.Parse("eef90000-0000-0000-0000-000000000004"),
                    key = "sav",
                    label = "SAV",
                    name = "Game Save File",
                    description = "File used to store saved game data and user progress in video games.",
                    mime_type = "application/octet-stream",
                    extension = ".sav",
                    maximum_size = 10485760,
                    is_deprecated = false,
                    file_category_id = Guid.Parse("eef901cf-16c7-43fc-b22e-456f8794a032"),
                    created_at = new DateTimeOffset(new DateTime(2025, 03, 25, 13, 45, 23), TimeSpan.Zero)
                }
            );
        }
    }
}
