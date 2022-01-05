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
    public class ChallengeMatchRaceNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchRaceNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchRaceNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchRaceNpc>>> GetChallengeMatchRaceNpcs()
        {
            return await _context.ChallengeMatchRaceNpcs.ToListAsync();
        }

        // GET: api/ChallengeMatchRaceNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchRaceNpc>> GetChallengeMatchRaceNpc(int id)
        {
            var challengeMatchRaceNpc = await _context.ChallengeMatchRaceNpcs.FindAsync(id);

            if (challengeMatchRaceNpc == null)
            {
                return NotFound();
            }

            return challengeMatchRaceNpc;
        }
    }
}
