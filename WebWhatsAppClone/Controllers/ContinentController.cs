using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.Continent;
using WebWhatsAppClone.DTOs.Validation;
using WebWhatsAppClone.Helpers;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/continents")]
    public class ContinentController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IValidator<ContinentCreateDTO> _continent_create_validator;
        private readonly IValidator<ContinentUpdateDTO> _continent_update_validator;
        private readonly IMapper _mapper;
        private readonly ReflectionHelper _reflection_helper;
        public ContinentController(DataContext data_context, IValidator<ContinentCreateDTO> continent_create_validator, ReflectionHelper reflection_helper, IMapper mapper, IValidator<ContinentUpdateDTO> continent_update_validator)
        {
            _data_context = data_context;
            _continent_create_validator = continent_create_validator;
            _reflection_helper = reflection_helper;
            _mapper = mapper;
            _continent_update_validator = continent_update_validator;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] ContinentCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                ValidationResult validation_result = await _continent_create_validator.ValidateAsync(DTO);

                if (await _data_context.Continents.Select((c) => c.key).AnyAsync((k) => k == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors.Select((e) =>
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

                    if (validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_start_time, request_end_time, duration, validation_errors);

                        return BadRequest(bad_request_response);
                    }

                }
                Continent continent = _mapper.Map<Continent>(DTO);
                await _data_context.Continents.AddAsync(continent);
                await _data_context.SaveChangesAsync();

                var continent_show_dto = _mapper.Map<ContinentShowDTO>(continent);

                var base_url = $"{Request.Scheme}://{Request.Host.Value}";
                var location_url = $"{base_url}{Url.Action(nameof(Show), "Continent", new { id = continent.id })}";

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var created_response = new ApiResponse<ContinentShowDTO, DateTimeOffset>()
                    .CreatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: continent_show_dto, url: location_url);

                return CreatedAtAction(nameof(Show), "Continent", new { id = continent.id }, created_response);
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
                var continent_view_dtos = await _data_context.Continents
                    .Select((continent) => _mapper.Map<ContinentViewDTO>(continent))
                    .ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<ContinentViewDTO>, DateTimeOffset>()
                    .ReadResponse(request_start_time, request_end_time, duration, continent_view_dtos);

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
                var founded_item = await _data_context.Continents.SingleOrDefaultAsync((continent) => continent.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_start_time, request_end_time, duration);

                    return NotFound(not_found_response);
                }

                var continent_show_dto = _mapper.Map<ContinentShowDTO>(founded_item);
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<ContinentShowDTO, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, continent_show_dto);

                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

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
                var continent_option_dtos = await _data_context.Continents.Select((continent) =>
                new ContinentOptionDTO
                {
                    label = continent.label,
                    value = continent.id
                }).ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<ContinentOptionDTO>, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, continent_option_dtos);

                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update([FromForm] ContinentUpdateDTO DTO, [FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var founded_item = await _data_context.Continents.SingleOrDefaultAsync((continent) => continent.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                    return NotFound(not_found_response);
                }

                ValidationResult validation_result = await _continent_update_validator.ValidateAsync(DTO);

                if (await _data_context.Continents.Select((continent) => continent.key).AnyAsync((k) => k == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors.Select((e) =>
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
                            .ValidationErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, validation_errors: validation_errors);

                        return BadRequest(bad_request_response);
                    }
                }

                _mapper.Map(DTO, founded_item);

                _data_context.Continents.Update(founded_item);
                await _data_context.SaveChangesAsync();

                var continent_show_dto = _mapper.Map<ContinentShowDTO>(founded_item);

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var updated_response = new ApiResponse<ContinentShowDTO, DateTimeOffset>()
                    .UpdatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: continent_show_dto);

                return Ok(updated_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            long duration;
            DateTimeOffset request_end_time;
            try
            {
                var founded_item = await _data_context.Continents.SingleOrDefaultAsync((continent) => continent.id == id);
                if (founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

                    return NotFound(not_found_response);
                }

                _data_context.Continents.Remove(founded_item);
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
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(500, internal_server_error_response);
            }
        }
    }
}
