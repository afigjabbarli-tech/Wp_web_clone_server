namespace WebWhatsAppClone.DTOs.Validation
{
    public class ValidationErrorDTO
    {
        public string field_name { get; set; } = string.Empty;
        public string attempted_value { get; set; } = string.Empty;
        public string error_message { get; set; } = string.Empty;
        public string suggested_value { get; set; } = string.Empty;
    }
}
