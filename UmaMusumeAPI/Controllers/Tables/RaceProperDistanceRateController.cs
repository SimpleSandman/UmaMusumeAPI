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
    public class RaceProperDistanceRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperDistanceRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperDistanceRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperDistanceRate>>> GetRaceProperDistanceRates()
        {
            return await _context.RaceProperDistanceRates.ToListAsync();
        }

        // GET: api/RaceProperDistanceRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperDistanceRate>> GetRaceProperDistanceRate(int id)
        {
            var raceProperDistanceRate = await _context.RaceProperDistanceRates.FindAsync(id);

            if (raceProperDistanceRate == null)
            {
                return NotFound();
            }

            return raceProperDistanceRate;
        }
    }
}
