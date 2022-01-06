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
    public class SingleModeStoryGuideController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeStoryGuideController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeStoryGuide
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeStoryGuide>>> GetSingleModeStoryGuides()
        {
            return await _context.SingleModeStoryGuides.ToListAsync();
        }

        // GET: api/SingleModeStoryGuide/5
        [HttpGet("{storyId}")]
        public async Task<ActionResult<SingleModeStoryGuide>> GetSingleModeStoryGuide(int storyId)
        {
            var singleModeStoryGuide = await _context.SingleModeStoryGuides.FindAsync(storyId);

            if (singleModeStoryGuide == null)
            {
                return NotFound();
            }

            return singleModeStoryGuide;
        }
    }
}
