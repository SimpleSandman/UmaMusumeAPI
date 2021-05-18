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
    public class StoryEventDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventData>>> GetStoryEventData()
        {
            return await _context.StoryEventData.ToListAsync();
        }

        // GET: api/StoryEventData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventData>> GetStoryEventData(int id)
        {
            var storyEventData = await _context.StoryEventData.FindAsync(id);

            if (storyEventData == null)
            {
                return NotFound();
            }

            return storyEventData;
        }
    }
}
