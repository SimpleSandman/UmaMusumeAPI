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
    public class SkillLevelValueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillLevelValueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillLevelValue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillLevelValue>>> GetSkillLevelValues()
        {
            return await _context.SkillLevelValues.ToListAsync();
        }

        // GET: api/SkillLevelValue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillLevelValue>> GetSkillLevelValue(int id)
        {
            var skillLevelValue = await _context.SkillLevelValues.FindAsync(id);

            if (skillLevelValue == null)
            {
                return NotFound();
            }

            return skillLevelValue;
        }
    }
}
