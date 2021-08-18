using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using TaxService.Api.v1.Controllers;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;
using Xunit;

namespace UnitTests.API
{
    public class ReportTempalteControllerTests
    {
        private Mock<IMediator> _mediatorMock;
        private ReportTemplateController _controller;

        public ReportTempalteControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new ReportTemplateController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetReportTempalates_should_return_200OK_response()
        {
            var response = await _controller.GetReportTempalates();
            response.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async Task GetReportTempalates_should_return_collection()
        {
            var expected = DataBuilder.BuildGetReportTemplatesResponseCollection();
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetReportTemplatesQuery>(), default))
                .Returns(Task.FromResult(expected));

            var response = await _controller.GetReportTempalates();

            (response.Result as OkObjectResult).Value.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task GetReportTemplate_should_return_200OK_response()
        {
            var response = await _controller.GetReportTemplate(1);
            response.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async Task GetReportTemplate_should_return_collection()
        {
            var expected = DataBuilder.BuildGetReportTemplateByIdResponse();
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetReportTemplateByIdQuery>(), default))
                .Returns(Task.FromResult(expected));

            var response = await _controller.GetReportTemplate(1);

            (response.Result as OkObjectResult).Value.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task CreateReportTemplate_should_return_200OK_response()
        {
            var request = DataBuilder.BuildCreateReportTemplateCommand();

            var response = await _controller.CreateReportTemplate(request);

            response.Should().BeOfType(typeof(OkResult));
        }

        [Fact]
        public async Task UpdateReportTemplate_should_return_200OK_response()
        {
            var request = DataBuilder.BuildUpdateReportTemplateCommand();

            var response = await _controller.UpdateReportTemplate(request);

            response.Should().BeOfType(typeof(OkResult));
        }

        [Fact]
        public async Task DeleteReportTemplate_should_return_200OK_response()
        { 
            var response = await _controller.DeleteReportTemplate(1);

            response.Should().BeOfType(typeof(OkResult));
        }
    }
}
