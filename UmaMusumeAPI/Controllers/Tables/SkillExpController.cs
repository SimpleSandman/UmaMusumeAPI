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
    public class SkillExpController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillExpController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillExp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillExp>>> GetSkillExps()
        {
            return await _context.SkillExps.ToListAsync();
        }

        // GET: api/SkillExp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillExp>> GetSkillExp(int id)
        {
            var skillExp = await _context.SkillExps.FindAsync(id);

            if (skillExp == null)
            {
                return NotFound();
            }

            return skillExp;
        }
    }
}
