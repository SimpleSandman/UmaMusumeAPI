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
    public class TeamStadiumBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumBgm>>> GetTeamStadiumBgms()
        {
            return await _context.TeamStadiumBgms.ToListAsync();
        }

        // GET: api/TeamStadiumBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumBgm>> GetTeamStadiumBgm(int id)
        {
            var teamStadiumBgm = await _context.TeamStadiumBgms.FindAsync(id);

            if (teamStadiumBgm == null)
            {
                return NotFound();
            }

            return teamStadiumBgm;
        }
    }
}
