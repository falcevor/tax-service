using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersHandler : IRequestHandler<GetTaxpayersQuery, GetTaxpayersResponse>
    {
        private readonly IAsyncRepository<Domain.Model.Taxpayer> _repos;

        public GetTaxpayersHandler(IAsyncRepository<Domain.Model.Taxpayer> repos)
        {
            _repos = repos;
        }

        public async Task<GetTaxpayersResponse> Handle(GetTaxpayersQuery request, CancellationToken cancellationToken)
        {
            var result = new GetTaxpayersResponse()
            {
                Data = await _repos.GetAllAsync(cancellationToken)
            };
            return await Task.FromResult(result);
        }
    }
}
