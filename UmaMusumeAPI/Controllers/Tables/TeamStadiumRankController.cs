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
    public class TeamStadiumRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumRank>>> GetTeamStadiumRanks()
        {
            return await _context.TeamStadiumRanks.ToListAsync();
        }

        // GET: api/TeamStadiumRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumRank>> GetTeamStadiumRank(int id)
        {
            var teamStadiumRank = await _context.TeamStadiumRanks.FindAsync(id);

            if (teamStadiumRank == null)
            {
                return NotFound();
            }

            return teamStadiumRank;
        }
    }
}
