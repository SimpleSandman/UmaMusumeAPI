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
    public class StoryEventTopCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventTopCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventTopChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventTopChara>>> GetStoryEventTopCharas()
        {
            return await _context.StoryEventTopCharas.ToListAsync();
        }

        // GET: api/StoryEventTopChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventTopChara>> GetStoryEventTopChara(int id)
        {
            var storyEventTopChara = await _context.StoryEventTopCharas.FindAsync(id);

            if (storyEventTopChara == null)
            {
                return NotFound();
            }

            return storyEventTopChara;
        }
    }
}
