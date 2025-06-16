using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class FileFormat : AuditableEntity<Guid, DateTimeOffset>
    {
        public string key { get; set; } = string.Empty;
        public string label { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string mime_type { get; set; } = string.Empty;
        public string extension { get; set; } = string.Empty;
        public long maximum_size { get; set; }
        public bool is_deprecated { get; set; }
        public FileCategory file_category { get; set; }
        public Guid file_category_id { get; set; }
    }
}
