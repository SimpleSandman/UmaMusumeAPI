using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicStoryEventDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicStoryEventDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicStoryEventDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicStoryEventDataInfo>>> GetBasicStoryEventDataInfos()
        {
            return await _context.BasicStoryEventDataInfos.ToListAsync();
        }

        // GET: api/BasicStoryEventDataInfo/5
        [HttpGet("{storyEventId}")]
        public async Task<ActionResult<BasicStoryEventDataInfo>> GetBasicStoryEventDataInfo(int storyEventId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicStoryEventDataInfo = await _context.BasicStoryEventDataInfos.SingleOrDefaultAsync(c => c.StoryEventId == storyEventId);

            if (basicStoryEventDataInfo == null)
            {
                return NotFound();
            }

            return basicStoryEventDataInfo;
        }
    }
}
