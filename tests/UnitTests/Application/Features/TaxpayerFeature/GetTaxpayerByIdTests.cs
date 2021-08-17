using FluentAssertions;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class GetTaxpayerByIdTests : FeatureTestBase
    {
        private const string Name = "Name";
        private const string AdditionalInfo = "AdditionalInfo";
        private const string Inn = "Inn";
        private const string Kpp = "Kpp";
        private const string PlaceAddress = "PlaceAddress";
        private const int TaxpayerId = 13;
        private const int CategoryId = 43;
        private const int AreaId = 42;
        private const int Percent = 13;
        private const int PlaceTypeId = 134;
        private const int TaxTypeId = 43;
        private DateTime BeginDate = DateTime.Now;

        private Mock<IAsyncRepository<Taxpayer>> _repoMock;
        private GetTaxpayerByIdQuery _query;
        private GetTaxpayerByIdHandler _handler;

        public GetTaxpayerByIdTests()
        {
            _repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            _query = new GetTaxpayerByIdQuery()
            {
                Id = 13
            };
            var mapper = ConfigureMapper();
            _handler = new GetTaxpayerByIdHandler(_repoMock.Object, mapper);
        }

        [Fact]
        public async Task Should_call_repository_method()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            await _handler.Handle(_query, CancellationToken.None);

            _repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await _handler.Handle(_query, predefinedCancellationToken);

            _repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            var taxpayer = await _handler.Handle(_query, CancellationToken.None);

            taxpayer.Id.Should().Be(TaxpayerId);
            taxpayer.Name.Should().Be(Name);
            taxpayer.AdditionalInfo.Should().Be(AdditionalInfo);
            taxpayer.BeginDate.Should().Be(BeginDate);
            taxpayer.Inn.Should().Be(Inn);
            taxpayer.Kpp.Should().Be(Kpp);
            taxpayer.Percent.Should().Be(Percent);
            taxpayer.PlaceAddress.Should().Be(PlaceAddress);
            taxpayer.Area.Id.Should().Be(AreaId);
            taxpayer.Category.Id.Should().Be(CategoryId);
            taxpayer.PlaceType.Id.Should().Be(PlaceTypeId);
            taxpayer.TaxType.Id.Should().Be(TaxTypeId);
        }

        [Fact]
        public async Task Should_throw_NotFoundException_if_value_not_found()
        {
            _repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult((Taxpayer)null));

            await _handler.Invoking(async x => await x.Handle(_query, CancellationToken.None))
                .Should()
                .ThrowAsync<NotFoundException>();
        }

        private Taxpayer GetTestData()
        {
            return new Taxpayer()
            {
                Id = TaxpayerId,
                Name = Name,
                AdditionalInfo = AdditionalInfo,
                BeginDate = BeginDate,
                Inn = Inn,
                Kpp = Kpp,
                Percent = Percent,
                PlaceAddress = PlaceAddress,
                AreaId = AreaId,
                CategoryId = CategoryId,
                PlaceTypeId = PlaceTypeId,
                TaxTypeId = TaxTypeId,
                Area = new Area() { Id = AreaId },
                Category = new TaxpayerCategory() { Id = CategoryId },
                PlaceType = new PlaceType() { Id = PlaceTypeId },
                TaxType = new TaxType() { Id = TaxTypeId }
            };
        } 
    }
}