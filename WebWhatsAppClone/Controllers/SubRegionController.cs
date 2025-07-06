using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.SubRegion;
using WebWhatsAppClone.DTOs.Validation;
using WebWhatsAppClone.Helpers;

namespace WebWhatsAppClone.Controllers
{
    [Route("api/v1/sub-regions")]
    [ApiController]
    public class SubRegionController : ControllerBase
    {
        private readonly IValidator<SubRegionCreateDTO> _sub_region_create_validator;
        private readonly IValidator<SubRegionUpdateDTO> _sub_region_update_validator;
        private readonly DataContext _data_context;
        private readonly ReflectionHelper _reflection_helper;
        private readonly IMapper _mapper;

        public SubRegionController(IValidator<SubRegionCreateDTO> sub_region_create_validator, DataContext data_context, ReflectionHelper reflection_helper, IMapper mapper, IValidator<SubRegionUpdateDTO> sub_region_update_validator)
        {
            _sub_region_create_validator = sub_region_create_validator;
            _data_context = data_context;
            _reflection_helper = reflection_helper;
            _mapper = mapper;
            _sub_region_update_validator = sub_region_update_validator;
        }

        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] SubRegionCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                ValidationResult validation_result = await _sub_region_create_validator.ValidateAsync(DTO);

                if (await _data_context.SubRegions.Select((sub_region) => sub_region.key).AnyAsync((key) => key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var region = _data_context.Regions.SingleOrDefaultAsync((region) => region.id == DTO.region_id);
                if (region == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("region_id", "The specified region does not exist.", DTO.region_id));
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
                                suggested_value = suggestedValueStr
                            };
                        }).ToList();

                    if (validation_errors.Count > 0)
                    {
                        request_end_time = DateTimeOffset.UtcNow;
                        duration = (long)(request_end_time - request_end_time).TotalMilliseconds;
                        var bad_request_response = new ApiResponse<List<ValidationErrorDTO>, DateTimeOffset>()
                            .ValidationErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, validation_errors: validation_errors);
                        return BadRequest(bad_request_response);
                    }
                }

                SubRegion sub_region = _mapper.Map<SubRegion>(DTO);

                await _data_context.SubRegions.AddAsync(sub_region);
                await _data_context.SaveChangesAsync();

                var sub_region_show_dto = _mapper.Map<SubRegionShowDTO>(sub_region);

                var base_url = $"{Request.Scheme}://{Request.Host.Value}";
                var location_url = $"{base_url}{Url.Action(nameof(Show), "SubRegion", new { id = sub_region.id })}";

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var created_response = new ApiResponse<SubRegionShowDTO, DateTimeOffset>()
                    .CreatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: sub_region_show_dto, url: location_url);

                return CreatedAtAction(nameof(Show), "SubRegion", new { id = sub_region.id }, created_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error_response);
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
                var sub_region_view_dtos = await _data_context.SubRegions
                    .Select((sub_region) => _mapper.Map<SubRegionViewDTO>(sub_region)).ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var read_response = new ApiResponse<List<SubRegionViewDTO>, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: sub_region_view_dtos);

                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error_response);
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
                var founded_item = await _data_context.SubRegions
                    .SingleOrDefaultAsync((sub_region) => sub_region.id == id);

                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_start_time - request_end_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                    return NotFound(not_found_response);
                }

                var sub_region_show_dto = _mapper.Map<SubRegionShowDTO>(founded_item);
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds; 
                
                var read_response = new ApiResponse<SubRegionShowDTO, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: sub_region_show_dto);
                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error_response);
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
                var sub_region_option_dtos = await _data_context.SubRegions
                    .Select((sub_region) => new SubRegionOptionDTO
                    {
                        label = sub_region.label,
                        value = sub_region.id
                    }).ToListAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var read_response = new ApiResponse<List<SubRegionOptionDTO>, DateTimeOffset>()
                    .ReadResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: sub_region_option_dtos);
                return Ok(read_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error);
            }
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update([FromForm] SubRegionUpdateDTO DTO, [FromRoute] Guid id)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {
                var founded_item = await _data_context.SubRegions.SingleOrDefaultAsync((sub_region) => sub_region.id == id);
                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

                    return NotFound(not_found_response);
                }

                ValidationResult validation_result = await _sub_region_update_validator.ValidateAsync(DTO);

                if(await _data_context.SubRegions.Where((sub_region) => sub_region.id != id).Select((sub_region) => sub_region.key).AnyAsync((key) => key == DTO.key))
                {
                    validation_result.Errors.Add(new ValidationFailure("key", "The provided key already exists in the system. Please choose a unique value.", DTO.key));
                }

                var region = await _data_context.Regions.SingleOrDefaultAsync((region) => region.id == DTO.region_id);
                if(region == null)
                {
                    validation_result.Errors.Add(new ValidationFailure("region_id", "The specified region does not exist.", DTO.region_id));
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

                _data_context.SubRegions.Update(founded_item);
                await _data_context.SaveChangesAsync();

                var sub_region_show_dto = _mapper.Map<SubRegionShowDTO>(founded_item);

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;

                var updated_response = new ApiResponse<SubRegionShowDTO, DateTimeOffset>()
                    .UpdatedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration, data: sub_region_show_dto);

                return Ok(updated_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error);
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
                var founded_item = await _data_context.SubRegions.SingleOrDefaultAsync((sub_region) => sub_region.id == id);
                if(founded_item == null)
                {
                    request_end_time = DateTimeOffset.UtcNow;
                    duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                    var not_found_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                        .NotFoundResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

                    return NotFound(not_found_response);
                }

                _data_context.SubRegions.Remove(founded_item);
                await _data_context.SaveChangesAsync();

                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var deleted_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .DeletedResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);

                return StatusCode(StatusCodes.Status204NoContent, deleted_response);
            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
                return StatusCode(StatusCodes.Status500InternalServerError, internal_server_error);
            }
        }
    }
}
