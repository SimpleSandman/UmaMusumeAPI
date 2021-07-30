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
    public class StoryEventWinBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventWinBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventWinBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventWinBonus>>> GetStoryEventWinBonus()
        {
            return await _context.StoryEventWinBonus.ToListAsync();
        }

        // GET: api/StoryEventWinBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventWinBonus>> GetStoryEventWinBonu(int id)
        {
            var storyEventWinBonu = await _context.StoryEventWinBonus.FindAsync(id);

            if (storyEventWinBonu == null)
            {
                return NotFound();
            }

            return storyEventWinBonu;
        }
    }
}
