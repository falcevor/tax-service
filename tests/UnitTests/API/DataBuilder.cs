using System;
using System.Collections.Generic;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Create;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Update;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;
using TaxService.Application.Features.TaxpayerFeature.Commands.Create;
using TaxService.Application.Features.TaxpayerFeature.Commands.Update;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;
using TaxService.Domain.Model;

namespace UnitTests.API
{
    public static class DataBuilder
    {

        internal static CreateTaxpayerCommand BuildCreateTaxpayerCommand()
        {
            return new CreateTaxpayerCommand()
            {
                Name = "FakeIvanov",
                AdditionalInfo = "FakeInfo",
            };
        }

        internal static UpdateTaxpayerCommand BuildUpdateTaxpayerCommand()
        {
            return new UpdateTaxpayerCommand()
            {
                Name = "FakeIvanov",
                AdditionalInfo = "FakeInfo",
            };
        }

        internal static GetTaxpayerByIdResponse BuildGetTaxpayerByIdResponse()
        {
            return new GetTaxpayerByIdResponse()
            {
                Id = 1,
                Name = "FakeIvanov",
                AdditionalInfo = "FakeInfo",
                Area = new Area()
                {
                    Id = 13,
                    Name = "FakeMoscow"
                }
            };
        }

        internal static IEnumerable<GetTaxpayersResponse> BuildGetTaxpayersResponseCollection()
        {
            yield return new GetTaxpayersResponse()
            {
                Id = 1,
                Name = "FakeIvanov",
                AdditionalInfo = "FakeInfo",
                Area = new Area()
                {
                    Id = 13,
                    Name = "FakeMoscow"
                }
            };

            yield return new GetTaxpayersResponse()
            {
                Id = 2,
                Name = "FakeIvanov2",
                AdditionalInfo = "FakeInfo2",
                Area = new Area()
                {
                    Id = 1337,
                    Name = "FakeMoscow2"
                }
            };
        }

        internal static IEnumerable<GetReportTemplatesResponse> BuildGetReportTemplatesResponseCollection()
        {
            return new GetReportTemplatesResponse[]
            {
                new GetReportTemplatesResponse()
                {
                    Id = 1,
                    Description = "FakeDescription",
                    Name = "FakeName",
                    Parameters = new [] {
                        new ReportTemplateParameter()
                        {
                            Id = 2,
                            DefaultValue = "FakeValue",
                            Name = "FakeName",
                            Description = "FakeDescription"
                        },
                        new ReportTemplateParameter()
                        {
                            Id = 3,
                            DefaultValue = "FakeValue",
                            Name = "FakeName",
                            Description = "FakeDescription"
                        }
                    }
                },
                new GetReportTemplatesResponse()
                {
                    Id = 2,
                    Description = "FakeDescription2",
                    Name = "FakeName2",
                    Parameters = new [] {
                        new ReportTemplateParameter()
                        {
                            Id = 5,
                            DefaultValue = "FakeValue2",
                            Name = "FakeName2",
                            Description = "FakeDescription2"
                        },
                        new ReportTemplateParameter()
                        {
                            Id = 7,
                            DefaultValue = "FakeValue2",
                            Name = "FakeName2",
                            Description = "FakeDescription2"
                        }
                    }
                }
            };
        }

        internal static GetReportTemplateByIdResponse BuildGetReportTemplateByIdResponse()
        {
            return new GetReportTemplateByIdResponse()
            {
                Id = 1,
                Description = "FakeDescription",
                Name = "FakeName",
                Parameters = new[]
                {
                    new ReportTemplateParameter()
                    {
                        Id = 2,
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    },
                    new ReportTemplateParameter()
                    {
                        Id = 3,
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    }
                }
            };
        }

        internal static CreateReportTemplateCommand BuildCreateReportTemplateCommand()
        {
            return new CreateReportTemplateCommand()
            {
                Name = "FakeName",
                Description = "FakeDescription",
                Parameters = new[]
                {
                    new ReportTemplateParameter()
                    {
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    },
                    new ReportTemplateParameter()
                    {
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    }
                },
                File = new byte[] { 1, 2, 4, 5}
            };
        }

        internal static UpdateReportTemplateCommand BuildUpdateReportTemplateCommand()
        {
            return new UpdateReportTemplateCommand()
            {
                Name = "FakeName",
                Description = "FakeDescription",
                Parameters = new[]
                {
                    new ReportTemplateParameter()
                    {
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    },
                    new ReportTemplateParameter()
                    {
                        DefaultValue = "FakeValue",
                        Name = "FakeName",
                        Description = "FakeDescription"
                    }
                },
                File = new byte[] { 1, 2, 4, 5 }
            };
        }


    }
}
