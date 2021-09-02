using AutoMapper;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.InspectorFeature.Queries.GetAll;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.InspectorFeature
{
    [Collection("FeatureTests")]
    public class GetInspectorsTests
    {
        private GetInspectorsQuery _query;
        private IMapper _mapper;

        public GetInspectorsTests(FeatureTestsContext context)
        {
            _mapper = context.Mapper;
            _query = new GetInspectorsQuery();
        }

        [Fact]
        public async Task Sould_call_repo_method()
        {
            var repoMock = new Mock<IAsyncRepository<Inspector>>();
            var handler = new GetInspectorsHandler(repoMock.Object, _mapper);
            
            await handler.Handle(_query, CancellationToken.None);
            repoMock.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task Sould_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<Inspector>>();
            var handler = new GetInspectorsHandler(repoMock.Object, _mapper);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(_query, token);

            repoMock.Verify(x => x.GetAllAsync(token), Times.Once);
        }

        [Fact]
        public async Task Sould_correctrly_map_response_fields()
        {
            var repoMock = new Mock<IAsyncRepository<Inspector>>();
            var handler = new GetInspectorsHandler(repoMock.Object, _mapper);
            var source = GetTestInspectors();
            repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(source.AsQueryable()));

            var result = await handler.Handle(_query, CancellationToken.None);

            result.Should().BeEquivalentTo(source);
        }

        private IEnumerable<Inspector> GetTestInspectors()
        {
            return new Inspector[]
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
        }
    }
}
