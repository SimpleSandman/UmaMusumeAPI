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
    public class StoryEventPointRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventPointRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventPointReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventPointReward>>> GetStoryEventPointRewards()
        {
            return await _context.StoryEventPointRewards.ToListAsync();
        }

        // GET: api/StoryEventPointReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventPointReward>> GetStoryEventPointReward(int id)
        {
            var storyEventPointReward = await _context.StoryEventPointRewards.FindAsync(id);

            if (storyEventPointReward == null)
            {
                return NotFound();
            }

            return storyEventPointReward;
        }
    }
}
