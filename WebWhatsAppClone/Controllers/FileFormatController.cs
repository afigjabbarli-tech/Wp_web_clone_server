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
        private readonly IValidator<FileFormatCreateDTO> _file_format_create_validator;
        private readonly IValidator<FileFormatUpdateDTO> _file_format_update_validator;
        private readonly ReflectionHelper _reflection_helper;
        private readonly IMapper _mapper;
        public FileFormatController(DataContext data_context,
            IValidator<FileFormatCreateDTO> file_format_create_validator,
            IMapper mapper, ReflectionHelper reflection_helper,
            IValidator<FileFormatUpdateDTO> file_format_update_validator)
        {
            _data_context = data_context;
            _file_format_create_validator = file_format_create_validator;
            _mapper = mapper;
            _reflection_helper = reflection_helper;
            _file_format_update_validator = file_format_update_validator;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] FileFormatCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                ValidationResult validation_result = await _file_format_create_validator.ValidateAsync(DTO);

                var existing_keys = await _data_context.FileFormats
                    .Select(data => data.key)
                    .ToListAsync();

                if (existing_keys.Any((existing_key) => existing_key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var file_category = await _data_context.FileCategories
                    .SingleOrDefaultAsync((file_category) => file_category.id == DTO.file_category_id);

                if (file_category == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("file_category_id", "The specified file category does not exist.", DTO.file_category_id));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors
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
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                        .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);
                        return BadRequest(bad_request_response);
                    }
                }

                FileFormat file_format = _mapper.Map<FileFormat>(DTO);
                await _data_context.FileFormats.AddAsync(file_format);
                await _data_context.SaveChangesAsync();

                var file_format_show_dto = _mapper.Map<FileFormatShowDTO>(file_format);

                var base_url = $"{Request.Scheme}://{Request.Host.Value}";
                var location_url = $"{base_url}{Url.Action(nameof(Show), "FileFormat", new { id = file_format.id })}";

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var created_response = new ApiResponse<FileFormatShowDTO, DateTimeOffset>()
                    .CreatedResponse(request_start_time, request_end_time, duration, file_format_show_dto, location_url);

                return CreatedAtAction(nameof(Show), new { id = file_format.id }, created_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpGet("view")]
        public async Task<IActionResult> View()
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var file_format_view_dtos = await _data_context.FileFormats
                    .Select((file_format) => _mapper.Map<FileFormatViewDTO>(file_format))
                    .ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<List<FileFormatViewDTO>, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_format_view_dtos);

                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpGet("show/{id}")]
        public async Task<IActionResult> Show([FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var founded_item = await _data_context.FileFormats.SingleOrDefaultAsync((file_format) => file_format.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);
                    return NotFound(not_found_response);
                }
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var file_format_show_dto = _mapper.Map<FileFormatShowDTO>(founded_item);
                var read_response = new ApiResponse<FileFormatShowDTO, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_format_show_dto);
                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpGet("pick-list")]
        public async Task<IActionResult> PickList()
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var file_format_option_dtos = await _data_context.FileFormats.Select((file_format) => new FileFormatOptionDTO
                {
                    label = file_format.label,
                    value = file_format.id
                }).ToListAsync();
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<List<FileFormatOptionDTO>, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_format_option_dtos);

                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update([FromForm] FileFormatUpdateDTO DTO, [FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var founded_item = await _data_context.FileFormats.SingleOrDefaultAsync(file_format => file_format.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);
                    return NotFound(not_found_response);
                }

                ValidationResult validation_result = await _file_format_update_validator.ValidateAsync(DTO);

                var existing_keys = await _data_context.FileFormats
                    .Where(x => x.id != id)
                    .Select(file_format => file_format.key)
                    .ToListAsync();

                if (existing_keys.Any(existing_key => existing_key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var file_category = await _data_context.FileCategories.SingleOrDefaultAsync(fc => fc.id == DTO.file_category_id);
                if (file_category == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("file_category_id", "The specified file category does not exist.", DTO.file_category_id));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors
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
                        }).ToList();

                    if(validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);

                        return BadRequest(bad_request_response);
                    }
                }

                _mapper.Map(DTO, founded_item);

                _data_context.FileFormats.Update(founded_item);
                await _data_context.SaveChangesAsync();

                var file_format_show_dto = _mapper.Map<FileFormatShowDTO>(founded_item);

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var updated_response = new ApiResponse<FileFormatShowDTO, DateTimeOffset>()
                    .UpdatedResponse(request_start_time, request_end_time, duration, file_format_show_dto);

                return Ok(updated_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var founded_item = await _data_context.FileFormats
                    .SingleOrDefaultAsync((file_format) => file_format.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);
                    return NotFound(not_found_response);
                }

                _data_context.FileFormats.Remove(founded_item);
                await _data_context.SaveChangesAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var deleted_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .DeletedResponse(request_start_time, request_end_time, duration);

                return StatusCode(204, deleted_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                .InternalServerErrorResponse(request_start_time, request_end_time, duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
    }
}
