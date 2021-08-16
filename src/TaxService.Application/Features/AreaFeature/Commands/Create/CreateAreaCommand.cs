using MediatR;

namespace TaxService.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int InspectorId { get; set; }
    }
}
