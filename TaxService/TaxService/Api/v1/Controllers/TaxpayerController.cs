using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Application.Features.Taxpayer.Commands.Create;
using TaxService.Application.Features.Taxpayer.Commands.Delete;
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

        public TaxpayerController(IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTaxpayersResponse>>> GetTaxpayers()
        {
            var result = await _bus.Send(new GetTaxpayersQuery());
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<GetTaxpayerByIdResponse>> GetTaxpayer(int id)
        {
            var result = await _bus.Send(new GetTaxpayerByIdQuery() { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTaxpayer(CreateTaxpayerCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTaxpayer(UpdateTaxpayerCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTaxpayer(int id)
        {
            await _bus.Send(new DeleteTaxpayerCommand() { Id = id });
            return Ok();
        }
    }
}
