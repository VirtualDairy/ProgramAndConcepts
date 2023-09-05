using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers.v2
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class ControllerVersioningController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "2.0 Controller Versioning: We are handling controller versioning by specifying [ApiVersion(\"2.0\")] at controller level so all actions of this controller belongs to same version: 2.0";
        }
    }
}
