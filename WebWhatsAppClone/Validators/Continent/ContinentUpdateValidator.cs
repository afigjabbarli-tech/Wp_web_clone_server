using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.Continent;

namespace WebWhatsAppClone.Validators.Continent
{
    public class ContinentUpdateValidator : AbstractValidator<ContinentUpdateDTO>
    {
        public ContinentUpdateValidator()
        {
            RuleFor(data => data.key)
                     .NotNull()
                .WithMessage("The field named Key must have a value!")
                .WithState(_ => new { SuggestedValue = "eu" })
                     .NotEmpty()
                .WithMessage("The field named Key cannot be empty!")
                .WithState(_ => new { SuggestedValue = "eu" })
                     .MaximumLength(10)
                .WithMessage("The field named Key must be at most 10 characters long!")
                .WithState(_ => new { SuggestedValue = "eu" })
                    .Matches(new Regex("^[a-z]+$"))
                .WithMessage("The field named Key must contain only lowercase letters without spaces, digits or special characters!")
                .WithState(_ => new { SuggestedValue = "eu" });

            RuleFor(data => data.label)
                    .NotNull()
                .WithMessage("The field named Label must have a value!")
                .WithState(_ => new { SuggestedValue = "Asia" })
                    .NotEmpty()
                .WithMessage("The field named Label cannot be empty!")
                .WithState(_ => new { SuggestedValue = "Asia" })
                    .MaximumLength(50)
                .WithMessage("The field named Label must be at most 50 characters long!")
                .WithState(_ => new { SuggestedValue = "Asia" })
                    .Matches(new Regex("^[A-Za-z ]+$"))
                .WithMessage("The field named Label must contain only letters and spaces (no digits or special characters)!")
                .WithState(_ => new { SuggestedValue = "North America" });

            RuleFor(data => data.name)
                .NotNull()
                    .WithMessage("The field named Name must have a value!")
                    .WithState(_ => new { SuggestedValue = "Asia" })
                .NotEmpty()
                    .WithMessage("The field named Name cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Asia" })
                .MaximumLength(50)
                    .WithMessage("The field named Name must be at most 50 characters long!")
                    .WithState(_ => new { SuggestedValue = "Asia" });

            RuleFor(data => data.code)
                .NotNull()
                    .WithMessage("The field named Code must have a value!")
                    .WithState(_ => new { SuggestedValue = "EU" })
                .NotEmpty()
                    .WithMessage("The field named Code cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "EU" })
                .MaximumLength(10)
                    .WithMessage("The field named Code must be at most 10 characters long!")
                    .WithState(_ => new { SuggestedValue = "EU" })
                .Matches(new Regex("^[A-Z]+$"))
                    .WithMessage("The field named Code must contain only uppercase letters without spaces, digits or special characters!")
                    .WithState(_ => new { SuggestedValue = "EU" });

            RuleFor(data => data.un_code)
              .NotNull()
                  .WithMessage("The field named UN Code must have a value!")
                  .WithState(_ => new { SuggestedValue = "142" })
              .NotEmpty()
                  .WithMessage("The field named UN Code cannot be empty!")
                  .WithState(_ => new { SuggestedValue = "142" })
              .Length(3)
                  .WithMessage("The field named UN Code must be exactly 3 characters long!")
                  .WithState(_ => new { SuggestedValue = "142" })
              .Matches(new Regex("^[0-9]{3}$"))
                  .WithMessage("The field named UN Code must consist of 3 digits only (e.g., '142')!")
                  .WithState(_ => new { SuggestedValue = "142" });

            RuleFor(data => data.population_density)
                .NotNull()
                    .WithMessage("The field named Population Density must have a value!")
                    .WithState(_ => new { SuggestedValue = 150 })
                .Must(x => x >= 0)
                    .WithMessage("The field named Population Density cannot be less than 0!")
                    .WithState(_ => new { SuggestedValue = 150 });

            RuleFor(data => data.area_km2)
                .NotNull()
                    .WithMessage("The field named Area (km²) must have a value!")
                    .WithState(_ => new { SuggestedValue = 44579000 })
                .Must(x => x >= 0)
                    .WithMessage("The field named Area (km²) cannot be less than 0!")
                    .WithState(_ => new { SuggestedValue = 44579000 });

            RuleFor(data => data.population)
                .NotNull()
                    .WithMessage("The field named Population must have a value!")
                    .WithState(_ => new { SuggestedValue = 4600000000 })
                .Must(x => x >= 0)
                    .WithMessage("The field named Population cannot be less than 0!")
                    .WithState(_ => new { SuggestedValue = 4600000000 });

            RuleFor(data => data.number_of_countries)
                .NotNull()
                    .WithMessage("The field named Number of Countries must have a value!")
                    .WithState(_ => new { SuggestedValue = 49 })
                .Must(x => x >= 0)
                    .WithMessage("The field named Number of Countries cannot be less than 0!")
                    .WithState(_ => new { SuggestedValue = 49 });

            RuleFor(data => data.largest_country)
                .NotNull()
                    .WithMessage("The field named Largest Country must have a value!")
                    .WithState(_ => new { SuggestedValue = "Russia" })
                .NotEmpty()
                    .WithMessage("The field named Largest Country cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Russia" })
                .MaximumLength(100)
                    .WithMessage("The field named Largest Country must be at most 100 characters long!")
                    .WithState(_ => new { SuggestedValue = "Russia" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Largest Country must contain only letters and spaces!")
                    .WithState(_ => new { SuggestedValue = "Russia" });

            RuleFor(data => data.smallest_country)
                .NotNull()
                    .WithMessage("The field named Smallest Country must have a value!")
                    .WithState(_ => new { SuggestedValue = "Maldives" })
                .NotEmpty()
                    .WithMessage("The field named Smallest Country cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Maldives" })
                .MaximumLength(100)
                    .WithMessage("The field named Smallest Country must be at most 100 characters long!")
                    .WithState(_ => new { SuggestedValue = "Maldives" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Smallest Country must contain only letters and spaces!")
                    .WithState(_ => new { SuggestedValue = "Maldives" });

            RuleFor(data => data.most_populous_country)
                .NotNull()
                    .WithMessage("The field named Most Populous Country must have a value!")
                    .WithState(_ => new { SuggestedValue = "China" })
                .NotEmpty()
                    .WithMessage("The field named Most Populous Country cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "China" })
                .MaximumLength(100)
                    .WithMessage("The field named Most Populous Country must be at most 100 characters long!")
                    .WithState(_ => new { SuggestedValue = "China" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Most Populous Country must contain only letters and spaces!")
                    .WithState(_ => new { SuggestedValue = "China" });

            RuleFor(data => data.description)
                .NotNull()
                    .WithMessage("The field named Description must have a value!")
                    .WithState(_ => new { SuggestedValue = "Asia is the largest continent." })
                .NotEmpty()
                    .WithMessage("The field named Description cannot be empty!")
                    .WithState(_ => new { SuggestedValue = "Asia is the largest continent." })
                .MaximumLength(250)
                    .WithMessage("The field named Description must be at most 250 characters long!")
                    .WithState(_ => new { SuggestedValue = "Asia is the largest continent, both in area and population." });
        }
    }
}
