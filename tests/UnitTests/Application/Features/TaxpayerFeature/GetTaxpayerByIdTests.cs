using AutoMapper;
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
    [Collection("FeatureTests")]
    public class GetTaxpayerByIdTests
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

        private GetTaxpayerByIdQuery _query;
        private IMapper _mapper;

        public GetTaxpayerByIdTests(FeatureTestsContext context)
        {
            _mapper = context.Mapper;
            _query = new GetTaxpayerByIdQuery()
            {
                Id = 13
            };
        }

        [Fact]
        public async Task Should_call_repository_method()
        {

            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new GetTaxpayerByIdHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            await handler.Handle(_query, CancellationToken.None);

            repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new GetTaxpayerByIdHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(_query, predefinedCancellationToken);

            repoMock.Verify(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new GetTaxpayerByIdHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData()));

            var taxpayer = await handler.Handle(_query, CancellationToken.None);

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
            var repoMock = new Mock<IAsyncRepository<Taxpayer>>();
            var handler = new GetTaxpayerByIdHandler(repoMock.Object, _mapper);
            repoMock.Setup(x => x.GetAsync(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult((Taxpayer)null));

            await handler.Invoking(async x => await x.Handle(_query, CancellationToken.None))
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