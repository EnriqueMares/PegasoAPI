using Microsoft.AspNetCore.Mvc;
using Pegaso.Common.Responses;

namespace Pegaso.Common.Extensions
{
    public static class StandardResponseExtensions
    {
        public static IActionResult ToActionResult<T>(this StandardResponse<T> standardResponse)
        {
            return new ObjectResult(standardResponse)
            {
                StatusCode = (int)standardResponse.StatusCode
            };
        }
    }
}
