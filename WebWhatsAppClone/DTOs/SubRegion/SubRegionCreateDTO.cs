﻿namespace WebWhatsAppClone.DTOs.SubRegion
{
    public class SubRegionCreateDTO
    {
        public string key { get; set; } = string.Empty;
        public string label { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string geo_code { get; set; } = string.Empty;
        public double area_km2 { get; set; }
        public long population { get; set; }
        public int number_of_countries { get; set; }
        public string largest_country { get; set; } = string.Empty;
        public string smallest_country { get; set; } = string.Empty;
        public string most_populous_country { get; set; } = string.Empty;
        public double? population_density { get; set; }
        public string description { get; set; } = string.Empty;
        public Guid region_id { get; set; }
    }
}
