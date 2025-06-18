namespace WebWhatsAppClone.DTOs.Api
{
    public class ApiResponse<TData>
    {
        public string message { get; set; } = string.Empty;
        public bool is_success { get; set; }
        public int status_code { get; set; }
        public TData data { get; set; }
    }
}
