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
    public class StoryEventBingoRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBingoRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBingoReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBingoReward>>> GetStoryEventBingoRewards()
        {
            return await _context.StoryEventBingoRewards.ToListAsync();
        }

        // GET: api/StoryEventBingoReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBingoReward>> GetStoryEventBingoReward(int id)
        {
            var storyEventBingoReward = await _context.StoryEventBingoRewards.FindAsync(id);

            if (storyEventBingoReward == null)
            {
                return NotFound();
            }

            return storyEventBingoReward;
        }
    }
}
