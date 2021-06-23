using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TaxService.Core;

namespace TaxService.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class TaxServiceController : ControllerBase
    {
        private readonly ITaxRepository _repo;
        private readonly ILogger<TaxServiceController> _logger;

        public TaxServiceController(ITaxRepository repo, ILogger<TaxServiceController> logger)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> Incomes(int taxpayerId, DateTime from, DateTime to)
        {
            var result = await _repo.GetIncomesAsync(taxpayerId, from, to).ToListAsync();
            return Ok(result);
        }
    }
}
