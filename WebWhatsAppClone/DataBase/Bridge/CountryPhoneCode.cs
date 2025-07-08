using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Bridge
{
    public class CountryPhoneCode
    {
        public Guid phone_code_id { get; set; }
        public PhoneCode phone_code { get; set; }
        public Guid country_id { get; set; }
        public Country country { get; set; }
    }
}
