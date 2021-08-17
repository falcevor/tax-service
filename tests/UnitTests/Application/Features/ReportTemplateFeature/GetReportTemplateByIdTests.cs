using FluentAssertions;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class GetReportTemplateByIdTests : FeatureTestBase
    {
        private const int TemplateId = 13;
        private const string Description = "Description";
        private const string TemplateName = "TemplateName";
        private byte[] TemplateFile = new byte[] { 1, 2, 3, 4, 5 };
        private const int ParameterId = 14;
        private const string ParameterName = "name";
        private const string ParameterDescription = "user name";
        private const string ParameterDefaultValue = "Ivanov";

        private Mock<IAsyncRepository<ReportTemplate>> _repoMock;
        private GetReportTemplateByIdQuery _query;
        private GetReportTemplateByIdHandler _handler;

        public GetReportTemplateByIdTests()
        {
            _repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            _query = new GetReportTemplateByIdQuery()
            {
                Id = 13
            };
            var mapper = ConfigureMapper();
            _handler = new GetReportTemplateByIdHandler(_repoMock.Object, mapper);
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            await _handler.Handle(_query, CancellationToken.None);

            _repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await _handler.Handle(_query, predefinedCancellationToken);

            _repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            var template = await _handler.Handle(_query, CancellationToken.None);

            template.Id.Should().Be(TemplateId);
            template.Name.Should().Be(TemplateName);
            template.Description.Should().Be(Description);
            template.File.Should().BeEquivalentTo(TemplateFile);
            template.Parameters.Should().HaveCount(1);
            template.Parameters.First().DefaultValue.Should().Be(ParameterDefaultValue);
            template.Parameters.First().Id.Should().Be(ParameterId);
            template.Parameters.First().Description.Should().Be(ParameterDescription);
            template.Parameters.First().Name.Should().Be(ParameterName);
        }

        [Fact]
        public async Task Should_throw_NotFoundException_if_value_not_found()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult((ReportTemplate)null));

            await _handler.Invoking(async x => await x.Handle(_query, CancellationToken.None))
                .Should()
                .ThrowAsync<NotFoundException>();
        }

        private ReportTemplate GetTestData()
        {
            return new ReportTemplate()
            {
                Id = TemplateId,
                Description = Description,
                Name = TemplateName,
                File = TemplateFile,
                Parameters = new[]
                {
                    new ReportTemplateParameter()
                    {
                        Id = ParameterId,
                        Name = ParameterName,
                        Description = ParameterDescription,
                        DefaultValue = ParameterDefaultValue
                    }
                }
            };
        } 
    }
}