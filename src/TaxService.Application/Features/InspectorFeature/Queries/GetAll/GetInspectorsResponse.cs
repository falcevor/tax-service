using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.InspectorFeature.Queries.GetAll
{
    public class GetInspectorsResponse
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IList<Area> Areas { get; set; }
    }
}
