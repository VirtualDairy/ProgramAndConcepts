using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class DifferentVersionForDifferentController : ControllerBase
    {
        [HttpGet("existing")]
        [MapToApiVersion("1.0")]
        public string Get()
        {
            return "1.0 Action Versioning: We are handling action versioning by specifying [ApiVersion(\"1.0\")] for version at controller level and [MapToApiVersion(\"1.0\")] action level so that particular actions of that controller belongs to specified version: 1.0";
        }

        [HttpGet("new")]
        [MapToApiVersion("2.0")]
        public string GetMew()
        {
            return "2.0 Action Versioning: We are handling action versioning by specifying [ApiVersion(\"1.0\")] for version at controller level and [MapToApiVersion(\"2.0\")] action level so that particular actions of that controller belongs to specified version: 2.0";
        }
    }
}
