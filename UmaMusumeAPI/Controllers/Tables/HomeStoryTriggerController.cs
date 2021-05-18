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
    public class HomeStoryTriggerController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeStoryTriggerController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeStoryTrigger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeStoryTrigger>>> GetHomeStoryTriggers()
        {
            return await _context.HomeStoryTriggers.ToListAsync();
        }

        // GET: api/HomeStoryTrigger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeStoryTrigger>> GetHomeStoryTrigger(int id)
        {
            var homeStoryTrigger = await _context.HomeStoryTriggers.FindAsync(id);

            if (homeStoryTrigger == null)
            {
                return NotFound();
            }

            return homeStoryTrigger;
        }
    }
}
