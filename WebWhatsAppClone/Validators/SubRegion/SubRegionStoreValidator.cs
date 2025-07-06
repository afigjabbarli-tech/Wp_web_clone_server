using FluentValidation;
using System.Text.RegularExpressions;
using WebWhatsAppClone.DTOs.SubRegion;

namespace WebWhatsAppClone.Validators.SubRegion
{
    public class SubRegionStoreValidator : AbstractValidator<SubRegionCreateDTO>
    {
        public SubRegionStoreValidator()
        {
            RuleFor((data) => data.key)
               .NotNull()
                   .WithMessage("The field named Key must have a value!")
                   .WithState((_) => new { SuggestedValue = "nile_valley" })
               .NotEmpty()
                   .WithMessage("The field named Key cannot be empty!")
                   .WithState((_) => new { SuggestedValue = "nile_valley" })
               .MaximumLength(50)
                   .WithMessage("The field named Key must be at most 50 characters long!")
                   .WithState((_) => new { SuggestedValue = "nile_valley" })
               .Matches(new Regex("^[a-z_]+$"))
                   .WithMessage("The field named Key must contain only lowercase letters and underscores (no spaces, digits or special characters)!")
                   .WithState((_) => new { SuggestedValue = "nile_valley" });

            RuleFor((data) => data.label)
                .NotNull()
                    .WithMessage("The field named Label must have a value!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" })
                .NotEmpty()
                    .WithMessage("The field named Label cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" })
                .MaximumLength(50)
                    .WithMessage("The field named Label must be at most 50 characters long!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Label must contain only letters and spaces (no digits or special characters)!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" });

            RuleFor((data) => data.name)
                .NotNull()
                    .WithMessage("The field named Name must have a value!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" })
                .NotEmpty()
                    .WithMessage("The field named Name cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" })
                .MaximumLength(50)
                    .WithMessage("The field named Name must be at most 50 characters long!")
                    .WithState((_) => new { SuggestedValue = "Nile Valley" });

            RuleFor((data) => data.code)
                .NotNull()
                    .WithMessage("The field named Code must have a value!")
                    .WithState((_) => new { SuggestedValue = "ARP" })
                .NotEmpty()
                    .WithMessage("The field named Code cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "ARP" })
                .MaximumLength(10)
                    .WithMessage("The field named Code must be at most 10 characters long!")
                    .WithState((_) => new { SuggestedValue = "ARP" })
                .Matches(new Regex("^[A-Z]+$"))
                    .WithMessage("The field named Code must contain only uppercase letters without spaces, digits or special characters!")
                    .WithState((_) => new { SuggestedValue = "ARP" });

            RuleFor((data) => data.geo_code)
                .NotNull()
                    .WithMessage("The field named Geo Code must have a value!")
                    .WithState((_) => new { SuggestedValue = "145-2" })
                .NotEmpty()
                    .WithMessage("The field named Geo Code cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "145-2" })
                .Length(5)
                    .WithMessage("The field named Geo Code must be exactly 5 characters long!")
                    .WithState((_) => new { SuggestedValue = "145-2" })
                .Matches(new Regex(@"^[0-9]{3}-[0-9]{1}$"))
                    .WithMessage("The field named Geo Code must be in the format 'NNN-N', containing only digits and one dash (e.g., '145-2')!")
                    .WithState((_) => new { SuggestedValue = "145-2" });

            RuleFor((data) => data.area_km2)
                .Must(x => x >= 0)
                    .WithMessage("The field named Area (km²) cannot be less than 0!")
                    .WithState((_) => new { SuggestedValue = 300000 });

            RuleFor((data) => data.population)
                .Must(x => x >= 0)
                    .WithMessage("The field named Population cannot be less than 0!")
                    .WithState((_) => new { SuggestedValue = 15000000 });

            RuleFor((data) => data.number_of_countries)
                .Must(x => x >= 0)
                    .WithMessage("The field named Number of Countries cannot be less than 0!")
                    .WithState((_) => new { SuggestedValue = 7 });

            RuleFor((data) => data.largest_country)
                .NotNull()
                    .WithMessage("The field named Largest Country must have a value!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .NotEmpty()
                    .WithMessage("The field named Largest Country cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .MaximumLength(100)
                    .WithMessage("The field named Largest Country must be at most 100 characters long!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Largest Country must contain only letters and spaces!")
                    .WithState((_) => new { SuggestedValue = "South Africa" });

            RuleFor((data) => data.smallest_country)
                .NotNull()
                    .WithMessage("The field named Smallest Country must have a value!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .NotEmpty()
                    .WithMessage("The field named Smallest Country cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .MaximumLength(100)
                    .WithMessage("The field named Smallest Country must be at most 100 characters long!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Smallest Country must contain only letters and spaces!")
                    .WithState((_) => new { SuggestedValue = "South Africa" });

            RuleFor((data) => data.most_populous_country)
                .NotNull()
                    .WithMessage("The field named Most Populous Country must have a value!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .NotEmpty()
                    .WithMessage("The field named Most Populous Country cannot be empty!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .MaximumLength(100)
                    .WithMessage("The field named Most Populous Country must be at most 100 characters long!")
                    .WithState((_) => new { SuggestedValue = "South Africa" })
                .Matches(new Regex("^[A-Za-z ]+$"))
                    .WithMessage("The field named Most Populous Country must contain only letters and spaces!")
                    .WithState((_) => new { SuggestedValue = "South Africa" });

            RuleFor((data) => data.population_density)
                .NotNull()
                    .WithMessage("The field named Population Density must have a value!")
                    .WithState((_) => new { SuggestedValue = 30.5 })
                .Must(x => x >= 0)
                    .WithMessage("The field named Population Density cannot be less than 0!")
                    .WithState((_) => new { SuggestedValue = 30.5 });

            RuleFor((data) => data.description)
               .NotNull()
                   .WithMessage("The field named Description must have a value!")
                   .WithState((_) => new { SuggestedValue = "Turkestan covers parts of Kazakhstan, Uzbekistan, and Turkmenistan." })
               .NotEmpty()
                   .WithMessage("The field named Description cannot be empty!")
                   .WithState((_) => new { SuggestedValue = "Turkestan covers parts of Kazakhstan, Uzbekistan, and Turkmenistan." })
               .MaximumLength(250)
                   .WithMessage("The field named Description must be at most 250 characters long!")
                   .WithState((_) => new { SuggestedValue = "Turkestan covers parts of Kazakhstan, Uzbekistan, and Turkmenistan." });

            RuleFor((data) => data.region_id)
                .NotEmpty()
                    .WithMessage("The field named Region Id must have a valid GUID value!")
                    .WithState((_) => new { SuggestedValue = Guid.Parse("00000000-0000-0000-0000-000000000002") });
        }
    }
}
