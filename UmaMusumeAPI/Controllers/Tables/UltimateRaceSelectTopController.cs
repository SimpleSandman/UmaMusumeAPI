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
    public class UltimateRaceSelectTopController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public UltimateRaceSelectTopController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/UltimateRaceSelectTop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UltimateRaceSelectTop>>> GetUltimateRaceSelectTop()
        {
            return await _context.UltimateRaceSelectTops.ToListAsync();
        }

        // GET: api/UltimateRaceSelectTop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UltimateRaceSelectTop>>> GetUltimateRaceSelectTop(int id)
        {
            var ultimateRaceSelectTop = await _context.UltimateRaceSelectTops
                .Where(c => c.Id == id)
                .ToListAsync();

            if (ultimateRaceSelectTop == null)
            {
                return NotFound();
            }

            return ultimateRaceSelectTop;
        }
    }
}
