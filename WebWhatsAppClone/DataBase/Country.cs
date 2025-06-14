using WebWhatsAppClone.DataBase.Base;

namespace WebWhatsAppClone.DataBase
{
    public class Country : AuditableEntity<Guid, DateTimeOffset>
    {
        public string name { get; set; } = string.Empty;         
        public string name_native { get; set; } = string.Empty;    
        public string iso2 { get; set; } = string.Empty;        
        public string iso3 { get; set; } = string.Empty;           
        public string numeric_code { get; set; } = string.Empty;  
        public string phone_code { get; set; } = string.Empty;       
        public string currency_code { get; set; } = string.Empty;    
        public string currency_name { get; set; } = string.Empty;    
        public string currency_symbol { get; set; } = string.Empty;
        public string capital { get; set; } = string.Empty;        
        public string region { get; set; } = string.Empty;    
        public string subregion { get; set; } = string.Empty;
        public double latitude { get; set; }    
        public double longitude { get; set; }
    }
}
