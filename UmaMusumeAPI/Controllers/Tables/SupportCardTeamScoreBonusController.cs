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
    public class SupportCardTeamScoreBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardTeamScoreBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardTeamScoreBonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardTeamScoreBonus>>> GetSupportCardTeamScoreBonus()
        {
            return await _context.SupportCardTeamScoreBonus.ToListAsync();
        }

        // GET: api/SupportCardTeamScoreBonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardTeamScoreBonus>> GetSupportCardTeamScoreBonu(int id)
        {
            var supportCardTeamScoreBonus = await _context.SupportCardTeamScoreBonus.FindAsync(id);

            if (supportCardTeamScoreBonus == null)
            {
                return NotFound();
            }

            return supportCardTeamScoreBonus;
        }
    }
}
