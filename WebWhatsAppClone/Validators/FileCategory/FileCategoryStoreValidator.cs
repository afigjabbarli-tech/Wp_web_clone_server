using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.FileCategory;

namespace WebWhatsAppClone.Validators.FileCategory
{
    public class FileCategoryStoreValidator : AbstractValidator<FileCategoryCreateDTO>
    {
        public FileCategoryStoreValidator()
        {
            RuleFor(data => data.key)
                .NotNull()
                    .WithMessage("The field named Key must have a value!")
                    .WithState(_ => new { SuggestedValue = "document" })
                .NotEmpty()
                    .WithMessage("The field named Key cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "document" })
                .MaximumLength(20)
                    .WithMessage("The field named Key must be at most 20 characters long!")
                    .WithState(_ => new { SuggestedValue = "document" })
                .Matches(new Regex(@"^[a-z\-]+$"))
                    .WithMessage("The field named Key must contain only lowercase letters and hyphens (e.g. 'disk-image').")
                    .WithState(_ => new { SuggestedValue = "document" });

            RuleFor(data => data.label)
                .NotNull()
                    .WithMessage("The field named Label must have a value!")
                    .WithState(_ => new { SuggestedValue = "Document" })
                .NotEmpty()
                    .WithMessage("The field named Label cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Document" })
                .MaximumLength(20)
                    .WithMessage("The field named Label must be at most 20 characters long!")
                    .WithState(_ => new { SuggestedValue = "Document" })
                .Matches(new Regex(@"^[A-Z][a-zA-Z\s&]*$"))
                    .WithMessage("The field named Label must start with an uppercase letter and contain only letters, spaces or ampersands.")
                    .WithState(_ => new { SuggestedValue = "Document" });

            RuleFor(data => data.name)
                .NotNull()
                    .WithMessage("The field named Name must have a value!")
                    .WithState(_ => new { SuggestedValue = "Document Files" })
                .NotEmpty()
                    .WithMessage("The field named Name cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Document Files" })
                .MaximumLength(50)
                    .WithMessage("The field named Name must be at most 50 characters long!")
                    .WithState(_ => new { SuggestedValue = "Document Files" });

            RuleFor(data => data.description)
                .NotNull()
                    .WithMessage("The field named Description must have a value!")
                    .WithState(_ => new { SuggestedValue = "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files." })
                .NotEmpty()
                    .WithMessage("The field named Description cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files." })
                .MinimumLength(25)
                    .WithMessage("The field named Description must be at least 25 characters long!")
                    .WithState(_ => new { SuggestedValue = "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files." })
                .MaximumLength(250)
                    .WithMessage("The field named Description must be at most 250 characters long!")
                    .WithState(_ => new { SuggestedValue = "Office documents such as Word, Excel, PowerPoint, PDF, and plain text files." });
        }
    }
}
