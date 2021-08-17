using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class GetReportTemplatesTests : FeatureTestBase
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
        private GetReportTemplatesQuery _query;
        private GetReportTemplatesHandler _handler;

        public GetReportTemplatesTests()
        {
            _repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            _query = new GetReportTemplatesQuery();
            var mapper = ConfigureMapper();
            _handler = new GetReportTemplatesHandler(_repoMock.Object, mapper);
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            await _handler.Handle(_query, CancellationToken.None);

            _repoMock.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await _handler.Handle(_query, predefinedCancellationToken);

            _repoMock.Verify(x => x.GetAllAsync(predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_return_collection_with_correct_size()
        {
            _repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));

            var templates = await _handler.Handle(_query, CancellationToken.None);

            templates.Should().HaveCount(2);
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            _repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));

            var template = (await _handler.Handle(_query, CancellationToken.None)).First();

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

        private IEnumerable<ReportTemplate> GetTestData()
        {
            yield return new ReportTemplate()
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

            yield return new ReportTemplate()
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