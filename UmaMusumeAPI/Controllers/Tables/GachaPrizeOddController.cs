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
        [HttpGet("{prizeOddsId}")]
        public async Task<ActionResult<IEnumerable<GachaPrizeOdd>>> GetGachaPrizeOdd(int prizeOddsId)
        {
            var gachaPrizeOdd = await _context.GachaPrizeOdds
                .Where(c => c.PrizeOddsId == prizeOddsId)
                .ToListAsync();

            if (gachaPrizeOdd == null)
            {
                return NotFound();
            }

            return gachaPrizeOdd;
        }
    }
}
