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
    public class RaceConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceCondition>>> GetRaceConditions()
        {
            return await _context.RaceConditions.ToListAsync();
        }

        // GET: api/RaceCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceCondition>> GetRaceCondition(int id)
        {
            var raceCondition = await _context.RaceConditions.FindAsync(id);

            if (raceCondition == null)
            {
                return NotFound();
            }

            return raceCondition;
        }
    }
}
