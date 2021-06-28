using MediatR;

namespace TaxService.Application.Features.Taxpayer.Commands.Delete
{
    public class DeleteTaxpayerCommand : IRequest
    {
        public int Id { get; set; }
    }
}
