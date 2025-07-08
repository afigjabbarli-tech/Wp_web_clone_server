using WebWhatsAppClone.DataBase.Base;
using WebWhatsAppClone.DataBase.Bridge;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class PhoneCode : AuditableEntity<Guid, DateTimeOffset>
    {
        public string code { get; set; } = string.Empty;
        public IList<CountryPhoneCode> country_phone_codes { get; set; }
    }
}
