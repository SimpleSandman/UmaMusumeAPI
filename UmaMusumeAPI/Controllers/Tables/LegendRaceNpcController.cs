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
    public class LegendRaceNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceNpc>>> GetLegendRaceNpcs()
        {
            return await _context.LegendRaceNpcs.ToListAsync();
        }

        // GET: api/LegendRaceNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceNpc>> GetLegendRaceNpc(int id)
        {
            var legendRaceNpc = await _context.LegendRaceNpcs.FindAsync(id);

            if (legendRaceNpc == null)
            {
                return NotFound();
            }

            return legendRaceNpc;
        }
    }
}
