using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult> GetAll()
        {
            await _bus.Send(new GetTaxpayersQuery());
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _bus.Send(new GetTaxpayerByIdQuery() { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTaxpayerCommand command)
        {
            var id = await _bus.Send(command);
            return Ok(id);
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateTaxpayerCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _bus.Send(new DeleteTaxpayerCommand() { Id = id });
            return await Task.FromResult(Ok());
        }
    }
}
