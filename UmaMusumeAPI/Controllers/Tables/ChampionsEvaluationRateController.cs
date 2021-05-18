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
    public class ChampionsEvaluationRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsEvaluationRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsEvaluationRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsEvaluationRate>>> GetChampionsEvaluationRates()
        {
            return await _context.ChampionsEvaluationRates.ToListAsync();
        }

        // GET: api/ChampionsEvaluationRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsEvaluationRate>> GetChampionsEvaluationRate(int id)
        {
            var championsEvaluationRate = await _context.ChampionsEvaluationRates.FindAsync(id);

            if (championsEvaluationRate == null)
            {
                return NotFound();
            }

            return championsEvaluationRate;
        }
    }
}
