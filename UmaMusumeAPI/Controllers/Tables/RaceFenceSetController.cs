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
    public class RaceFenceSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceFenceSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceFenceSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceFenceSet>>> GetRaceFenceSets()
        {
            return await _context.RaceFenceSets.ToListAsync();
        }

        // GET: api/RaceFenceSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceFenceSet>> GetRaceFenceSet(int id)
        {
            var raceFenceSet = await _context.RaceFenceSets.FindAsync(id);

            if (raceFenceSet == null)
            {
                return NotFound();
            }

            return raceFenceSet;
        }
    }
}
