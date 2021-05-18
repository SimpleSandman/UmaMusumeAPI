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
    public class TeamStadiumController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadium
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadium>>> GetTeamStadia()
        {
            return await _context.TeamStadia.ToListAsync();
        }

        // GET: api/TeamStadium/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadium>> GetTeamStadium(int id)
        {
            var teamStadium = await _context.TeamStadia.FindAsync(id);

            if (teamStadium == null)
            {
                return NotFound();
            }

            return teamStadium;
        }
    }
}
