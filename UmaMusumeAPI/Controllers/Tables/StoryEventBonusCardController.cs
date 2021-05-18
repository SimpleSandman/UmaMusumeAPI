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
    public class StoryEventBonusCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBonusCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBonusCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBonusCard>>> GetStoryEventBonusCards()
        {
            return await _context.StoryEventBonusCards.ToListAsync();
        }

        // GET: api/StoryEventBonusCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBonusCard>> GetStoryEventBonusCard(int id)
        {
            var storyEventBonusCard = await _context.StoryEventBonusCards.FindAsync(id);

            if (storyEventBonusCard == null)
            {
                return NotFound();
            }

            return storyEventBonusCard;
        }
    }
}
