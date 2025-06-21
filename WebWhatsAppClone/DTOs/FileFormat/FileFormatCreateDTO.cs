namespace WebWhatsAppClone.DTOs.FileFormat
{
    public class FileFormatCreateDTO
    {
        public string key { get; set; } = string.Empty;
        public string label { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string mime_type { get; set; } = string.Empty;
        public string extension { get; set; } = string.Empty;
        public long maximum_size { get; set; }
        public Guid file_category_id { get; set; }
    }
}
