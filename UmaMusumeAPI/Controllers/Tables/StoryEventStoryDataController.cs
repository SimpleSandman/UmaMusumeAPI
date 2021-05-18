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
    public class StoryEventStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventStoryData>>> GetStoryEventStoryData()
        {
            return await _context.StoryEventStoryData.ToListAsync();
        }

        // GET: api/StoryEventStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventStoryData>> GetStoryEventStoryData(int id)
        {
            var storyEventStoryData = await _context.StoryEventStoryData.FindAsync(id);

            if (storyEventStoryData == null)
            {
                return NotFound();
            }

            return storyEventStoryData;
        }
    }
}
