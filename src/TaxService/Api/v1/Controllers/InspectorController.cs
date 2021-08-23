using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Application.Features.InspectorFeature.Queries.GetAll;

namespace TaxService.Api.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class InspectorController : ControllerBase
    {
        private IMediator _bus;

        public InspectorController(IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetInspectorsResponse>>> GetInspectors()
        {
            var query = new GetInspectorsQuery();
            return Ok(await _bus.Send(query));
        }
    }
}
