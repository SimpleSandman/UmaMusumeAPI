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
    public class CampaignSingleRaceAddRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignSingleRaceAddRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignSingleRaceAddReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignSingleRaceAddReward>>> GetCampaignSingleRaceAddRewards()
        {
            return await _context.CampaignSingleRaceAddRewards.ToListAsync();
        }

        // GET: api/CampaignSingleRaceAddReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignSingleRaceAddReward>> GetCampaignSingleRaceAddReward(int id)
        {
            var campaignSingleRaceAddReward = await _context.CampaignSingleRaceAddRewards.FindAsync(id);

            if (campaignSingleRaceAddReward == null)
            {
                return NotFound();
            }

            return campaignSingleRaceAddReward;
        }
    }
}
