using AutoMapper;
using FluentAssertions;
using Moq;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;
using TaxService.Application.Mappings;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.ReportTemplateFeature
{
    public class GetReportTemplateByIdTests
    {
        private const int TemplateId = 13;
        private const string Description = "Description";
        private const string TemplateName = "TemplateName";
        private byte[] TemplateFile = new byte[] { 1, 2, 3, 4, 5 };
        private const int ParameterId = 14;
        private const string ParameterName = "name";
        private const string ParameterDescription = "user name";
        private const string ParameterDefaultValue = "Ivanov";

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            repo.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplateByIdHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            repo.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplateByIdHandler(repo.Object, mapper);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(command, predefinedCancellationToken);

            repo.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            repo.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetReportTemplateByIdHandler(repo.Object, mapper);

            var template = await handler.Handle(command, CancellationToken.None);

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
            var repo = new Mock<IAsyncRepository<ReportTemplate>>();
            var mapper = ConfigureMapper();
            var command = CreateTestCommand();
            var handler = new GetReportTemplateByIdHandler(repo.Object, mapper);

            await handler.Invoking(async x => await x.Handle(command, CancellationToken.None))
                .Should()
                .ThrowAsync<NotFoundException>();
        }

        public GetReportTemplateByIdQuery CreateTestCommand()
        {
            return new GetReportTemplateByIdQuery() 
            { 
                Id = 13
            };
        }

        private IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<RequestMapperProfile>()
            );
            return new Mapper(config);
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