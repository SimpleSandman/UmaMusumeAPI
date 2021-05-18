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
    public class StoryLiveSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryLiveSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryLiveSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryLiveSet>>> GetStoryLiveSets()
        {
            return await _context.StoryLiveSets.ToListAsync();
        }

        // GET: api/StoryLiveSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryLiveSet>> GetStoryLiveSet(int id)
        {
            var storyLiveSet = await _context.StoryLiveSets.FindAsync(id);

            if (storyLiveSet == null)
            {
                return NotFound();
            }

            return storyLiveSet;
        }
    }
}
