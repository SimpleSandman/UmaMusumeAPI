using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsRaceConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRaceConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRaceCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRaceCondition>>> GetChampionsRaceConditions()
        {
            return await _context.ChampionsRaceConditions.ToListAsync();
        }

        // GET: api/ChampionsRaceCondition/5
        [HttpGet("{championsId}")]
        public async Task<ActionResult<IEnumerable<ChampionsRaceCondition>>> GetChampionsRaceCondition(int championsId)
        {
            var championsRaceCondition = await _context.ChampionsRaceConditions
                .Where(c => c.ChampionsId == championsId)
                .ToListAsync();

            if (championsRaceCondition == null)
            {
                return NotFound();
            }

            return championsRaceCondition;
        }
    }
}
