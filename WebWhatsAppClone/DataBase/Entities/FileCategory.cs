using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class FileCategory : AuditableEntity<Guid, DateTimeOffset>
    {
        public string key { get; set; } = string.Empty;     
        public string label { get; set; } = string.Empty;    
        public string name { get; set; } = string.Empty;     
        public string description { get; set; } = string.Empty;
    }
}
