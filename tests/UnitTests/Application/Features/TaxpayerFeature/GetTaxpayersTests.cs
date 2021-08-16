using AutoMapper;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using TaxService.Application.Mappings;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;
using Xunit;

namespace UnitTests.Application.Features.TaxpayerFeature
{
    public class GetTaxpayersTests
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

        [Fact]
        public async Task Should_call_repository_method()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetTaxpayersHandler(repo.Object, mapper);

            await handler.Handle(command, CancellationToken.None);

            repo.Verify(x => x.GetAllAsync(It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task Should_use_predefined_CancellationToken()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetTaxpayersHandler(repo.Object, mapper);
            var predefinedCancellationToken = new CancellationTokenSource().Token;

            await handler.Handle(command, predefinedCancellationToken);

            repo.Verify(x => x.GetAllAsync(predefinedCancellationToken));
        }

        [Fact]
        public async Task Should_return_collection_with_correct_size()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            repo.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetTaxpayersHandler(repo.Object, mapper);

            var templates = await handler.Handle(command, CancellationToken.None);

            templates.Should().HaveCount(2);
        }

        [Fact]
        public async Task Should_correctly_map_response_fields()
        {
            var repo = new Mock<IAsyncRepository<Taxpayer>>();
            repo.Setup(x => x.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(GetTestData().AsQueryable()));
            var command = CreateTestCommand();
            var mapper = ConfigureMapper();
            var handler = new GetTaxpayersHandler(repo.Object, mapper);

            var taxpayer = (await handler.Handle(command, CancellationToken.None)).First();

            taxpayer.Id.Should().Be(TaxpayerId);
            taxpayer.Name.Should().Be(Name);
            taxpayer.AdditionalInfo.Should().Be(AdditionalInfo);
            taxpayer.AreaId.Should().Be(AreaId);
            taxpayer.BeginDate.Should().Be(BeginDate);
            taxpayer.CategoryId.Should().Be(CategoryId);
            taxpayer.Inn.Should().Be(Inn);
            taxpayer.Kpp.Should().Be(Kpp);
            taxpayer.Percent.Should().Be(Percent);
            taxpayer.PlaceAddress.Should().Be(PlaceAddress);
            taxpayer.PlaceTypeId.Should().Be(PlaceTypeId);
            taxpayer.TaxTypeId.Should().Be(TaxTypeId);
        }

        public GetTaxpayersQuery CreateTestCommand()
        {
            return new GetTaxpayersQuery();
        }

        private IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<RequestMapperProfile>()
            );
            return new Mapper(config);
        }

        private IEnumerable<Taxpayer> GetTestData()
        {
            yield return new Taxpayer()
            {
                Id = TaxpayerId,
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

            yield return new Taxpayer()
            {
                Id = TaxpayerId,
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