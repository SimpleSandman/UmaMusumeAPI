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
    public class LimitedExchangeRewardOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeRewardOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchangeRewardOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchangeRewardOdd>>> GetLimitedExchangeRewardOdds()
        {
            return await _context.LimitedExchangeRewardOdds.ToListAsync();
        }

        // GET: api/LimitedExchangeRewardOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchangeRewardOdd>> GetLimitedExchangeRewardOdd(int id)
        {
            var limitedExchangeRewardOdd = await _context.LimitedExchangeRewardOdds.FindAsync(id);

            if (limitedExchangeRewardOdd == null)
            {
                return NotFound();
            }

            return limitedExchangeRewardOdd;
        }
    }
}
