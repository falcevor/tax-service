using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class DeleteReportTemplateTests : FeatureTestBase
    {
        private const int TempalateId = 13;

        private Mock<IAsyncRepository<ReportTemplate>> _repoMock;
        private DeleteReportTemplateCommand _command;
        private DeleteReportTemplateHandler _handler;

        public DeleteReportTemplateTests()
        {
            _repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            _command = new DeleteReportTemplateCommand()
            {
                Id = TempalateId
            };
            _handler = new DeleteReportTemplateHandler(_repoMock.Object);
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

            _repoMock.Verify(x => x.DeleteAsync(TempalateId, It.IsAny<CancellationToken>()));
        }
    }
}
