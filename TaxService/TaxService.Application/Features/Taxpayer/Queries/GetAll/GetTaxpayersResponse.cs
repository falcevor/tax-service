using System.Collections.Generic;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersResponse
    {
        public IEnumerable<Domain.Model.Taxpayer> Data { get; set; }
    }
}
