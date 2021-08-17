using AutoMapper;
using TaxService.Application.Mappings;

namespace UnitTests.Application.Features
{
    public class FeatureTestBase
    {
        protected IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<RequestMapperProfile>()
            );
            return new Mapper(config);
        }
    }
}
