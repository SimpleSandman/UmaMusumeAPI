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
    public class RaceProperGroundRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperGroundRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperGroundRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperGroundRate>>> GetRaceProperGroundRates()
        {
            return await _context.RaceProperGroundRates.ToListAsync();
        }

        // GET: api/RaceProperGroundRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperGroundRate>> GetRaceProperGroundRate(int id)
        {
            var raceProperGroundRate = await _context.RaceProperGroundRates.FindAsync(id);

            if (raceProperGroundRate == null)
            {
                return NotFound();
            }

            return raceProperGroundRate;
        }
    }
}
