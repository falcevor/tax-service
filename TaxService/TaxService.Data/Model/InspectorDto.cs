using System.Collections.Generic;

namespace TaxService.Data.Model
{
    public class InspectorDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IEnumerable<AreaDto> Areas { get; set; }
    }
}
