using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class DeleteTaxpayerTests
    {
        private const int TaxpayerId = 13;

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var handler = new DeleteTaxpayerHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var handler = new DeleteTaxpayerHandler(repo.Object);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(command, token);

            repo.Verify(x => x.DeleteAsync(It.IsAny<int>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var handler = new DeleteTaxpayerHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.DeleteAsync(TaxpayerId, It.IsAny<CancellationToken>()));
        }

        private DeleteTaxpayerCommand CreateTestCommand()
        {
            return new DeleteTaxpayerCommand()
            {
                Id = TaxpayerId
            };
        }
    }
}
