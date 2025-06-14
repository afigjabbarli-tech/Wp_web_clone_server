using System.Diagnostics.Contracts;

namespace WebWhatsAppClone.DTOs.Country
{
    public class QueryParams
    {
        public int current_page { get; set; }
        public int page_size { get; set; }
        public string view_status { get; set; } = string.Empty;
        public string search_single { get; set; } = string.Empty;
        public string search_all { get; set; } = string.Empty;
        public string view_type { get; set; } = string.Empty;
        public string column_name { get; set; } = string.Empty;
        public List<SortOption> sort_options { get; set; } = new List<SortOption>();
        public List<FilterOption> filter_options { get; set; } = new List<FilterOption>();

    }
}
