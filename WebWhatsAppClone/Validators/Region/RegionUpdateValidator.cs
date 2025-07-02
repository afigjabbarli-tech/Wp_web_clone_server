using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.Region;

namespace WebWhatsAppClone.Validators.Region
{
    public class RegionUpdateValidator : AbstractValidator<RegionUpdateDTO>
    {
        public RegionUpdateValidator()
        {
            RuleFor(data => data.key)
            .NotNull().WithMessage("The field named Key must have a value!")
            .WithState(_ => new { SuggestedValue = "naf" })
            .NotEmpty().WithMessage("The field named Key cannot be empty!")
            .WithState(_ => new { SuggestedValue = "naf" })
            .MaximumLength(10).WithMessage("The field named Key must be at most 10 characters long!")
            .WithState(_ => new { SuggestedValue = "naf" })
            .Matches(new Regex("^[a-z]+$"))
            .WithMessage("The field named Key must contain only lowercase letters without spaces, digits or special characters!")
            .WithState(_ => new { SuggestedValue = "naf" });

            RuleFor(data => data.label)
                .NotNull().WithMessage("The field named Label must have a value!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" })
                .NotEmpty().WithMessage("The field named Label cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" })
                .MaximumLength(50).WithMessage("The field named Label must be at most 50 characters long!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                .WithMessage("The field named Label must contain only letters and spaces (no digits or special characters)!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" });

            RuleFor(data => data.name)
                .NotNull().WithMessage("The field named Name must have a value!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" })
                .NotEmpty().WithMessage("The field named Name cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" })
                .MaximumLength(50).WithMessage("The field named Name must be at most 50 characters long!")
                .WithState(_ => new { SuggestedValue = "Northern Africa" });

            RuleFor(data => data.code)
                .NotNull().WithMessage("The field named Code must have a value!")
                .WithState(_ => new { SuggestedValue = "NAF" })
                .NotEmpty().WithMessage("The field named Code cannot be empty!")
                .WithState(_ => new { SuggestedValue = "NAF" })
                .MaximumLength(10).WithMessage("The field named Code must be at most 10 characters long!")
                .WithState(_ => new { SuggestedValue = "NAF" })
                .Matches(new Regex("^[A-Z]+$"))
                .WithMessage("The field named Code must contain only uppercase letters without spaces, digits or special characters!")
                .WithState(_ => new { SuggestedValue = "NAF" });

            RuleFor(data => data.geo_code)
                .NotNull().WithMessage("The field named Geo Code must have a value!")
                .WithState(_ => new { SuggestedValue = "015" })
                .NotEmpty().WithMessage("The field named Geo Code cannot be empty!")
                .WithState(_ => new { SuggestedValue = "015" })
                .Length(3).WithMessage("The field named Geo Code must be exactly 3 characters long!")
                .WithState(_ => new { SuggestedValue = "015" })
                .Matches(new Regex("^[0-9]{3}$"))
                .WithMessage("The field named Geo Code must consist of 3 digits only (e.g., '015')!")
                .WithState(_ => new { SuggestedValue = "015" });

            RuleFor(data => data.area_km2)
                .Must(x => x >= 0)
                .WithMessage("The field named Area (km²) cannot be less than 0!")
                .WithState(_ => new { SuggestedValue = 7091800 });

            RuleFor(data => data.population)
                .Must(x => x >= 0)
                .WithMessage("The field named Population cannot be less than 0!")
                .WithState(_ => new { SuggestedValue = 246000000 });

            RuleFor(data => data.number_of_countries)
                .Must(x => x >= 0)
                .WithMessage("The field named Number of Countries cannot be less than 0!")
                .WithState(_ => new { SuggestedValue = 7 });

            RuleFor(data => data.largest_country)
                .NotNull().WithMessage("The field named Largest Country must have a value!")
                .WithState(_ => new { SuggestedValue = "Algeria" })
                .NotEmpty().WithMessage("The field named Largest Country cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Algeria" })
                .MaximumLength(100).WithMessage("The field named Largest Country must be at most 100 characters long!")
                .WithState(_ => new { SuggestedValue = "Algeria" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                .WithMessage("The field named Largest Country must contain only letters and spaces!")
                .WithState(_ => new { SuggestedValue = "Algeria" });

            RuleFor(data => data.smallest_country)
                .NotNull().WithMessage("The field named Smallest Country must have a value!")
                .WithState(_ => new { SuggestedValue = "Tunisia" })
                .NotEmpty().WithMessage("The field named Smallest Country cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Tunisia" })
                .MaximumLength(100).WithMessage("The field named Smallest Country must be at most 100 characters long!")
                .WithState(_ => new { SuggestedValue = "Tunisia" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                .WithMessage("The field named Smallest Country must contain only letters and spaces!")
                .WithState(_ => new { SuggestedValue = "Tunisia" });

            RuleFor(data => data.most_populous_country)
                .NotNull().WithMessage("The field named Most Populous Country must have a value!")
                .WithState(_ => new { SuggestedValue = "Egypt" })
                .NotEmpty().WithMessage("The field named Most Populous Country cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Egypt" })
                .MaximumLength(100).WithMessage("The field named Most Populous Country must be at most 100 characters long!")
                .WithState(_ => new { SuggestedValue = "Egypt" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                .WithMessage("The field named Most Populous Country must contain only letters and spaces!")
                .WithState(_ => new { SuggestedValue = "Egypt" });

            RuleFor(data => data.population_density)
                .NotNull().WithMessage("The field named Population Density must have a value!")
                .WithState(_ => new { SuggestedValue = 30.5 })
                .Must(x => x >= 0)
                .WithMessage("The field named Population Density cannot be less than 0!")
                .WithState(_ => new { SuggestedValue = 30.5 });

            RuleFor(data => data.description)
                .NotNull().WithMessage("The field named Description must have a value!")
                .WithState(_ => new { SuggestedValue = "Northern Africa region" })
                .NotEmpty().WithMessage("The field named Description cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Northern Africa region" })
                .MaximumLength(250).WithMessage("The field named Description must be at most 250 characters long!")
                .WithState(_ => new { SuggestedValue = "Northern Africa region" });

            RuleFor(data => data.continent_id)
                .NotEmpty()
                .WithMessage("The field named Continent Id must have a valid GUID value!")
                .WithState(_ => new { SuggestedValue = Guid.Parse("00000000-0000-0000-0000-000000000002") });
        }
    }
}
