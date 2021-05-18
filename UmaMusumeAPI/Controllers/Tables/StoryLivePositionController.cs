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
    public class StoryLivePositionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryLivePositionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryLivePosition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryLivePosition>>> GetStoryLivePositions()
        {
            return await _context.StoryLivePositions.ToListAsync();
        }

        // GET: api/StoryLivePosition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryLivePosition>> GetStoryLivePosition(int id)
        {
            var storyLivePosition = await _context.StoryLivePositions.FindAsync(id);

            if (storyLivePosition == null)
            {
                return NotFound();
            }

            return storyLivePosition;
        }
    }
}
