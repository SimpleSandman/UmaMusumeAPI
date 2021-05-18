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
    public class GachaTopBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaTopBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaTopBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaTopBg>>> GetGachaTopBgs()
        {
            return await _context.GachaTopBgs.ToListAsync();
        }

        // GET: api/GachaTopBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaTopBg>> GetGachaTopBg(int id)
        {
            var gachaTopBg = await _context.GachaTopBgs.FindAsync(id);

            if (gachaTopBg == null)
            {
                return NotFound();
            }

            return gachaTopBg;
        }
    }
}
