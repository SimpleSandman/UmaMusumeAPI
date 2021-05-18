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
    public class RaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/Race
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Race>>> GetRaces()
        {
            return await _context.Races.ToListAsync();
        }

        // GET: api/Race/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Race>> GetRace(int id)
        {
            var race = await _context.Races.FindAsync(id);

            if (race == null)
            {
                return NotFound();
            }

            return race;
        }
    }
}
