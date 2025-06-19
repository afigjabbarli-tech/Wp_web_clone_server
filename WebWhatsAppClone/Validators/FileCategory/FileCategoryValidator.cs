using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.FileCategory;

namespace WebWhatsAppClone.Validators.FileCategory
{
    public class FileCategoryValidator : AbstractValidator<FileCategoryCreateDTO>
    {
        public FileCategoryValidator()
        {
            RuleFor(data => data.key)
                .NotNull().WithMessage("The field named Key must have a value!")
                .NotEmpty().WithMessage("The field named Key cannot be empty!")
                .MaximumLength(20).WithMessage("The field named Key must be at most 20 characters long!")
                .Matches(new Regex(@"^[a-z\-]+$"))
                .WithMessage("The field named Key must contain only lowercase letters and hyphens (e.g. 'disk-image').");

            RuleFor(data => data.label)
                .NotNull().WithMessage("The field named Label must have a value!")
                .NotEmpty().WithMessage("The field named Label cannot be empty!")
                .MaximumLength(20).WithMessage("The field named Label must be at most 20 characters long!")
                .Matches(new Regex(@"^[A-Z][a-zA-Z\s&]*$"))
                .WithMessage("The field named Label must start with an uppercase letter and contain only letters, spaces or ampersands.");

            RuleFor(data => data.name)
                .NotNull().WithMessage("The field named Name must have a value!")
                .NotEmpty().WithMessage("The field named Name cannot be empty!")
                .MaximumLength(50).WithMessage("The field named Name must be at most 50 characters long!");

            RuleFor(data => data.description)
                .NotNull().WithMessage("The field named Description must have a value!")
                .NotEmpty().WithMessage("The field named Description cannot be empty!")
                .MinimumLength(25).WithMessage("The field named Description must be at least 25 characters long!")
                .MaximumLength(250).WithMessage("The field named Description must be at most 250 characters long!");
        }
    }
}
