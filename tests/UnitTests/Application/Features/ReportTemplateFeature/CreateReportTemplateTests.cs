using AutoMapper;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Create;
using TaxService.Application.Mappings;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class CreateReportTemplateTests
    {
        private const string Description = "Description";
        private const string TemplateName = "TemplateName";
        private byte[] TemplateFile = new byte[] { 1, 2, 3, 4, 5 };
        private const string ParameterName = "name";
        private const string ParameterDescription = "user name";
        private const string ParameterDefaultValue = "Ivanov";

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateReportTemplateHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.CreateAsync(It.IsAny<ReportTemplate>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateReportTemplateHandler(repo.Object, mapper);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(command, token);

            repo.Verify(x => x.CreateAsync(It.IsAny<ReportTemplate>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateReportTemplateHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.CreateAsync(
                It.Is<ReportTemplate>(template =>
                    template.Description == Description
                    && template.Name == TemplateName
                    && template.File.Length == 5
                    && template.Parameters.Count == 1
                    && template.Parameters.First().Name == ParameterName
                    && template.Parameters.First().Description == ParameterDescription
                    && template.Parameters.First().DefaultValue == ParameterDefaultValue),
                It.IsAny<CancellationToken>()));
        }

        private CreateReportTemplateCommand CreateTestCommand()
        {
            return new CreateReportTemplateCommand()
            {
                Description = Description,
                Name = TemplateName,
                File = TemplateFile,
                Parameters = new[]
                {
                    new ReportTemplateParameter()
                    {
                        Name = ParameterName,
                        Description = ParameterDescription,
                        DefaultValue = ParameterDefaultValue
                    }
                }
            };
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
