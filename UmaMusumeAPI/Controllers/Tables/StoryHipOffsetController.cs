using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryHipOffsetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryHipOffsetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryHipOffset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryHipOffset>>> GetStoryHipOffsets()
        {
            return await _context.StoryHipOffsets.ToListAsync();
        }

        // GET: api/StoryHipOffset/5
        [HttpGet("{categoryId}")]
        public async Task<ActionResult<IEnumerable<StoryHipOffset>>> GetStoryHipOffset(long categoryId)
        {
            var storyHipOffset = await _context.StoryHipOffsets.Where(c => c.CategoryId == categoryId).ToListAsync();

            if (storyHipOffset == null)
            {
                return NotFound();
            }

            return storyHipOffset;
        }
    }
}
