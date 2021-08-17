using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Update;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class UpdateReportTemplateTests : FeatureTestBase
    {
        private const string Description = "Description";
        private const string TemplateName = "TemplateName";
        private byte[] TemplateFile = new byte[] { 1, 2, 3, 4, 5 };
        private const string ParameterName = "name";
        private const string ParameterDescription = "user name";
        private const string ParameterDefaultValue = "Ivanov";

        private Mock<IAsyncRepository<ReportTemplate>> _repoMock;
        private UpdateReportTemplateCommand _command;
        private UpdateReportTemplateHandler _handler;

        public UpdateReportTemplateTests()
        {
            _repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            _command = CreateTestCommand();
            var mapper = ConfigureMapper();
            _handler = new UpdateReportTemplateHandler(_repoMock.Object, mapper);
        }


        [Fact]
        public async Task Should_call_repository_method()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.UpdateAsync(It.IsAny<ReportTemplate>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var token = new CancellationTokenSource().Token;

            await _handler.Handle(_command, token);

            _repoMock.Verify(x => x.UpdateAsync(It.IsAny<ReportTemplate>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.UpdateAsync(
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

        private UpdateReportTemplateCommand CreateTestCommand()
        {
            return new UpdateReportTemplateCommand()
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
    }
}
