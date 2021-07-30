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
    public class StoryExtraStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryExtraStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryExtraStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryExtraStoryData>>> GetStoryExtraStoryData()
        {
            return await _context.StoryExtraStoryData.ToListAsync();
        }

        // GET: api/StoryExtraStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryExtraStoryData>> GetStoryExtraStoryData(int id)
        {
            var storyExtraStoryData = await _context.StoryExtraStoryData.FindAsync(id);

            if (storyExtraStoryData == null)
            {
                return NotFound();
            }

            return storyExtraStoryData;
        }
    }
}
