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
    public class HomeWalkGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeWalkGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeWalkGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeWalkGroup>>> GetHomeWalkGroups()
        {
            return await _context.HomeWalkGroups.ToListAsync();
        }

        // GET: api/HomeWalkGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeWalkGroup>> GetHomeWalkGroup(int id)
        {
            var homeWalkGroup = await _context.HomeWalkGroups.FindAsync(id);

            if (homeWalkGroup == null)
            {
                return NotFound();
            }

            return homeWalkGroup;
        }
    }
}
