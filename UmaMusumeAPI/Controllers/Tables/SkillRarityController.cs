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
    public class SkillRarityController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillRarityController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillRarity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillRarity>>> GetSkillRarities()
        {
            return await _context.SkillRarities.ToListAsync();
        }

        // GET: api/SkillRarity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillRarity>> GetSkillRarity(int id)
        {
            var skillRarity = await _context.SkillRarities.FindAsync(id);

            if (skillRarity == null)
            {
                return NotFound();
            }

            return skillRarity;
        }
    }
}
