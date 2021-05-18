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
    public class SingleModeSkillNeedPointController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeSkillNeedPointController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeSkillNeedPoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeSkillNeedPoint>>> GetSingleModeSkillNeedPoints()
        {
            return await _context.SingleModeSkillNeedPoints.ToListAsync();
        }

        // GET: api/SingleModeSkillNeedPoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeSkillNeedPoint>> GetSingleModeSkillNeedPoint(int id)
        {
            var singleModeSkillNeedPoint = await _context.SingleModeSkillNeedPoints.FindAsync(id);

            if (singleModeSkillNeedPoint == null)
            {
                return NotFound();
            }

            return singleModeSkillNeedPoint;
        }
    }
}
