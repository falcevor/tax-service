using System.Threading.Tasks;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace IntegrationTests.Web.TestData
{
    internal class TaxpayerSeed
    {
        private static Taxpayer[] _source = new Taxpayer[]
        {
            new() {Id = 1, Name = "Ivanov Ivan Ivanovich", Inn = "3223322", Kpp="54321", Percent = 18 },
            new() {Id = 2, Name = "Petrov Petr Petrovich", Inn = "3223322", Kpp="54321", Percent = 18 },
            new() {Id = 3, Name = "Sidorov Sidor Sidorovich", Inn = "3223322", Kpp="54321", Percent = 18 },
        };

        public static async Task SeedAsync(AppDbContext context)
        {
            foreach (var taxpayer in _source)
            {
                if (context.Taxpayers.Find(taxpayer.Id) == null)
                    await context.Taxpayers.AddAsync(taxpayer);
            }
            await context.SaveChangesAsync();
        }

    }
}
