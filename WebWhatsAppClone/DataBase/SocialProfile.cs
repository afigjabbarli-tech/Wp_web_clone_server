using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase
{
    public class SocialProfile : AuditableEntity<Guid, DateTimeOffset>
    {
        public string label { get; set; } = string.Empty;
        public string link { get; set; } = string.Empty;
    }
}
