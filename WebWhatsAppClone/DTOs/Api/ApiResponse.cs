using WebWhatsAppClone.DataBase.Base;
using WebWhatsAppClone.DTOs.Validation;

namespace WebWhatsAppClone.DTOs.Api
{
    public class ApiResponse<TData, TDate>
        where TDate : struct
        where TData : class
    {
        public string message { get; set; } = string.Empty;
        public string? error_details { get; set; } = string.Empty;
        public string? url { get; set; } = string.Empty;
        public bool is_success { get; set; }
        public int status_code { get; set; }
        public TDate request_time { get; set; }
        public TDate response_time { get; set; }
        public long duration_ms { get; set; }
        public TData? data { get; set; }
        public List<ValidationErrorDTO>? validation_errors { get; set; } = new();
        public ApiResponse<TData, TDate> SuccessResponse(TDate request_time, TDate response_time, long duration_ms, string message = "Request processed successfully.", bool is_success = true, int status_code = 200)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = default,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> FailureResponse(TDate request_time, TDate response_time, long duration_ms, string error_details, string message = "An error occurred while processing the request!", bool is_success = false, int status_code = 400)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = error_details,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> CreatedResponse(
                 TDate request_time,
                 TDate response_time,
                 long duration_ms,
                 TData data,
                 string? url = null,
                 string message = "Resource created successfully.",
                 bool is_success = true,
                 int status_code = 201)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = default,
                url = url,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = data,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> ReadResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            TData data,
            string message = "Resource retrieved successfully.",
            bool is_success = true,
            int status_code = 200)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = default,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = data,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> UpdatedResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            TData data,
            string? url = null,
            string message = "Resource updated successfully.",
            bool is_success = true,
            int status_code = 200)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = default,
                url = url,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = data,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> DeletedResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            string message = "Resource deleted successfully.",
            bool is_success = true,
            int status_code = 204) 
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = default,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default, 
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> ValidationErrorResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            List<ValidationErrorDTO> validation_errors,
            string message = "Validation failed.",
            string? error_details = "One or more validation errors occurred.",
            int status_code = 400,
            bool is_success = false)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = error_details,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = validation_errors
            };
        }
        public ApiResponse<TData, TDate> UnauthorizedResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            string message = "Unauthorized access.",
            string? error_details = "Authentication credentials were missing or invalid.",
            int status_code = 401,
            bool is_success = false)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = error_details,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> NotFoundResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            string message = "The requested resource was not found.",
            string? error_details = "No matching data found for the given criteria.",
            int status_code = 404,
            bool is_success = false)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = error_details,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = default
            };
        }
        public ApiResponse<TData, TDate> InternalServerErrorResponse(
            TDate request_time,
            TDate response_time,
            long duration_ms,
            string message = "An unexpected error occurred.",
            string? error_details = "An internal server error has occurred. Please contact support.",
            int status_code = 500,
            bool is_success = false)
        {
            return new ApiResponse<TData, TDate>
            {
                message = message,
                error_details = error_details,
                url = default,
                is_success = is_success,
                status_code = status_code,
                request_time = request_time,
                response_time = response_time,
                duration_ms = duration_ms,
                data = default,
                validation_errors = default
            };
        }
    }
}
