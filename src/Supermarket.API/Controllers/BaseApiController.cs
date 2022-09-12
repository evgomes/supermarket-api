using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected  IMapper? _mapper  => Mapper ??= HttpContext.RequestServices.GetService<IMapper>();
        private IMapper? Mapper;
    }
}