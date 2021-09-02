using AutoMapper;
using TaxService.Application.Mappings;

namespace UnitTests.Application.Features
{
    public class FeatureTestsContext
    {
        public IMapper Mapper { get; private set; }

        public FeatureTestsContext()
        {
            Mapper = ConfigureMapper();
        }

        private IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<RequestMapperProfile>()
            );
            return new Mapper(config);
        }
    }
}
