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
    public class ChallengeMatchDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChallengeMatchDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChallengeMatchData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChallengeMatchData>>> GetChallengeMatchDatas()
        {
            return await _context.ChallengeMatchData.ToListAsync();
        }

        // GET: api/ChallengeMatchData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeMatchData>> GetChallengeMatchData(int id)
        {
            var challengeMatchData = await _context.ChallengeMatchData.FindAsync(id);

            if (challengeMatchData == null)
            {
                return NotFound();
            }

            return challengeMatchData;
        }
    }
}
