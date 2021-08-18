using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using TaxService.Api.v1.Controllers;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;
using Xunit;

namespace UnitTests.API
{
    public class TaxpayerControllerTests
    {
        private Mock<IMediator> _mediatorMock;
        private TaxpayerController _controller;

        public TaxpayerControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new TaxpayerController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetTaxpayers_should_return_200OK_response()
        {
            var response = await _controller.GetTaxpayers();
            response.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async Task GetTaxpayers_should_return_collection()
        {
            var expected = DataBuilder.BuildGetTaxpayersResponseCollection();
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetTaxpayersQuery>(), default))
                .Returns(Task.FromResult(expected));

            var response = await _controller.GetTaxpayers();

            (response.Result as OkObjectResult).Value.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task GetTaxpayer_should_return_200OK_response()
        {
            var response = await _controller.GetTaxpayer(1);
            response.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async Task GetTaxpayer_should_return_collection()
        {
            var expected = DataBuilder.BuildGetTaxpayerByIdResponse();
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetTaxpayerByIdQuery>(), default))
                .Returns(Task.FromResult(expected));

            var response = await _controller.GetTaxpayer(1);

            (response.Result as OkObjectResult).Value.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task CreateTaxpayer_should_return_200OK_response()
        {
            var request = DataBuilder.BuildCreateTaxpayerCommand();

            var response = await _controller.CreateTaxpayer(request);

            response.Should().BeOfType(typeof(OkResult));
        }

        [Fact]
        public async Task UpdateTaxpayer_should_return_200OK_response()
        {
            var request = DataBuilder.BuildUpdateTaxpayerCommand();

            var response = await _controller.UpdateTaxpayer(request);

            response.Should().BeOfType(typeof(OkResult));
        }

        [Fact]
        public async Task DeleteTaxpayer_should_return_200OK_response()
        {
            var response = await _controller.DeleteTaxpayer(1);

            response.Should().BeOfType(typeof(OkResult));
        }
    }
}
