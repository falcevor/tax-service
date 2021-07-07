using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using System.Net.Http.Json;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;

namespace FunctionalTests.Web.v1.Controllers
{
    [Collection("TaxpayerFeature")]
    public class TaxpayerControllerGetTaxpayer : IClassFixture<TestWebServer>
    {
        private readonly HttpClient _client;
        private readonly string _actionUrl = "/api/v1/Taxpayer/GetTaxpayer";

        public TaxpayerControllerGetTaxpayer(TestWebServer factory)
        {
            _client = factory.Client;
        }

        [Fact]
        public async Task ReturnsNothingByUnknownId()
        {
            var response = await _client.GetAsync(_actionUrl + "?id=64");
            Assert.Empty(await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task Returns404NotFoundByUnknownId()
        {
            var response = await _client.GetAsync(_actionUrl + "?id=64");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnsTaxpayerJsonByKnownId()
        {
            var response = await _client.GetFromJsonAsync<GetTaxpayerByIdResponse>(_actionUrl + "?id=1");
            Assert.Equal(1, response.Id);
            Assert.Equal("Ivanov Ivan Ivanovich", response.Name);
        }

        [Fact]
        public async Task Returns200OkByKnownId()
        {
            var response = await _client.GetAsync(_actionUrl + "?id=1");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
