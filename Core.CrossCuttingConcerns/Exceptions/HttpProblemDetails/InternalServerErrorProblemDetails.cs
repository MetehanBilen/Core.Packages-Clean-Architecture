using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class InternalServerErrorProblemDetails : ProblemDetails
    {
        public InternalServerErrorProblemDetails(String detail)
        {
            Title = "Interna Server Error";
            Detail = detail;
            Status = StatusCodes.Status500InternalServerError;
            Type = "https://example.com/probs/internal";

        }
    }
}
