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
    public class ChallengeMatchRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchRace>>> GetChallengeMatchRaces()
        {
            return await _context.ChallengeMatchRaces.ToListAsync();
        }

        // GET: api/ChallengeMatchRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchRace>> GetChallengeMatchRace(int id)
        {
            var challengeMatchRace = await _context.ChallengeMatchRaces.FindAsync(id);

            if (challengeMatchRace == null)
            {
                return NotFound();
            }

            return challengeMatchRace;
        }
    }
}
