using System.Threading.Tasks;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace FunctionalTests.Web.TestData
{
    internal class TaxpayerSeed
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            await context.Taxpayers.AddRangeAsync(new Taxpayer[]{ 
                new() {Id = 1, Name = "Ivanov Ivan Ivanovich", Inn = "3223322", Kpp="54321", Percent = 18 },
                new() {Id = 2, Name = "Petrov Petr Petrovich", Inn = "3223322", Kpp="54321", Percent = 18 },
                new() {Id = 3, Name = "Sidorov Sidor Sidorovich", Inn = "3223322", Kpp="54321", Percent = 18 },
            });
            await context.SaveChangesAsync();
        }
    }
}
