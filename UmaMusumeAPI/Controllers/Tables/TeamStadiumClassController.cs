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
    public class TeamStadiumClassController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumClassController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumClass
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumClass>>> GetTeamStadiumClasses()
        {
            return await _context.TeamStadiumClasses.ToListAsync();
        }

        // GET: api/TeamStadiumClass/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumClass>> GetTeamStadiumClass(int id)
        {
            var teamStadiumClass = await _context.TeamStadiumClasses.FindAsync(id);

            if (teamStadiumClass == null)
            {
                return NotFound();
            }

            return teamStadiumClass;
        }
    }
}
