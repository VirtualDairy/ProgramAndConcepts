using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class ControllerVersioningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "1.0 Controller Versioning: We are handling controller versioning by specifying [ApiVersion(\"1.0\")] at controller level so all actions of this controller belongs to same version: 1.0";
        }
    }
}
