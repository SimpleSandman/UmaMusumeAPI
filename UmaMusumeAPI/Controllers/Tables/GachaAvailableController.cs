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
    public class GachaAvailableController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaAvailableController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaAvailable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaAvailable>>> GetGachaAvailables()
        {
            return await _context.GachaAvailables.ToListAsync();
        }

        // GET: api/GachaAvailable/5
        [HttpGet("{gachaId}")]
        public async Task<ActionResult<IEnumerable<GachaAvailable>>> GetGachaAvailable(int gachaId)
        {
            var gachaAvailable = await _context.GachaAvailables
                .Where(c => c.GachaId == gachaId)
                .ToListAsync();

            if (gachaAvailable == null)
            {
                return NotFound();
            }

            return gachaAvailable;
        }
    }
}
