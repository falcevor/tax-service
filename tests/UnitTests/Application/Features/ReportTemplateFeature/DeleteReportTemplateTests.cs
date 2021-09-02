using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    [Collection("FeatureTests")]
    public class DeleteReportTemplateTests
    {
        private const int TempalateId = 13;

        private DeleteReportTemplateCommand _command;

        public DeleteReportTemplateTests(FeatureTestsContext context)
        {
            _command = new DeleteReportTemplateCommand()
            {
                Id = TempalateId
            };
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new DeleteReportTemplateHandler(repoMock.Object);

            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new DeleteReportTemplateHandler(repoMock.Object);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(_command, token);

            repoMock.Verify(x => x.DeleteAsync(It.IsAny<int>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new DeleteReportTemplateHandler(repoMock.Object);
            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.DeleteAsync(TempalateId, It.IsAny<CancellationToken>()));
        }
    }
}
