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
    public class RaceProperRunningstyleRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperRunningstyleRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperRunningstyleRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperRunningstyleRate>>> GetRaceProperRunningstyleRates()
        {
            return await _context.RaceProperRunningstyleRates.ToListAsync();
        }

        // GET: api/RaceProperRunningstyleRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperRunningstyleRate>> GetRaceProperRunningstyleRate(int id)
        {
            var raceProperRunningstyleRate = await _context.RaceProperRunningstyleRates.FindAsync(id);

            if (raceProperRunningstyleRate == null)
            {
                return NotFound();
            }

            return raceProperRunningstyleRate;
        }
    }
}
