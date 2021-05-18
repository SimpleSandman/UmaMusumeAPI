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
    public class StoryEventRouletteBingoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventRouletteBingoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventRouletteBingo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventRouletteBingo>>> GetStoryEventRouletteBingos()
        {
            return await _context.StoryEventRouletteBingos.ToListAsync();
        }

        // GET: api/StoryEventRouletteBingo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventRouletteBingo>> GetStoryEventRouletteBingo(int id)
        {
            var storyEventRouletteBingo = await _context.StoryEventRouletteBingos.FindAsync(id);

            if (storyEventRouletteBingo == null)
            {
                return NotFound();
            }

            return storyEventRouletteBingo;
        }
    }
}
