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
    public class RaceTrophyRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrophyRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrophyReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrophyReward>>> GetRaceTrophyRewards()
        {
            return await _context.RaceTrophyRewards.ToListAsync();
        }

        // GET: api/RaceTrophyReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrophyReward>> GetRaceTrophyReward(int id)
        {
            var raceTrophyReward = await _context.RaceTrophyRewards.FindAsync(id);

            if (raceTrophyReward == null)
            {
                return NotFound();
            }

            return raceTrophyReward;
        }
    }
}
