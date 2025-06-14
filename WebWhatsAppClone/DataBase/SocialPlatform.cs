using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase
{
    public class SocialPlatform : AuditableEntity<Guid, DateTimeOffset>
    {
        public string platform_name { get; set; } = string.Empty;
        public string label { get; set; } = string.Empty;
        public string owner_company { get; set; } = string.Empty;
    }
}
