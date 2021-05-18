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
    public class StoryEventBonusSupportCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBonusSupportCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBonusSupportCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBonusSupportCard>>> GetStoryEventBonusSupportCards()
        {
            return await _context.StoryEventBonusSupportCards.ToListAsync();
        }

        // GET: api/StoryEventBonusSupportCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBonusSupportCard>> GetStoryEventBonusSupportCard(int id)
        {
            var storyEventBonusSupportCard = await _context.StoryEventBonusSupportCards.FindAsync(id);

            if (storyEventBonusSupportCard == null)
            {
                return NotFound();
            }

            return storyEventBonusSupportCard;
        }
    }
}
