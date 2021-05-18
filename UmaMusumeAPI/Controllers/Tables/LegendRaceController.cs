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
    public class LegendRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRace>>> GetLegendRaces()
        {
            return await _context.LegendRaces.ToListAsync();
        }

        // GET: api/LegendRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRace>> GetLegendRace(int id)
        {
            var legendRace = await _context.LegendRaces.FindAsync(id);

            if (legendRace == null)
            {
                return NotFound();
            }

            return legendRace;
        }
    }
}
