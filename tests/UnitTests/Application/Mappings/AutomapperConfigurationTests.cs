using AutoMapper;
using TaxService.Application.Mappings;
using Xunit;

namespace UnitTests.Application.Mappings
{
    public class AutomapperConfigurationTests
    {
        [Fact]
        public void Should_be_valid_automapper_configuration()
        {
            var config = new MapperConfiguration(x => x.AddProfile(new RequestMapperProfile()));
            config.AssertConfigurationIsValid();
        }
    }
}
