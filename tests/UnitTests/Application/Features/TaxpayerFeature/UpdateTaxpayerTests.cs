using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Commands.Update;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class UpdateTaxpayerTests : FeatureTestBase
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

        private Mock<IAsyncRepository<Taxpayer>> _repoMock;
        private UpdateTaxpayerCommand _command;
        private UpdateTaxpayerHandler _handler;

        public UpdateTaxpayerTests()
        {
            _repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            _command = CreateTestCommand();
            var mapper = ConfigureMapper();
            _handler = new UpdateTaxpayerHandler(_repoMock.Object, mapper);
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.UpdateAsync(It.IsAny<Taxpayer>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var token = new CancellationTokenSource().Token;

            await _handler.Handle(_command, token);

            _repoMock.Verify(x => x.UpdateAsync(It.IsAny<Taxpayer>(), token));
        }

        [Fact]
        public async Task Should_correctly_map_command_fields()
        {
            await _handler.Handle(_command, CancellationToken.None);

            _repoMock.Verify(x => x.UpdateAsync(
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

        private UpdateTaxpayerCommand CreateTestCommand()
        {
            return new UpdateTaxpayerCommand()
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
