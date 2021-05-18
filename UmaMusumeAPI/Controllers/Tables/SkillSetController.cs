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
    public class SkillSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillSet>>> GetSkillSets()
        {
            return await _context.SkillSets.ToListAsync();
        }

        // GET: api/SkillSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillSet>> GetSkillSet(int id)
        {
            var skillSet = await _context.SkillSets.FindAsync(id);

            if (skillSet == null)
            {
                return NotFound();
            }

            return skillSet;
        }
    }
}
