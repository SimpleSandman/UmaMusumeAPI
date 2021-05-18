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
    public class RaceMotivationRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceMotivationRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceMotivationRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceMotivationRate>>> GetRaceMotivationRates()
        {
            return await _context.RaceMotivationRates.ToListAsync();
        }

        // GET: api/RaceMotivationRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceMotivationRate>> GetRaceMotivationRate(int id)
        {
            var raceMotivationRate = await _context.RaceMotivationRates.FindAsync(id);

            if (raceMotivationRate == null)
            {
                return NotFound();
            }

            return raceMotivationRate;
        }
    }
}
