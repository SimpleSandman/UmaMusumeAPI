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
    public class LegendRaceBossNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceBossNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceBossNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceBossNpc>>> GetLegendRaceBossNpcs()
        {
            return await _context.LegendRaceBossNpcs.ToListAsync();
        }

        // GET: api/LegendRaceBossNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceBossNpc>> GetLegendRaceBossNpc(int id)
        {
            var legendRaceBossNpc = await _context.LegendRaceBossNpcs.FindAsync(id);

            if (legendRaceBossNpc == null)
            {
                return NotFound();
            }

            return legendRaceBossNpc;
        }
    }
}
