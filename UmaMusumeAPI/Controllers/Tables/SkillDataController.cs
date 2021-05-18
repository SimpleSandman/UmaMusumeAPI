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
    public class SkillDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillData>>> GetSkillData()
        {
            return await _context.SkillData.ToListAsync();
        }

        // GET: api/SkillData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillData>> GetSkillData(int id)
        {
            var skillData = await _context.SkillData.FindAsync(id);

            if (skillData == null)
            {
                return NotFound();
            }

            return skillData;
        }
    }
}
