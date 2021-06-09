using System.Collections.Generic;

namespace Wimm.API.DtoValidation.Filters
{
    public class DtoFailedValidationResult
    {
        public int StatusCode { get; } = 400;
        public IList<string> ModelValidationErrors { get; }

        public DtoFailedValidationResult(IList<string> modelValidationErrors) => ModelValidationErrors = modelValidationErrors;
    }
}
