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
    public class CharaMotionSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaMotionSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaMotionSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaMotionSet>>> GetCharaMotionSets()
        {
            return await _context.CharaMotionSets.ToListAsync();
        }

        // GET: api/CharaMotionSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaMotionSet>> GetCharaMotionSet(int id)
        {
            var charaMotionSet = await _context.CharaMotionSets.FindAsync(id);

            if (charaMotionSet == null)
            {
                return NotFound();
            }

            return charaMotionSet;
        }
    }
}
