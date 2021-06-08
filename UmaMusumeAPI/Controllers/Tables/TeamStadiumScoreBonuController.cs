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
    public class TeamStadiumScoreBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumScoreBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumScoreBonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumScoreBonus>>> GetTeamStadiumScoreBonus()
        {
            return await _context.TeamStadiumScoreBonus.ToListAsync();
        }

        // GET: api/TeamStadiumScoreBonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumScoreBonus>> GetTeamStadiumScoreBonus(int id)
        {
            var teamStadiumScoreBonus = await _context.TeamStadiumScoreBonus.FindAsync(id);

            if (teamStadiumScoreBonus == null)
            {
                return NotFound();
            }

            return teamStadiumScoreBonus;
        }
    }
}
