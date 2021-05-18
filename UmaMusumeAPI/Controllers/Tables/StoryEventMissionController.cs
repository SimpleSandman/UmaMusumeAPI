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
    public class StoryEventMissionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventMissionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventMission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventMission>>> GetStoryEventMissions()
        {
            return await _context.StoryEventMissions.ToListAsync();
        }

        // GET: api/StoryEventMission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventMission>> GetStoryEventMission(int id)
        {
            var storyEventMission = await _context.StoryEventMissions.FindAsync(id);

            if (storyEventMission == null)
            {
                return NotFound();
            }

            return storyEventMission;
        }
    }
}
