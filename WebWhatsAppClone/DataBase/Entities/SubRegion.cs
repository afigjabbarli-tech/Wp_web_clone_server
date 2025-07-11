﻿using WebWhatsAppClone.DataBase.Base;
using WebWhatsAppClone.DataBase.Bridge;

namespace WebWhatsAppClone.DataBase.Entities
{
    public class SubRegion : AuditableEntity<Guid, DateTimeOffset>
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
        public Region region { get; set; }
        public Guid region_id { get; set; }
        public IList<SubRegionCountry> sub_region_countries { get; set; }
    }
}
