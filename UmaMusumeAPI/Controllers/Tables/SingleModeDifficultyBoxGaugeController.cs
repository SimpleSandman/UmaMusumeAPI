using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleModeDifficultyBoxGaugeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyBoxGaugeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyBoxGauge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyBoxGauge>>> GetSingleModeDifficultyBoxGauges()
        {
            return await _context.SingleModeDifficultyBoxGauges.ToListAsync();
        }

        // GET: api/SingleModeDifficultyBoxGauge/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyBoxGauge>> GetSingleModeDifficultyBoxGauge(int id)
        {
            var singleModeDifficultyBoxGauge = await _context.SingleModeDifficultyBoxGauges.FindAsync(id);

            if (singleModeDifficultyBoxGauge == null)
            {
                return NotFound();
            }

            return singleModeDifficultyBoxGauge;
        }
    }
}
