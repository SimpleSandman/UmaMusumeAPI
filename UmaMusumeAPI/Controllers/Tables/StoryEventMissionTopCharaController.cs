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
    public class StoryEventMissionTopCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventMissionTopCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventMissionTopChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventMissionTopChara>>> GetStoryEventMissionTopCharas()
        {
            return await _context.StoryEventMissionTopCharas.ToListAsync();
        }

        // GET: api/StoryEventMissionTopChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventMissionTopChara>> GetStoryEventMissionTopChara(int id)
        {
            var storyEventMissionTopChara = await _context.StoryEventMissionTopCharas.FindAsync(id);

            if (storyEventMissionTopChara == null)
            {
                return NotFound();
            }

            return storyEventMissionTopChara;
        }
    }
}
