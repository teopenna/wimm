using System;
using Microsoft.AspNetCore.Http;

namespace Wimm.API.Utils
{
    public class ApiExceptionOptions
    {
        public Action<HttpContext, Exception, ApiError> AddResponseDetails { get; set; }
    }
}
