using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class File : AuditableEntity<Guid, DateTimeOffset>
    {
        public string original_file_name { get; set; } = string.Empty;
        public string stored_file_name { get; set; } = string.Empty;
        public string extension { get; set; } = string.Empty;
        public string mime_type { get; set; } = string.Empty;
        public long size { get; set; }
        public string relative_path { get; set; } = string.Empty;
        public string storage_path { get; set; } = string.Empty;
        public string public_url { get; set; } = string.Empty;
        public bool is_readonly { get; set; } = false;
        public Guid file_format_id { get; set; }
        public FileFormat file_format { get; set; }
    }
}
