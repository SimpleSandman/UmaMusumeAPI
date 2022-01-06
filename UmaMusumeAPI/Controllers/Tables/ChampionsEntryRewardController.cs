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
    public class ChampionsEntryRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsEntryRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsEntryReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsEntryReward>>> GetChampionsEntryRewards()
        {
            return await _context.ChampionsEntryRewards.ToListAsync();
        }

        // GET: api/ChampionsEntryReward/5
        [HttpGet("{championsId}")]
        public async Task<ActionResult<IEnumerable<ChampionsEntryReward>>> GetChampionsEntryReward(int championsId)
        {
            var championsEntryReward = await _context.ChampionsEntryRewards
                .Where(c => c.ChampionsId == championsId)
                .ToListAsync();

            if (championsEntryReward == null)
            {
                return NotFound();
            }

            return championsEntryReward;
        }
    }
}
