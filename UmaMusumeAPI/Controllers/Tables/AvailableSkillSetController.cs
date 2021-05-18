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
    public class AvailableSkillSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AvailableSkillSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AvailableSkillSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvailableSkillSet>>> GetAvailableSkillSets()
        {
            return await _context.AvailableSkillSets.ToListAsync();
        }

        // GET: api/AvailableSkillSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AvailableSkillSet>> GetAvailableSkillSet(int id)
        {
            var availableSkillSet = await _context.AvailableSkillSets.FindAsync(id);

            if (availableSkillSet == null)
            {
                return NotFound();
            }

            return availableSkillSet;
        }
    }
}
