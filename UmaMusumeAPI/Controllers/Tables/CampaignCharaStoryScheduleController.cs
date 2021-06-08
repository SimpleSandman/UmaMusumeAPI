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
    public class CampaignCharaStoryScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignCharaStoryScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignCharaStorySchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignCharaStorySchedule>>> GetCampaignCharaStorySchedule()
        {
            return await _context.CampaignCharaStorySchedules.ToListAsync();
        }

        // GET: api/CampaignCharaStorySchedule/5
        [HttpGet("{campaignId}")]
        public async Task<ActionResult<IEnumerable<CampaignCharaStorySchedule>>> GetCampaignCharaStorySchedule(int campaignId)
        {
            var campaignCharaStorySchedule = await _context.CampaignCharaStorySchedules
                .Where(c => c.CampaignId == campaignId)
                .ToListAsync();

            if (campaignCharaStorySchedule == null)
            {
                return NotFound();
            }

            return campaignCharaStorySchedule;
        }
    }
}
