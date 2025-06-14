using WebWhatsAppClone.DataBase.Base;
using WebWhatsAppClone.Enums;

namespace WebWhatsAppClone.DataBase
{
    public class User : AuditableEntity<Guid, DateTimeOffset>
    {
        public string name { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string display_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string phone_number { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public string about { get; set; } = string.Empty;
        public DateTimeOffset date_of_birth { get; set; }
        public Role role { get; set; } = Role.User;
        public Gender gender { get; set; }
    }
}
