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
    public class SingleModeDifficultyBoxRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyBoxRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyBoxReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyBoxReward>>> GetSingleModeDifficultyBoxRewards()
        {
            return await _context.SingleModeDifficultyBoxRewards.ToListAsync();
        }

        // GET: api/SingleModeDifficultyBoxReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyBoxReward>> GetSingleModeDifficultyBoxReward(int id)
        {
            var singleModeDifficultyBoxReward = await _context.SingleModeDifficultyBoxRewards.FindAsync(id);

            if (singleModeDifficultyBoxReward == null)
            {
                return NotFound();
            }

            return singleModeDifficultyBoxReward;
        }
    }
}
