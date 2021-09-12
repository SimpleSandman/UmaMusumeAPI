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
    public class RaceSingleModeTeamStatusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceSingleModeTeamStatusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceSingleModeTeamStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceSingleModeTeamStatus>>> GetRaceSingleModeTeamStatuses()
        {
            return await _context.RaceSingleModeTeamStatuses.ToListAsync();
        }

        // GET: api/RaceSingleModeTeamStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceSingleModeTeamStatus>> GetRaceSingleModeTeamStatus(int id)
        {
            var raceSingleModeTeamStatus = await _context.RaceSingleModeTeamStatuses.FindAsync(id);

            if (raceSingleModeTeamStatus == null)
            {
                return NotFound();
            }

            return raceSingleModeTeamStatus;
        }
    }
}
