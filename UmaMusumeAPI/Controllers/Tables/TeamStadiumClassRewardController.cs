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
    public class TeamStadiumClassRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumClassRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumClassReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumClassReward>>> GetTeamStadiumClassRewards()
        {
            return await _context.TeamStadiumClassRewards.ToListAsync();
        }

        // GET: api/TeamStadiumClassReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumClassReward>> GetTeamStadiumClassReward(int id)
        {
            var teamStadiumClassReward = await _context.TeamStadiumClassRewards.FindAsync(id);

            if (teamStadiumClassReward == null)
            {
                return NotFound();
            }

            return teamStadiumClassReward;
        }
    }
}
