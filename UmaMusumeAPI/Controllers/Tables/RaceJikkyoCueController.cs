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
    public class RaceJikkyoCueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoCueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoCue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoCue>>> GetRaceJikkyoCues()
        {
            return await _context.RaceJikkyoCues.ToListAsync();
        }

        // GET: api/RaceJikkyoCue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoCue>> GetRaceJikkyoCue(int id)
        {
            var raceJikkyoCue = await _context.RaceJikkyoCues.FindAsync(id);

            if (raceJikkyoCue == null)
            {
                return NotFound();
            }

            return raceJikkyoCue;
        }
    }
}
