using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.Validators.FileFormat
{
    public class FileFormatValidator : AbstractValidator<FileFormatCreateDTO>
    {
        public FileFormatValidator()
        {
            RuleFor(data => data.key)
                .NotNull().WithMessage("The field named Key must have a value!")
                .NotEmpty().WithMessage("The field named Key cannot be empty!")
                .MaximumLength(10).WithMessage("The field named Key must be at most 10 characters long!")
                .Matches(new Regex("^[a-z]+$")).WithMessage("The field named Key must contain only lowercase letters without spaces, digits or special characters!");

            RuleFor(data => data.label)
                .NotNull().WithMessage("The field named Label must have a value!")
                .NotEmpty().WithMessage("The field named Label cannot be empty!")
                .MaximumLength(10).WithMessage("The field named Label must be at most 10 characters long!")
                .Matches(new Regex("^[A-Z]+$")).WithMessage("The field named Label must contain only uppercase letters without spaces, digits or special characters!");
        }
    }
}
