using FluentAssertions;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.InspectorFeature.Queries.GetAll;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.InspectorFeature
{
    public class GetInspectorsTests : FeatureTestBase
    {
        private Mock<IAsyncRepository<Inspector>> _repoMock;
        private GetInspectorsQuery _query;
        private GetInspectorsHandler _handler;

        public GetInspectorsTests()
        {
            _repoMock = new Mock<IAsyncRepository<Inspector>>();
            _query = new GetInspectorsQuery();
            _handler = new GetInspectorsHandler(_repoMock.Object, ConfigureMapper());
        }

        [Fact]
        public async Task Sould_call_repo_method()
        {
            await _handler.Handle(_query, CancellationToken.None);
            _repoMock.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task Sould_use_predefined_CancellationToken()
        {
            var token = new CancellationTokenSource().Token;
            await _handler.Handle(_query, token);
            _repoMock.Verify(x => x.GetAllAsync(token), Times.Once);
        }

        [Fact]
        public async Task Sould_correctrly_map_response_fields()
        {
            var source = new Inspector[]
            {
                new Inspector() {
                    Id = 1,
                    Login = "FakeLogin",
                    Password = "FakePassword"
                },
                new Inspector() {
                    Id = 2,
                    Login = "FakeLogin2",
                    Password = "FakePassword2"
                }
            };
            _repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(source.AsQueryable()));

            var result = await _handler.Handle(_query, CancellationToken.None);

            result.Should().BeEquivalentTo(source);
        }
    }
}
