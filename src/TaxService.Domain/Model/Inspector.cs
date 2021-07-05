using System.Collections.Generic;

namespace TaxService.Domain.Model
{
    public class Inspector
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IEnumerable<Area> Areas { get; set; }
    }
}
