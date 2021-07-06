using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using Xunit;

namespace FunctionalTests.Web.v1.Controllers
{
    public class TaxpayerControllerGetTaxpayers : IClassFixture<TestWebServer>
    {
        private readonly HttpClient _client;
        private readonly string _actionUrl = "/api/v1/Taxpayer/GetTaxpayers";

        public TaxpayerControllerGetTaxpayers(TestWebServer testServer)
        {
            _client = testServer.Client;
        }

        [Fact]
        public async Task Returns200Ok()
        {
            var response = await _client.GetAsync(_actionUrl);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnsTaxpayerCollection()
        {
            var response = await _client.GetFromJsonAsync<IEnumerable<GetTaxpayersResponse>>(_actionUrl);
            Assert.NotEmpty(response);
            Assert.Contains(response, x => x.Id == 1);
            Assert.Contains(response, x => x.Id == 2);
            Assert.Contains(response, x => x.Id == 3);
        }
    }
}
