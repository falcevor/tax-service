using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.AreaFeature.Commands.Create;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.AreaFeature
{
    [Collection("TaxpayerFeature")]
    public class CreateAreaTests : FeatureTestBase
    {
        private const string District = "District 9";
        private const int InspectorId = 12;

        private Mock<IAsyncRepository<Area>> _repoMock;
        private CreateAreaCommand _command;
        private CreateAreaHandler _handler;

        public CreateAreaTests()
        {
            _repoMock = new Mock<IAsyncRepository<Area>>();
            _handler = new CreateAreaHandler(_repoMock.Object);
            _command = new CreateAreaCommand()
            {
                Name = District,
                InspectorId = InspectorId
            };
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.CreateAsync(It.IsAny<Area>(), It.IsAny<CancellationToken>()), Times.Once());
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await _handler.Handle(_command, predefinedCancellationToken);

            _repoMock.Verify(x => x.CreateAsync(It.IsAny<Area>(), predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => 
                x.CreateAsync(It.Is<Area>(x => x.InspectorId == InspectorId && x.Name == District), 
                CancellationToken.None)
            );
        }
    }
}
