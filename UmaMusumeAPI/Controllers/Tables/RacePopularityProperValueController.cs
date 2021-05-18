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
    public class RacePopularityProperValueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RacePopularityProperValueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RacePopularityProperValue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RacePopularityProperValue>>> GetRacePopularityProperValues()
        {
            return await _context.RacePopularityProperValues.ToListAsync();
        }

        // GET: api/RacePopularityProperValue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RacePopularityProperValue>> GetRacePopularityProperValue(int id)
        {
            var racePopularityProperValue = await _context.RacePopularityProperValues.FindAsync(id);

            if (racePopularityProperValue == null)
            {
                return NotFound();
            }

            return racePopularityProperValue;
        }
    }
}
