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
    public class ChallengeMatchBossNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchBossNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchBossNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchBossNpc>>> GetChallengeMatchBossNpcs()
        {
            return await _context.ChallengeMatchBossNpcs.ToListAsync();
        }

        // GET: api/ChallengeMatchBossNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchBossNpc>> GetChallengeMatchBossNpc(int id)
        {
            var challengeMatchBossNpc = await _context.ChallengeMatchBossNpcs.FindAsync(id);

            if (challengeMatchBossNpc == null)
            {
                return NotFound();
            }

            return challengeMatchBossNpc;
        }
    }
}
