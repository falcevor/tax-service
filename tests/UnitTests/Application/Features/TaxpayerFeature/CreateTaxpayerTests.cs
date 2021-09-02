using AutoMapper;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Create;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    [Collection("FeatureTests")]
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

        private CreateTaxpayerCommand _command;
        private IMapper _mapper;

        public CreateTaxpayerTests(FeatureTestsContext context)
        {
            _mapper = context.Mapper;
            _command = CreateTestCommand();
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new CreateTaxpayerHandler(repoMock.Object, _mapper);

            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.CreateAsync(It.IsAny<Taxpayer>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new CreateTaxpayerHandler(repoMock.Object, _mapper);
            var token = new CancellationTokenSource().Token;

            await handler.Handle(_command, token);

            repoMock.Verify(x => x.CreateAsync(It.IsAny<Taxpayer>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new CreateTaxpayerHandler(repoMock.Object, _mapper);
            await handler.Handle(_command, CancellationToken.None);

            repoMock.Verify(x => x.CreateAsync(
                It.Is<Taxpayer>(taxpayer =>
                       taxpayer.Name == Name
                    && taxpayer.AdditionalInfo == AdditionalInfo
                    && taxpayer.AreaId == AreaId
                    && taxpayer.BeginDate == BeginDate
                    && taxpayer.CategoryId == CategoryId
                    && taxpayer.Inn == Inn
                    && taxpayer.Kpp == Kpp
                    && taxpayer.Percent == Percent
                    && taxpayer.PlaceAddress == PlaceAddress
                    && taxpayer.PlaceTypeId == PlaceTypeId
                    && taxpayer.TaxTypeId == TaxTypeId),
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
    }
}
