using MediatR;
using System;

namespace TaxService.Application.Features.TaxpayerFeature.Commands.Create
{
    public class CreateTaxpayerCommand : IRequest
    {
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public string AdditionalInfo { get; set; }
        public string PlaceAddress { get; set; }
        public int CategoryId { get; set; }
        public int TaxTypeId { get; set; }
        public int PlaceTypeId { get; set; }
        public int AreaId { get; set; }
        public DateTime BeginDate { get; set; }
    }
}
