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
    public class DailyRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRace>>> GetDailyRaces()
        {
            return await _context.DailyRaces.ToListAsync();
        }

        // GET: api/DailyRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRace>> GetDailyRace(int id)
        {
            var dailyRace = await _context.DailyRaces.FindAsync(id);

            if (dailyRace == null)
            {
                return NotFound();
            }

            return dailyRace;
        }
    }
}
