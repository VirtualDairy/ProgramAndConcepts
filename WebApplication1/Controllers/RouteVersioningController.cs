using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class RouteVersioningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "1.0 Route Versioning basically: we are handling api versioning through route to implement this we've specfied api/v{version:apiVersion}/[controller] in route tag";
        }
    }
}
