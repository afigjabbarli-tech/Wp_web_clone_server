using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.FileCategory;
using WebWhatsAppClone.DTOs.Validation;
using WebWhatsAppClone.Helpers;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/file_categories")]
    public class FileCategoryController : ControllerBase
    {
        private readonly IValidator<FileCategoryCreateDTO> _file_category_create_validator;
        private readonly IValidator<FileCategoryUpdateDTO> _file_category_update_validtor;
        private readonly DataContext _data_context;
        private readonly ReflectionHelper _reflection_helper;
        private readonly IMapper _mapper;
        public FileCategoryController(IValidator<FileCategoryCreateDTO> file_category_create_validator, DataContext data_context, ReflectionHelper reflection_helper, IMapper mapper, IValidator<FileCategoryUpdateDTO> file_category_update_validtor)
        {
            _file_category_create_validator = file_category_create_validator;
            _data_context = data_context;
            _reflection_helper = reflection_helper;
            _mapper = mapper;
            _file_category_update_validtor = file_category_update_validtor;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] FileCategoryCreateDTO DTO)
        {
            DateTimeOffset request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                ValidationResult validation_result = await _file_category_create_validator.ValidateAsync(DTO);

                if (await _data_context.FileCategories.AnyAsync((file_category) => file_category.key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors.Select((error) =>
                    {
                        var suggestedValueObj = error.CustomState != null
                        ? _reflection_helper.GetPropertyValueByPropertyName(error.CustomState, "SuggestedValue")
                        : null;

                        var suggestedValueStr = suggestedValueObj?.ToString() ?? string.Empty;

                        return new ValidationErrorDTO
                        {
                            field_name = error.PropertyName,
                            attempted_value = error.AttemptedValue?.ToString() ?? string.Empty,
                            error_message = error.ErrorMessage,
                            suggested_value = suggestedValueStr
                        };
                    }).ToList();

                    if (validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);

                        return BadRequest(bad_request_response);
                    }
                }

                FileCategory file_category = _mapper.Map<FileCategory>(DTO);
                await _data_context.FileCategories.AddAsync(file_category);
                await _data_context.SaveChangesAsync();

                var file_category_show_dto = _mapper.Map<FileCategoryShowDTO>(file_category);

                var base_url = $"{Request.Scheme}://{Request.Host.Value}";
                var location_url = $"{base_url}{Url.Action(nameof(Show), "FileCategory", new { id = file_category.id })}";

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var created_response = new ApiResponse<FileCategoryShowDTO, DateTimeOffset>()
                    .CreatedResponse(request_start_time, request_end_time, duration, file_category_show_dto, location_url);

                return CreatedAtAction(nameof(Show), new { id = file_category.id }, created_response);
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
                var file_category_view_dtos = await _data_context.FileCategories
                    .Select((file_category) => _mapper.Map<FileCategoryViewDTO>(file_category))
                    .ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<FileCategoryViewDTO>, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_category_view_dtos);

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
                var founded_item = await _data_context.FileCategories.SingleOrDefaultAsync((file_category) => file_category.id == id);
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
                var file_category_show_dto = _mapper.Map<FileCategoryShowDTO>(founded_item);
                var read_response = new ApiResponse<FileCategoryShowDTO, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_category_show_dto);
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
            var request_start_time = DateTime.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var file_category_option_dtos = await _data_context.FileCategories
                    .Select((file_category) => new FileCategoryOptionDTO
                    {
                        label = file_category.label,
                        value = file_category.id
                    }).ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<List<FileCategoryOptionDTO>, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, file_category_option_dtos);

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
        public async Task<IActionResult> Update([FromForm] FileCategoryUpdateDTO DTO, [FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var founded_item = await _data_context.FileCategories.SingleOrDefaultAsync((file_category) => file_category.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);

                    return NotFound(not_found_response);
                }

                ValidationResult validation_result = await _file_category_update_validtor.ValidateAsync(DTO);

                var existing_keys = await _data_context.FileCategories
                    .Where(x => x.id != id)
                    .Select(file_category => file_category.key)
                    .ToListAsync();

                if (existing_keys.Any((existing_key) => existing_key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors
                        .Select((error) =>
                        {
                            var suggestedValueObj = error.CustomState != null
                                ? _reflection_helper.GetPropertyValueByPropertyName(error.CustomState, "SuggestedValue")
                                : null;

                            var suggestedValueStr = suggestedValueObj?.ToString() ?? string.Empty;

                            return new ValidationErrorDTO
                            {
                                field_name = error.PropertyName,
                                attempted_value = error.AttemptedValue?.ToString() ?? string.Empty,
                                error_message = error.ErrorMessage,
                                suggested_value = suggestedValueStr
                            };
                        }).ToList();

                    if (validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);
                        return BadRequest(bad_request_response);
                    }
                }

                _mapper.Map(DTO, founded_item);

                _data_context.FileCategories.Update(founded_item);
                await _data_context.SaveChangesAsync();

                var file_category_show_dto = _mapper.Map<FileCategoryShowDTO>(founded_item);

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var updated_response = new ApiResponse<FileCategoryShowDTO, DateTimeOffset>()
                    .UpdatedResponse(request_start_time, request_end_time, duration, file_category_show_dto);

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
                var founded_item = await _data_context.FileCategories
                    .SingleOrDefaultAsync((file_category) => file_category.id == id);

                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);

                    return NotFound(not_found_response);
                }

                _data_context.FileCategories.Remove(founded_item);
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
