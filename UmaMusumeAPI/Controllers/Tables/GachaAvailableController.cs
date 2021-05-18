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
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaAvailable>> GetGachaAvailable(int id)
        {
            var gachaAvailable = await _context.GachaAvailables.FindAsync(id);

            if (gachaAvailable == null)
            {
                return NotFound();
            }

            return gachaAvailable;
        }
    }
}
