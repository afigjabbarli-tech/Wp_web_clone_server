using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase
{
    public class UserSocialProfile : AuditableEntity<Guid, DateTimeOffset>
    {
        public string label { get; set; } = string.Empty;
        public string link { get; set; } = string.Empty;
    }
}
