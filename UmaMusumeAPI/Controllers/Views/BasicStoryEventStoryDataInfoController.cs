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
    public class BasicStoryEventStoryDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicStoryEventStoryDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicStoryEventStoryDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicStoryEventStoryDataInfo>>> GetBasicStoryEventStoryDataInfos()
        {
            return await _context.BasicStoryEventStoryDataInfos.ToListAsync();
        }

        // GET: api/BasicStoryEventStoryDataInfo/5
        [HttpGet("{storyEventStoryId}")]
        public async Task<ActionResult<BasicStoryEventStoryDataInfo>> GetBasicStoryEventStoryDataInfo(int storyEventStoryId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicStoryEventStoryDataInfo = await _context.BasicStoryEventStoryDataInfos.SingleOrDefaultAsync(c => c.StoryEventStoryId == storyEventStoryId);

            if (basicStoryEventStoryDataInfo == null)
            {
                return NotFound();
            }

            return basicStoryEventStoryDataInfo;
        }
    }
}
