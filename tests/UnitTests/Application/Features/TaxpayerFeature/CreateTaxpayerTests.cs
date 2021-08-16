using AutoMapper;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Create;
using TaxService.Application.Mappings;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class CreateTaxpayerTests
    {
        private const string Name = "Name";
        private const string AdditionalInfo = "AdditionalInfo";
        private const string Inn = "Inn";
        private const string Kpp = "Kpp";
        private const string PlaceAddress = "PlaceAddress";
        private const int CategoryId = 43;
        private const int AreaId = 42;
        private const int Percent = 13;
        private const int PlaceTypeId = 134;
        private const int TaxTypeId = 43;
        private DateTime BeginDate = DateTime.Now;

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateTaxpayerHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.CreateAsync(It.IsAny<Taxpayer>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateTaxpayerHandler(repo.Object, mapper);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(command, token);

            repo.Verify(x => x.CreateAsync(It.IsAny<Taxpayer>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new CreateTaxpayerHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.CreateAsync(
                It.Is<Taxpayer>(template =>
                       template.Name == Name
                    && template.AdditionalInfo == AdditionalInfo
                    && template.AreaId == AreaId
                    && template.BeginDate == BeginDate
                    && template.CategoryId == CategoryId
                    && template.Inn == Inn
                    && template.Kpp == Kpp
                    && template.Percent == Percent
                    && template.PlaceAddress == PlaceAddress
                    && template.PlaceTypeId == PlaceTypeId
                    && template.TaxTypeId == TaxTypeId),
                It.IsAny<CancellationToken>()));
        }

        private CreateTaxpayerCommand CreateTestCommand()
        {
            return new CreateTaxpayerCommand()
            {
                Name = Name,
                AdditionalInfo = AdditionalInfo,
                AreaId = AreaId,
                BeginDate = BeginDate,
                CategoryId = CategoryId,
                Inn = Inn,
                Kpp = Kpp,
                Percent = Percent,
                PlaceAddress = PlaceAddress,
                PlaceTypeId = PlaceTypeId,
                TaxTypeId = TaxTypeId
            };
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
