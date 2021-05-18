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
    public class StoryEventNicknameBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventNicknameBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventNicknameBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventNicknameBonu>>> GetStoryEventNicknameBonus()
        {
            return await _context.StoryEventNicknameBonus.ToListAsync();
        }

        // GET: api/StoryEventNicknameBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventNicknameBonu>> GetStoryEventNicknameBonu(int id)
        {
            var storyEventNicknameBonu = await _context.StoryEventNicknameBonus.FindAsync(id);

            if (storyEventNicknameBonu == null)
            {
                return NotFound();
            }

            return storyEventNicknameBonu;
        }
    }
}
