using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaHandler : IRequestHandler<CreateAreaCommand, int>
    {
        private readonly IAsyncRepository<Area> _repo;

        public CreateAreaHandler(IAsyncRepository<Area> repo)
        {
            _repo = repo;
        }

        public async Task<int> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            var area = new Area()
            {
                Name = request.Name,
                InspectorId = request.InspectorId
            };

            return await _repo.CreateAsync(area, cancellationToken);
        }
    }
}
