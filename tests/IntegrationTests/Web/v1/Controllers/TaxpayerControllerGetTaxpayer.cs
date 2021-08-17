using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using System.Net.Http.Json;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;
using FluentAssertions;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using System.Collections.Generic;

namespace FunctionalTests.Web.v1.Controllers
{
    [Collection("TaxpayerFeature")]
    public class TaxpayerControllerGetTaxpayer : IClassFixture<TestWebServer>
    {
        private readonly HttpClient _client;
        private readonly string _controllerUrl = "/api/v1/Taxpayer";

        public TaxpayerControllerGetTaxpayer(TestWebServer factory)
        {
            _client = factory.Client;
        }

        [Fact]
        public async Task GetTaxpayer_should_return_nothing_by_unknown_id()
        {
            var response = await _client.GetAsync(_controllerUrl + "/GetTaxpayer?id=64");
            var content = await response.Content.ReadAsStringAsync();

            content.Should().BeEmpty();
        }

        [Fact]
        public async Task GetTaxpayer_should_return_404NotFound_by_unknown_id()
        {
            var response = await _client.GetAsync(_controllerUrl + "/GetTaxpayer?id=64");

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetTaxpayer_should_return_taxpayer_json_by_known_id()
        {
            var response = await _client.GetFromJsonAsync<GetTaxpayerByIdResponse>(_controllerUrl + "/GetTaxpayer?id=1");

            response.Id.Should().Be(1);
            response.Name.Should().Be("Ivanov Ivan Ivanovich");
        }

        [Fact]
        public async Task GetTaxpayer_should_return_200Ok_by_known_id()
        {
            var response = await _client.GetAsync(_controllerUrl + "/GetTaxpayer?id=1");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetTaxpayers_should_return_200Ok()
        {
            var response = await _client.GetAsync(_controllerUrl + "/GetTaxpayers");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetTaxpayers_should_return_taxpayer_collection()
        {
            var response = await _client.GetFromJsonAsync<IEnumerable<GetTaxpayersResponse>>(_controllerUrl + "/GetTaxpayers");

            response.Should().HaveCount(3);
            response.Should().Contain(x => x.Id == 1);
            response.Should().Contain(x => x.Id == 2);
            response.Should().Contain(x => x.Id == 3);
        }
    }
}
