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
    public class TeamStadiumRawScoreController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumRawScoreController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumRawScore
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumRawScore>>> GetTeamStadiumRawScores()
        {
            return await _context.TeamStadiumRawScores.ToListAsync();
        }

        // GET: api/TeamStadiumRawScore/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumRawScore>> GetTeamStadiumRawScore(int id)
        {
            var teamStadiumRawScore = await _context.TeamStadiumRawScores.FindAsync(id);

            if (teamStadiumRawScore == null)
            {
                return NotFound();
            }

            return teamStadiumRawScore;
        }
    }
}
