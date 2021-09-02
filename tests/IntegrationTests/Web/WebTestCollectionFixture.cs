using Xunit;

namespace IntegrationTests.Web
{
    [CollectionDefinition("WebTests")]
    public class WebTestCollectionFixture : ICollectionFixture<TestWebServer>
    {
    }
}
