using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class Country : AuditableEntity<Guid, DateTimeOffset>
    {
        public string name { get; set; } = string.Empty;
        public string official_name { get; set; } = string.Empty;
        public string native_name { get; set; } = string.Empty;
        public string iso2code { get; set; } = string.Empty;
        public string iso3code { get; set; } = string.Empty;
        public int? numeric_code { get; set; }
        public string tld { get; set; } = string.Empty;
        public string capital { get; set; } = string.Empty;
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public double? area_km2 { get; set; }
        public long? population { get; set; }
        public string demonym { get; set; } = string.Empty;
    }
}
