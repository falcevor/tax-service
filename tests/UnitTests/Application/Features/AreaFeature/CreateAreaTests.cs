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
    public class CreateAreaTests
    {
        private const string District = "District 9";
        private const int InspectorId = 12;

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<Area>>();
            var command = CreateTestCommand();
            var handler = new CreateAreaHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.CreateAsync(It.IsAny<Area>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<Area>>();
            var command = CreateTestCommand();
            var handler = new CreateAreaHandler(repo.Object);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(command, predefinedCancellationToken);

            repo.Verify(x => x.CreateAsync(It.IsAny<Area>(), predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repo = new Mock<IAsyncRepository<Area>>();
            var command = CreateTestCommand();
            var handler = new CreateAreaHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => 
                x.CreateAsync(It.Is<Area>(x => x.InspectorId == InspectorId && x.Name == District), 
                CancellationToken.None)
            );
        }

        private CreateAreaCommand CreateTestCommand()
        {
            return new CreateAreaCommand()
            {
                Name = District,
                InspectorId = InspectorId
            }; 
        }
    }
}
