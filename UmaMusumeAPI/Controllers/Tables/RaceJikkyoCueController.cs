using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult<IEnumerable<RaceJikkyoCue>>> GetRaceJikkyoCue()
        {
            return await _context.RaceJikkyoCues.ToListAsync();
        }

        // GET: api/RaceJikkyoCue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<RaceJikkyoCue>>> GetRaceJikkyoCue(int id)
        {
            var raceJikkyoCue = await _context.RaceJikkyoCues
                .Where(c => c.Id == id)
                .ToListAsync();

            if (raceJikkyoCue == null)
            {
                return NotFound();
            }

            return raceJikkyoCue;
        }
    }
}
