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
    public class TeamStadiumRaceResultMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumRaceResultMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumRaceResultMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumRaceResultMotion>>> GetTeamStadiumRaceResultMotion()
        {
            return await _context.TeamStadiumRaceResultMotions.ToListAsync();
        }

        // GET: api/TeamStadiumRaceResultMotion/5
        [HttpGet("{characterId}")]
        public async Task<ActionResult<IEnumerable<TeamStadiumRaceResultMotion>>> GetTeamStadiumRaceResultMotion(long characterId)
        {
            var teamStadiumRaceResultMotions = await _context.TeamStadiumRaceResultMotions
                .Where(c => c.CharacterId == characterId)
                .ToListAsync();

            if (teamStadiumRaceResultMotions == null)
            {
                return NotFound();
            }

            return teamStadiumRaceResultMotions;
        }
    }
}
