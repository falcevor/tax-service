using Moq;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace UnitTests.Application.Features.InspectorFeature
{
    public class GetInspectorsTests : FeatureTestBase
    {
        private Mock<IAsyncRepository<Inspector>> _repoMock;
        private GetInspectorQuery _query;
        private GetInspectorHandler _handler;

        public GetInspectorsTests()
        {
            _repoMock = new Mock<IAsyncRepository<Inspector>>();
        }

    }
}
