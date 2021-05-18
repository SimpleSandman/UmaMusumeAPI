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
    public class RaceJikkyoRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoRace>>> GetRaceJikkyoRaces()
        {
            return await _context.RaceJikkyoRaces.ToListAsync();
        }

        // GET: api/RaceJikkyoRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoRace>> GetRaceJikkyoRace(int id)
        {
            var raceJikkyoRace = await _context.RaceJikkyoRaces.FindAsync(id);

            if (raceJikkyoRace == null)
            {
                return NotFound();
            }

            return raceJikkyoRace;
        }
    }
}
