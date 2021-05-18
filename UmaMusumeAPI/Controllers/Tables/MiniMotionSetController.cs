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
    public class MiniMotionSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniMotionSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniMotionSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniMotionSet>>> GetMiniMotionSets()
        {
            return await _context.MiniMotionSets.ToListAsync();
        }

        // GET: api/MiniMotionSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniMotionSet>> GetMiniMotionSet(string id)
        {
            var miniMotionSet = await _context.MiniMotionSets.FindAsync(id);

            if (miniMotionSet == null)
            {
                return NotFound();
            }

            return miniMotionSet;
        }
    }
}
