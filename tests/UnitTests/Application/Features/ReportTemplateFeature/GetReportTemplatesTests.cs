using AutoMapper;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Mappings;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class GetReportTemplatesTests
    {
        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplatesHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplatesHandler(repo.Object, mapper);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(command, predefinedCancellationToken);

            repo.Verify(x => x.GetAllAsync(predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplatesHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);
            //todo:
        }

        public GetReportTemplatesQuery CreateTestCommand()
        {
            return new GetReportTemplatesQuery();
        }

        private IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<RequestMapperProfile>()
            );
            return new Mapper(config);
        }
    }
}
