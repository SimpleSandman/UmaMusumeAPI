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
    public class TeamStadiumScoreBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumScoreBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumScoreBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumScoreBonu>>> GetTeamStadiumScoreBonus()
        {
            return await _context.TeamStadiumScoreBonus.ToListAsync();
        }

        // GET: api/TeamStadiumScoreBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumScoreBonu>> GetTeamStadiumScoreBonu(int id)
        {
            var teamStadiumScoreBonu = await _context.TeamStadiumScoreBonus.FindAsync(id);

            if (teamStadiumScoreBonu == null)
            {
                return NotFound();
            }

            return teamStadiumScoreBonu;
        }
    }
}
