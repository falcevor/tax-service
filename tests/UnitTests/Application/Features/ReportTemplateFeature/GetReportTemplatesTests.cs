using AutoMapper;
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
    [Collection("FeatureTests")]
    public class GetReportTemplatesTests
    {
        private const int TemplateId = 13;
        private const string Description = "Description";
        private const string TemplateName = "TemplateName";
        private byte[] TemplateFile = new byte[] { 1, 2, 3, 4, 5 };
        private const int ParameterId = 14;
        private const string ParameterName = "name";
        private const string ParameterDescription = "user name";
        private const string ParameterDefaultValue = "Ivanov";

        private GetReportTemplatesQuery _query;
        private IMapper _mapper;

        public GetReportTemplatesTests(FeatureTestsContext context)
        {
            _mapper = context.Mapper;
            _query = new GetReportTemplatesQuery();
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new GetReportTemplatesHandler(repoMock.Object, _mapper);

            await handler.Handle(_query, CancellationToken.None);

            repoMock.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new GetReportTemplatesHandler(repoMock.Object, _mapper);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(_query, predefinedCancellationToken);

            repoMock.Verify(x => x.GetAllAsync(predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_return_collection_with_correct_size()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new GetReportTemplatesHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));

            var templates = await handler.Handle(_query, CancellationToken.None);

            templates.Should().HaveCount(2);
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            var repoMock = new Mock<IAsyncRepository<ReportTemplate>>();
            var handler = new GetReportTemplatesHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));

            var template = (await handler.Handle(_query, CancellationToken.None)).First();

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