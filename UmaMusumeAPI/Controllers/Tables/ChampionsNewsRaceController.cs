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
    public class ChampionsNewsRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsRace>>> GetChampionsNewsRaces()
        {
            return await _context.ChampionsNewsRaces.ToListAsync();
        }

        // GET: api/ChampionsNewsRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsRace>> GetChampionsNewsRace(int id)
        {
            var championsNewsRace = await _context.ChampionsNewsRaces.FindAsync(id);

            if (championsNewsRace == null)
            {
                return NotFound();
            }

            return championsNewsRace;
        }
    }
}
