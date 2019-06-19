using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Extensions;
using Supermarket.API.Resources;

namespace Supermarket.API.Controllers.Config
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.GetErrorMessages();
            var response = new ErrorResource(messages: errors);
            
            return new BadRequestObjectResult(response);
        }
    }
}