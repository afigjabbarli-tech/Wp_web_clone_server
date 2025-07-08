namespace WebWhatsAppClone.DTOs.Country
{
    public class CountryCreateDTO
    {
        public string name { get; set; } = string.Empty;
        public string key { get; set; } = string.Empty;
        public string official_name { get; set; } = string.Empty;
        public string native_name { get; set; } = string.Empty;
        public string iso_alpha2_code { get; set; } = string.Empty;
        public string iso_alpha3_code { get; set; } = string.Empty;
        public int? iso_numeric { get; set; }
        public string tld { get; set; } = string.Empty;
        public string capital { get; set; } = string.Empty;
        public string currency_code { get; set; } = string.Empty;
        public string currency_name { get; set; } = string.Empty;
        public double? area_km2 { get; set; }
        public long? population { get; set; }
        public double population_density { get; set; }
        public string demonym { get; set; } = string.Empty;
        public Guid[] sub_region_ids { get; set; }
    }
}
