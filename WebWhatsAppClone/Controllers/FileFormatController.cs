using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.FileFormat;
using WebWhatsAppClone.DTOs.Validation;
using WebWhatsAppClone.Helpers;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/file_formats")]
    public class FileFormatController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IValidator<FileFormatCreateDTO> _file_format_validator;
        private readonly ReflectionHelper _reflection_helper;
        private readonly IMapper _mapper;
        public FileFormatController(DataContext data_context, IValidator<FileFormatCreateDTO> file_format_validator, IMapper mapper, ReflectionHelper reflection_helper)
        {
            _data_context = data_context;
            _file_format_validator = file_format_validator;
            _mapper = mapper;
            _reflection_helper = reflection_helper;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] FileFormatCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            try
            {
                ValidationResult result = await _file_format_validator.ValidateAsync(DTO);

                var existing_keys = await _data_context.FileFormats
                    .Select(data => data.key)
                    .ToListAsync();

                if (existing_keys.Any(key => key == DTO.key))
                {
                    result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value."));
                }

                FileCategory? file_category = await _data_context.FileCategories
                .SingleOrDefaultAsync(data => data.id == DTO.file_category_id);

                if (file_category == null)
                {
                    result.Errors.Add(new ValidationFailure("file_category_id", "The specified file category does not exist."));
                }

                if (!result.IsValid)
                {
                    var validation_errors = result.Errors
                        .Select(e =>
                        {
                            var suggestedValueObj = e.CustomState != null
                                ? _reflection_helper.GetPropertyValueByPropertyName(e.CustomState!, "SuggestedValue")
                                : null;
                            var suggestedValueStr = suggestedValueObj?.ToString() ?? string.Empty;

                            return new ValidationErrorDTO
                            {
                                field_name = e.PropertyName,
                                attempted_value = e.AttemptedValue?.ToString() ?? string.Empty,
                                error_message = e.ErrorMessage,
                                suggested_value = suggestedValueStr
                            };
                        })
                        .ToList();

                    if (validation_errors.Count > 0)
                    {
                        var request_end_time = DateTimeOffset.UtcNow;
                        var duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);
                        return BadRequest(response);
                    }
                }

                FileFormat file_format = _mapper.Map<FileFormat>(DTO);
                await _data_context.FileFormats.AddAsync(file_format);
                await _data_context.SaveChangesAsync();

                return Ok(DTO);
            }
            catch (Exception)
            {
                var request_end_time = DateTimeOffset.UtcNow;
                var duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, response);
            }
        }

    }
}
