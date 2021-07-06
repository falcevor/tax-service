using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http.Json;
using TaxService.Domain.Model;
using System;
using System.Net;

namespace FunctionalTests.Web.v1.Controllers
{
    [Collection("TaxpayerFeature")]
    public class TaxpayerControllerGetTaxpayer : IClassFixture<TestWebServer>
    {
        private readonly HttpClient _client;

        public TaxpayerControllerGetTaxpayer(TestWebServer factory)
        {
            _client = factory.Client;
        }

        [Fact]
        public async Task ReturnsNothingByUnknownId()
        {
            var response = await _client.GetAsync("/api/v1/Taxpayer/GetTaxpayer?id=64");
            Assert.Empty(await response.Content.ReadAsStringAsync());
        }
    }
}
