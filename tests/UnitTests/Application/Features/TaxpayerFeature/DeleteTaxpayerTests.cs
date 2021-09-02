using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    [Collection("FeatureTests")]
    public class DeleteTaxpayerTests
    {
        private const int TaxpayerId = 13;

        private DeleteTaxpayerCommand _command;

        public DeleteTaxpayerTests(FeatureTestsContext context)
        {
            _command = new DeleteTaxpayerCommand()
            {
                Id = TaxpayerId
            };
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new DeleteTaxpayerHandler(repoMock.Object);

            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new DeleteTaxpayerHandler(repoMock.Object);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(_command, token);

            repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new DeleteTaxpayerHandler(repoMock.Object);

            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.DeleteAsync(TaxpayerId, It.IsAny<CancellationToken>()));
        }
    }
}
