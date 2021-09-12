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
    public class StoryEventNicknameBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventNicknameBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventNicknameBonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventNicknameBonus>>> GetStoryEventNicknameBonus()
        {
            return await _context.StoryEventNicknameBonus.ToListAsync();
        }

        // GET: api/StoryEventNicknameBonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventNicknameBonus>> GetStoryEventNicknameBonu(int id)
        {
            var storyEventNicknameBonus = await _context.StoryEventNicknameBonus.FindAsync(id);

            if (storyEventNicknameBonus == null)
            {
                return NotFound();
            }

            return storyEventNicknameBonus;
        }
    }
}
