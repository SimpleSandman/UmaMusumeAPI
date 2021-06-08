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
    public class TeamStadiumStandMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumStandMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumStandMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumStandMotion>>> GetTeamStadiumStandMotion()
        {
            return await _context.TeamStadiumStandMotions.ToListAsync();
        }

        // GET: api/TeamStadiumStandMotion/5
        [HttpGet("{characterId}")]
        public async Task<ActionResult<TeamStadiumStandMotion>> GetTeamStadiumStandMotion(int characterId)
        {
            var teamStadiumStandMotion = await _context.TeamStadiumStandMotions.SingleOrDefaultAsync(c => c.CharacterId == characterId);

            if (teamStadiumStandMotion == null)
            {
                return NotFound();
            }

            return teamStadiumStandMotion;
        }
    }
}
