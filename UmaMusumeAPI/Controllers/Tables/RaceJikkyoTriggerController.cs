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
    public class RaceJikkyoTriggerController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoTriggerController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoTrigger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoTrigger>>> GetRaceJikkyoTriggers()
        {
            return await _context.RaceJikkyoTriggers.ToListAsync();
        }

        // GET: api/RaceJikkyoTrigger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoTrigger>> GetRaceJikkyoTrigger(int id)
        {
            var raceJikkyoTrigger = await _context.RaceJikkyoTriggers.FindAsync(id);

            if (raceJikkyoTrigger == null)
            {
                return NotFound();
            }

            return raceJikkyoTrigger;
        }
    }
}
