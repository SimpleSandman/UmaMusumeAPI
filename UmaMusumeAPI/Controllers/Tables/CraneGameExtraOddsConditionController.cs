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
    public class CraneGameExtraOddsConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameExtraOddsConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameExtraOddsCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameExtraOddsCondition>>> GetCraneGameExtraOddsConditions()
        {
            return await _context.CraneGameExtraOddsConditions.ToListAsync();
        }

        // GET: api/CraneGameExtraOddsCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameExtraOddsCondition>> GetCraneGameExtraOddsCondition(int id)
        {
            var craneGameExtraOddsCondition = await _context.CraneGameExtraOddsConditions.FindAsync(id);

            if (craneGameExtraOddsCondition == null)
            {
                return NotFound();
            }

            return craneGameExtraOddsCondition;
        }
    }
}
