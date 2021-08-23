using System.Threading.Tasks;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace IntegrationTests.Web.TestData
{
    internal class InspectorSeed
    {
        private static Inspector[] _source = new Inspector[]
        {
            new Inspector() {
                Id = 1,
                Login = "FakeLogin",
                Password = "FakePassword"
            },
            new Inspector() {
                Id = 2,
                Login = "FakeLogin2",
                Password = "FakePassword2"
            }
        };

        public static async Task SeedAsync(AppDbContext context)
        {
            foreach (var inspector in _source)
            {
                if (context.Inspectors.Find(inspector.Id) == null)
                    await context.Inspectors.AddAsync(inspector);
            }
            await context.SaveChangesAsync();
        }
    }
}
