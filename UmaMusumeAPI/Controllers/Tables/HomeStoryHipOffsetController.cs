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
    public class HomeStoryHipOffsetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeStoryHipOffsetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeStoryHipOffset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeStoryHipOffset>>> GetHomeStoryHipOffsets()
        {
            return await _context.HomeStoryHipOffsets.ToListAsync();
        }

        // GET: api/HomeStoryHipOffset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeStoryHipOffset>> GetHomeStoryHipOffset(int id)
        {
            var homeStoryHipOffset = await _context.HomeStoryHipOffsets.FindAsync(id);

            if (homeStoryHipOffset == null)
            {
                return NotFound();
            }

            return homeStoryHipOffset;
        }
    }
}
