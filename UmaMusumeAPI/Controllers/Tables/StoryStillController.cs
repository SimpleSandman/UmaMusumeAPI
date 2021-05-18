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
    public class StoryStillController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryStillController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryStill
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryStill>>> GetStoryStills()
        {
            return await _context.StoryStills.ToListAsync();
        }

        // GET: api/StoryStill/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryStill>> GetStoryStill(int id)
        {
            var storyStill = await _context.StoryStills.FindAsync(id);

            if (storyStill == null)
            {
                return NotFound();
            }

            return storyStill;
        }
    }
}
