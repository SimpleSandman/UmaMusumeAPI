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
    public class ChallengeMatchRawPointController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchRawPointController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchRawPoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchRawPoint>>> GetChallengeMatchRawPoints()
        {
            return await _context.ChallengeMatchRawPoints.ToListAsync();
        }

        // GET: api/ChallengeMatchRawPoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchRawPoint>> GetChallengeMatchRawPoint(int id)
        {
            var challengeMatchRawPoint = await _context.ChallengeMatchRawPoints.FindAsync(id);

            if (challengeMatchRawPoint == null)
            {
                return NotFound();
            }

            return challengeMatchRawPoint;
        }
    }
}
