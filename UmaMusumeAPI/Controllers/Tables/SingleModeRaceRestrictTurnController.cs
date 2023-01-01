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
    public class SingleModeRaceRestrictTurnController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRaceRestrictTurnController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRaceRestrictTurn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRaceRestrictTurn>>> GetSingleModeRaceRestrictTurn()
        {
            return await _context.SingleModeRaceRestrictTurns.ToListAsync();
        }

        // GET: api/SingleModeRaceRestrictTurn/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<IEnumerable<SingleModeRaceRestrictTurn>>> GetSingleModeRaceRestrictTurn(int charaId)
        {
            var singleModeRaceRestrictTurns = await _context.SingleModeRaceRestrictTurns
                .Where(c => c.CharaId == charaId)
                .ToListAsync();

            if (singleModeRaceRestrictTurns == null)
            {
                return NotFound();
            }

            return singleModeRaceRestrictTurns;
        }
    }
}
