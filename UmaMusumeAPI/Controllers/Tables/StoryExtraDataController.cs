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
    public class StoryExtraDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryExtraDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryExtraData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryExtraData>>> GetStoryExtraData()
        {
            return await _context.StoryExtraData.ToListAsync();
        }

        // GET: api/StoryExtraData/5
        [HttpGet("{storyExtraId}")]
        public async Task<ActionResult<StoryExtraData>> GetStoryExtraData(int storyExtraId)
        {
            var storyExtraData = await _context.StoryExtraData.FindAsync(storyExtraId);

            if (storyExtraData == null)
            {
                return NotFound();
            }

            return storyExtraData;
        }
    }
}
