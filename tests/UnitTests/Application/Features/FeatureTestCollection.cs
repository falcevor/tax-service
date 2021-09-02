using Xunit;

namespace UnitTests.Application.Features
{
    [CollectionDefinition("FeatureTests")]
    public class FeatureTestCollection : ICollectionFixture<FeatureTestsContext>
    {
    }
}
