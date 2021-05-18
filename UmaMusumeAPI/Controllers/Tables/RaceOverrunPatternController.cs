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
    public class RaceOverrunPatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceOverrunPatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceOverrunPattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceOverrunPattern>>> GetRaceOverrunPatterns()
        {
            return await _context.RaceOverrunPatterns.ToListAsync();
        }

        // GET: api/RaceOverrunPattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceOverrunPattern>> GetRaceOverrunPattern(int id)
        {
            var raceOverrunPattern = await _context.RaceOverrunPatterns.FindAsync(id);

            if (raceOverrunPattern == null)
            {
                return NotFound();
            }

            return raceOverrunPattern;
        }
    }
}
