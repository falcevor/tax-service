using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TaxService.Application.Features.Taxpayer.Commands.Create;
using TaxService.Application.Features.Taxpayer.Commands.Update;
using TaxService.Application.Features.Taxpayer.Queries.GetAll;
using TaxService.Application.Features.Taxpayer.Queries.GetById;

namespace TaxService.Api.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class TaxpayerController : ControllerBase
    {
        private readonly IMediator _bus;

        public TaxpayerController(ILogger<TaxpayerController> logger, IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task<ActionResult> GetTaxpayers([FromQuery]GetTaxpayersQuery query)
        {
            await _bus.Send(query);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetTaxpayerById([FromQuery]GetTaxpayerByIdQuery query)
        {
            var result = await _bus.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateTaxpayer([FromBody]CreateTaxpayerCommand command)
        {
            var id = await _bus.Send(command);
            return Ok(id);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateTaxpayer([FromBody]UpdateTaxpayerCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }
    }
}
