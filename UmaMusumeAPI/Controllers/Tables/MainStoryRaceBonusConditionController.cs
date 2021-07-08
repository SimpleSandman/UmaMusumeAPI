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
    public class MainStoryRaceBonusConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceBonusConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceBonusCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceBonusCondition>>> GetMainStoryRaceBonusConditions()
        {
            return await _context.MainStoryRaceBonusConditions.ToListAsync();
        }

        // GET: api/MainStoryRaceBonusCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceBonusCondition>> GetMainStoryRaceBonusCondition(int id)
        {
            var mainStoryRaceBonusCondition = await _context.MainStoryRaceBonusConditions.FindAsync(id);

            if (mainStoryRaceBonusCondition == null)
            {
                return NotFound();
            }

            return mainStoryRaceBonusCondition;
        }
    }
}
