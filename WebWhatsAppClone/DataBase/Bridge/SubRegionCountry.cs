using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase.Bridge
{
    public class SubRegionCountry
    {
        public Guid sub_region_id { get; set; }
        public SubRegion sub_region { get; set; }  
        public Guid country_id { get; set; }    
        public Country country { get; set; }
    }
}
