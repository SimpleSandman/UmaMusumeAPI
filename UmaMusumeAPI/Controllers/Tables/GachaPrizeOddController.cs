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
    public class GachaPrizeOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaPrizeOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaPrizeOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaPrizeOdd>>> GetGachaPrizeOdds()
        {
            return await _context.GachaPrizeOdds.ToListAsync();
        }

        // GET: api/GachaPrizeOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaPrizeOdd>> GetGachaPrizeOdd(int id)
        {
            var gachaPrizeOdd = await _context.GachaPrizeOdds.FindAsync(id);

            if (gachaPrizeOdd == null)
            {
                return NotFound();
            }

            return gachaPrizeOdd;
        }
    }
}
