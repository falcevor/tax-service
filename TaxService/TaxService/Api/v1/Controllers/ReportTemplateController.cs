using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplate.Commands.Create;
using TaxService.Application.Features.ReportTemplate.Commands.Delete;
using TaxService.Application.Features.ReportTemplate.Commands.Update;
using TaxService.Application.Features.ReportTemplate.Queries.GetAll;
using TaxService.Application.Features.ReportTemplate.Queries.GetById;

namespace TaxService.Api.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class ReportTemplateController : ControllerBase
    {
        private readonly IMediator _bus;

        public ReportTemplateController(IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _bus.Send(new GetReportTemplatesQuery());
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _bus.Send(new GetReportTemplateByIdQuery() { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateReportTemplateCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateReportTemplateCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _bus.Send(new DeleteReportTemplateCommand() { Id = id });
            return Ok();
        }
    }
}
