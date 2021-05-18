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
    public class RaceBgmPatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmPatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgmPattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgmPattern>>> GetRaceBgmPatterns()
        {
            return await _context.RaceBgmPatterns.ToListAsync();
        }

        // GET: api/RaceBgmPattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgmPattern>> GetRaceBgmPattern(int id)
        {
            var raceBgmPattern = await _context.RaceBgmPatterns.FindAsync(id);

            if (raceBgmPattern == null)
            {
                return NotFound();
            }

            return raceBgmPattern;
        }
    }
}
