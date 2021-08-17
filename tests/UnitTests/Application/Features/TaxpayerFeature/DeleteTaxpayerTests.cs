using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class DeleteTaxpayerTests : FeatureTestBase
    {
        private const int TaxpayerId = 13;

        private Mock<IAsyncRepository<Taxpayer>> _repoMock;
        private DeleteTaxpayerCommand _command;
        private DeleteTaxpayerHandler _handler;

        public DeleteTaxpayerTests()
        {
            _repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            _command = new DeleteTaxpayerCommand()
            {
                Id = TaxpayerId
            };
            _handler = new DeleteTaxpayerHandler(_repoMock.Object);
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var token = new CancellationTokenSource().Token;

            await _handler.Handle(_command, token);

            _repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.DeleteAsync(TaxpayerId, It.IsAny<CancellationToken>()));
        }
    }
}
