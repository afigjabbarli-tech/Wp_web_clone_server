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

            RuleFor(data => data.name)
                .NotNull().WithMessage("The field named Name must have a value!")
                .NotEmpty().WithMessage("The field named Name cannot be empty!")
                .MaximumLength(50).WithMessage("The field named Name must be at most 50 characters long!");

            RuleFor(data => data.description)
                .NotNull().WithMessage("The field named Description must have a value!")
                .NotEmpty().WithMessage("The field named Description cannot be empty!")
                .MinimumLength(25).WithMessage("The field named Description must be at least 25 characters long!")
                .MaximumLength(250).WithMessage("The field named Description must be at most 250 characters long!");

            RuleFor(data => data.mime_type)
                .NotNull().WithMessage("The field named Mime type must have a value!")
                .NotEmpty().WithMessage("The field named Mime type cannot be empty!")
                .MinimumLength(5).WithMessage("The field named Mime type must be at least 5 characters long!")
                .MaximumLength(50).WithMessage("The field named Mime type must be at most 50 characters long!")
                .Matches(new Regex(@"^[a-zA-Z]+\/[a-zA-Z0-9\.\-\+]+$"))
                .WithMessage("The field named Mime type must be in a valid format like 'type/subtype' (e.g. 'image/png').");

            RuleFor(data => data.extension)
                .NotNull().WithMessage("The field named Extension must have a value!")
                .NotEmpty().WithMessage("The field named Extension cannot be empty!")
                .MaximumLength(10).WithMessage("The field named Extension must be at most 10 characters long!")
                .Matches(new Regex(@"^\.[a-z]+$"))
                .WithMessage("The field named Extension must start with a dot followed by only lowercase letters.");

            RuleFor(data => data.maximum_size)
                .NotNull().WithMessage("The field named Maximum size must have a value!")
                .GreaterThan(0).WithMessage("The field named Maximum size must be greater than 0!");
        }
    }
}
