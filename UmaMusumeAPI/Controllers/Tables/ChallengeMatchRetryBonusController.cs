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
    public class ChallengeMatchRetryBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchRetryBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchRetryBonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchRetryBonus>>> GetChallengeMatchRetryBonuss()
        {
            return await _context.ChallengeMatchRetryBonus.ToListAsync();
        }

        // GET: api/ChallengeMatchRetryBonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchRetryBonus>> GetChallengeMatchRetryBonus(int id)
        {
            var challengeMatchRetryBonus = await _context.ChallengeMatchRetryBonus.FindAsync(id);

            if (challengeMatchRetryBonus == null)
            {
                return NotFound();
            }

            return challengeMatchRetryBonus;
        }
    }
}
