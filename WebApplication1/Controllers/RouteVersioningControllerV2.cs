using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.v2
{

    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class RouteVersioningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "2.0 Route Versioning basically: we are handling api versioning through route to implement this we've specfied api/v{version:apiVersion}/[controller] in route tag";
        }
    }
}
