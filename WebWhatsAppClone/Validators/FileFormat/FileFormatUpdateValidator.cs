using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.FileFormat;

namespace WebWhatsAppClone.Validators.FileFormat
{
    public class FileFormatUpdateValidator : AbstractValidator<FileFormatUpdateDTO>
    {
        public FileFormatUpdateValidator()
        {
            RuleFor(data => data.key)
                .NotEmpty()
                    .WithMessage("The field named Key cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "examplekey" })
                .MaximumLength(10)
                    .WithMessage("The field named Key must be at most 10 characters long!")
                    .WithState(_ => new { SuggestedValue = "examplekey" })
                .Matches(new Regex("^[a-z]+$"))
                    .WithMessage("The field named Key must contain only lowercase letters without spaces, digits or special characters!")
                    .WithState(_ => new { SuggestedValue = "examplekey" });

            RuleFor(data => data.label)
                .NotEmpty()
                    .WithMessage("The field named Label cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "EXAMPLE" })
                .MaximumLength(10)
                    .WithMessage("The field named Label must be at most 10 characters long!")
                    .WithState(_ => new { SuggestedValue = "EXAMPLE" })
                .Matches(new Regex("^[A-Z]+$"))
                    .WithMessage("The field named Label must contain only uppercase letters without spaces, digits or special characters!")
                    .WithState(_ => new { SuggestedValue = "EXAMPLE" });

            RuleFor(data => data.name)
                .NotEmpty()
                    .WithMessage("The field named Name cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Example Name" })
                .MaximumLength(50)
                    .WithMessage("The field named Name must be at most 50 characters long!")
                    .WithState(_ => new { SuggestedValue = "Example Name" });

            RuleFor(data => data.description)
                .NotEmpty()
                    .WithMessage("The field named Description cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "This is a detailed description with at least 25 characters." })
                .MinimumLength(25)
                    .WithMessage("The field named Description must be at least 25 characters long!")
                    .WithState(_ => new { SuggestedValue = "This is a detailed description with at least 25 characters." })
                .MaximumLength(250)
                    .WithMessage("The field named Description must be at most 250 characters long!")
                    .WithState(_ => new { SuggestedValue = "This is a detailed description with at most 250 characters." });

            RuleFor(data => data.mime_type)
                .NotEmpty()
                    .WithMessage("The field named Mime type cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "image/png" })
                .MinimumLength(5)
                    .WithMessage("The field named Mime type must be at least 5 characters long!")
                    .WithState(_ => new { SuggestedValue = "image/png" })
                .MaximumLength(50)
                    .WithMessage("The field named Mime type must be at most 50 characters long!")
                    .WithState(_ => new { SuggestedValue = "image/png" })
                .Matches(new Regex(@"^[a-zA-Z]+\/[a-zA-Z0-9\.\-\+]+$"))
                    .WithMessage("The field named Mime type must be in a valid format like 'type/subtype' (e.g. 'image/png').")
                    .WithState(_ => new { SuggestedValue = "image/png" });

            RuleFor(data => data.extension)
                .NotEmpty()
                    .WithMessage("The field named Extension cannot be empty!")
                    .WithState(_ => new { SuggestedValue = ".png" })
                .MaximumLength(10)
                    .WithMessage("The field named Extension must be at most 10 characters long!")
                    .WithState(_ => new { SuggestedValue = ".png" })
                .Matches(new Regex(@"^\.[a-z]+$"))
                    .WithMessage("The field named Extension must start with a dot followed by only lowercase letters.")
                    .WithState(_ => new { SuggestedValue = ".png" });

            RuleFor(data => data.maximum_size)
                .GreaterThan(0)
                    .WithMessage("The field named Maximum size must be greater than 0!")
                    .WithState(_ => new { SuggestedValue = 1024 });

            RuleFor(data => data.file_category_id)
                .NotEmpty()
                    .WithMessage("File category ID must be provided.")
                    .WithState(_ => new { SuggestedValue = Guid.Parse("00000000-0000-0000-0000-000000000000") });

            RuleFor(data => data.is_deprecated)
                .Must(x => x == true || x == false)
                    .WithMessage("The field named Is Deprecated must be a boolean value (true or false).")
                    .WithState(_ => new { SuggestedValue = false });
        }
    }
}
