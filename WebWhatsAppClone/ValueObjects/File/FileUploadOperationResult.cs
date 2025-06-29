namespace WebWhatsAppClone.ValueObjects.File
{
    public class FileUploadOperationResult
    {
        public string original_file_name { get; set; } = string.Empty;
        public string stored_file_name { get; set; } = string.Empty;
        public string extension { get; set; } = string.Empty;
        public string mime_type { get; set; } = string.Empty;
        public long size { get; set; }
        public string relative_path { get; set; } = string.Empty;
        public string storage_path { get; set; } = string.Empty;
        public string public_url { get; set; } = string.Empty;
        public bool is_success { get; set; }
    }
}
