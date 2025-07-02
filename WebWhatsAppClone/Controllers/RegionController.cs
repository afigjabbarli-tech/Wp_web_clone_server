using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.Continent;
using WebWhatsAppClone.DTOs.Region;
using WebWhatsAppClone.DTOs.Validation;
using WebWhatsAppClone.Helpers;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/regions")]
    public class RegionController : ControllerBase
    {
        private readonly IValidator<RegionCreateDTO> _region_create_validator;
        private readonly IValidator<RegionUpdateDTO> _region_update_validator;
        private readonly DataContext _data_context;
        private readonly ReflectionHelper _reflection_helper;
        private readonly IMapper _mapper;
        public RegionController(IValidator<RegionCreateDTO> region_create_validator, DataContext data_context, ReflectionHelper reflection_helper, IMapper mapper, IValidator<RegionUpdateDTO> region_update_validator)
        {
            _region_create_validator = region_create_validator;
            _data_context = data_context;
            _reflection_helper = reflection_helper;
            _mapper = mapper;
            _region_update_validator = region_update_validator;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] RegionCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                ValidationResult validation_result = await _region_create_validator.ValidateAsync(DTO);

                if (await _data_context.Regions.Select((region) => region.key).AnyAsync((key) => key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var continent = await _data_context.Continents.SingleOrDefaultAsync((continent) => continent.id == DTO.continent_id);
                if (continent == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("continent_id", "The specified continent does not exist.", DTO.continent_id));
                }

                if (!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors
                        .Select((error) =>
                        {
                            var suggestedValueObj = error.CustomState != null
                            ? _reflection_helper.GetPropertyValueByPropertyName(error.CustomState!, "SuggestedValue")
                            : null;

                            var suggestedValueStr = suggestedValueObj?.ToString() ?? string.Empty;

                            return new ValidationErrorDTO
                            {
                                field_name = error.PropertyName,
                                attempted_value = error.AttemptedValue?.ToString() ?? string.Empty,
                                error_message = error.ErrorMessage,
                                suggested_value = suggestedValueStr,
                            };
                        }).ToList();

                    if (validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, validation_errors: validation_errors);

                        return BadRequest(bad_request_response);
                    }
                }

                Region region = _mapper.Map<Region>(DTO);

                await _data_context.Regions.AddAsync(region);
                await _data_context.SaveChangesAsync();

                var region_show_dto = _mapper.Map<RegionShowDTO>(region);

                var base_url = $"{Request.Scheme}://{Request.Host.Value}";
                var location_url = $"{base_url}{Url.Action(nameof(Show), "Region", new { id = region.id })}";

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var created_response = new ApiResponse<RegionShowDTO, DateTimeOffset>()
                    .CreatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: region_show_dto, url: location_url);

                return CreatedAtAction(nameof(Show), "Region", new { id = region.id }, created_response);
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
        [HttpGet("view")]
        public async Task<IActionResult> View()
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var region_view_dtos = await _data_context.Regions
                    .Select((region) => _mapper.Map<RegionViewDTO>(region))
                    .ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<RegionViewDTO>, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: region_view_dtos);

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
        [HttpGet("show/{id}")]
        public async Task<IActionResult> Show([FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var founded_item = await _data_context.Regions.SingleOrDefaultAsync((region) => region.id == id);
                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                    return NotFound(not_found_response);
                }
                var region_show_dto = _mapper.Map<RegionShowDTO>(founded_item);
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<RegionShowDTO, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: region_show_dto);

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
                var region_option_dtos = await _data_context.Regions.Select((region) => new RegionOptionDTO
                {
                    label = region.label,
                    value = region.id
                }).ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<RegionOptionDTO>, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: region_option_dtos);

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
        public async Task<IActionResult> Update([FromForm] RegionUpdateDTO DTO, [FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            long duration;
            DateTimeOffset request_end_time;

            try
            {
                var founded_item = await _data_context.Regions.SingleOrDefaultAsync((region) => region.id == id);
                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

                    return NotFound(not_found_response);
                }

                ValidationResult validation_result = await _region_update_validator.ValidateAsync(DTO);

                if(await _data_context.Regions.Select((region) => region.key).AnyAsync((key) => key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var continent = await _data_context.Continents.SingleOrDefaultAsync((continent) => continent.id == DTO.continent_id);
                if(continent == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("continent_id", "The specified continent does not exist.", DTO.continent_id));
                }

                if(!validation_result.IsValid)
                {
                    var validation_errors = validation_result.Errors.Select((error) =>
                    {
                        var suggestedValueObj = error.CustomState != null
                        ? _reflection_helper.GetPropertyValueByPropertyName(error.CustomState!, "SuggestedValue")
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

                _data_context.Regions.Update(founded_item);
                await _data_context.SaveChangesAsync();

                var region_show_dto = _mapper.Map<RegionShowDTO>(founded_item);

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var updated_response = new ApiResponse<RegionShowDTO, DateTimeOffset>()
                    .UpdatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: region_show_dto);

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
            DateTimeOffset request_end_time;
            long duration;
            try
            {
                var founded_item = await _data_context.Regions.SingleOrDefaultAsync((region) => region.id == id);
                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                    return NotFound(not_found_response);
                }

                _data_context.Regions.Remove(founded_item);
                await _data_context.SaveChangesAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var deleted_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .DeletedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

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
