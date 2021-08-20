using Microsoft.AspNetCore.Mvc;

namespace TaxService.Api.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class InspectorController : ControllerBase
    {

    }
}
