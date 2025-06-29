using System;
using System.Text;
using WebWhatsAppClone.Services.Abstracts;
using WebWhatsAppClone.ValueObjects.File;

namespace WebWhatsAppClone.Services.Concretes
{
    public class FileManagementService : IFileManagementService
    {
        private readonly Random _random;
        public FileManagementService()
        {
            _random = new Random();
        }
        public async Task<FileUploadOperationResult> UploadAsync(string entity_name, string file_category, string file_format, IFormFile file, int file_name_char_count = 128)
        {
            return new FileUploadOperationResult
            {

            };
        }
        private string GenerateUniqueFileIdentifier(int length)
        {
            char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] digits = "0123456789".ToCharArray();
            var sb = new StringBuilder();
            string stage = "upper";

            for (int i = 0; i < length; i++)
            {
                switch (stage)
                {
                    case "upper":
                        sb.Append(upper[GenerateRandomNumber(0, upper.Length)]);
                        stage = "lower";
                        break;
                    case "lower":
                        sb.Append(lower[GenerateRandomNumber(0, lower.Length)]);
                        stage = "number";
                        break;
                    case "number":
                        sb.Append(digits[GenerateRandomNumber(0, digits.Length)]);
                        stage = "upper";
                        break;
                }
            }

            return sb.ToString();
        }
        private int GenerateRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
