using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.AreaFeature.Commands.Create;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.AreaFeature
{
    [Collection("FeatureTests")]
    public class CreateAreaTests
    {
        private const string District = "District 9";
        private const int InspectorId = 12;

        private CreateAreaCommand _command;

        public CreateAreaTests(FeatureTestsContext context)
        {
            _command = new CreateAreaCommand()
            {
                Name = District,
                InspectorId = InspectorId
            };
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repoMock = new Mock<IAsyncRepository<Area>>();
            var handler = new CreateAreaHandler(repoMock.Object);

            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.CreateAsync(It.IsAny<Area>(), It.IsAny<CancellationToken>()), Times.Once());
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<Area>>();
            var handler = new CreateAreaHandler(repoMock.Object);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(_command, predefinedCancellationToken);

            repoMock.Verify(x => x.CreateAsync(It.IsAny<Area>(), predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repoMock = new Mock<IAsyncRepository<Area>>();
            var handler = new CreateAreaHandler(repoMock.Object);
            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => 
                x.CreateAsync(It.Is<Area>(x => x.InspectorId == InspectorId && x.Name == District), 
                CancellationToken.None)
            );
        }
    }
}
