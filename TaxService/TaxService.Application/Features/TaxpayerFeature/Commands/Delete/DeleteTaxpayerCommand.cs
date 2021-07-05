using MediatR;

namespace TaxService.Application.Features.TaxpayerFeature.Commands.Delete
{
    public class DeleteTaxpayerCommand : IRequest
    {
        public int Id { get; set; }
    }
}
