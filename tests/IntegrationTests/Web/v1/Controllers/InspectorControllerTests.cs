using FluentAssertions;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TaxService.Application.Features.InspectorFeature.Queries.GetAll;
using Xunit;

namespace IntegrationTests.Web.v1.Controllers
{
    [Collection("WebTests")]
    public class InspectorControllerTests
    {
        private readonly HttpClient _client;
        private readonly string _controllerUrl = "/api/v1/Inspector";

        public InspectorControllerTests(TestWebServer factory)
        {
            _client = factory.Client;
        }

        [Fact]
        public async Task GetInspectors_should_return_200Ok()
        {
            var response = await _client.GetAsync(_controllerUrl + "/GetInspectors");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetInspectors_should_return_taxpayer_collection()
        {
            var response = await _client.GetFromJsonAsync<IEnumerable<GetInspectorsResponse>>(_controllerUrl + "/GetInspectors");

            response.Should().HaveCount(2);
            response.Should().Contain(x => x.Id == 1);
            response.Should().Contain(x => x.Id == 2);
        }
    }
}
