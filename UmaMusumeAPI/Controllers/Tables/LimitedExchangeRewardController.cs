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
    public class LimitedExchangeRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchangeReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchangeReward>>> GetLimitedExchangeRewards()
        {
            return await _context.LimitedExchangeRewards.ToListAsync();
        }

        // GET: api/LimitedExchangeReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchangeReward>> GetLimitedExchangeReward(int id)
        {
            var limitedExchangeReward = await _context.LimitedExchangeRewards.FindAsync(id);

            if (limitedExchangeReward == null)
            {
                return NotFound();
            }

            return limitedExchangeReward;
        }
    }
}
