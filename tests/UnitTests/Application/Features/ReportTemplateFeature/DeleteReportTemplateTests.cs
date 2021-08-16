using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Delete;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class DeleteReportTemplateTests
    {
        private const int TempalateId = 13;

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var handler = new DeleteReportTemplateHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var handler = new DeleteReportTemplateHandler(repo.Object);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(command, token);

            repo.Verify(x => x.DeleteAsync(It.IsAny<int>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var handler = new DeleteReportTemplateHandler(repo.Object);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.DeleteAsync(TempalateId, It.IsAny<CancellationToken>()));
        }

        private DeleteReportTemplateCommand CreateTestCommand()
        {
            return new DeleteReportTemplateCommand()
            {
                Id = TempalateId
            };
        }
    }
}
