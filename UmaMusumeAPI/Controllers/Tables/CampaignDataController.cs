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
    public class CampaignDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignData>>> GetCampaignData()
        {
            return await _context.CampaignData.ToListAsync();
        }

        // GET: api/CampaignData/5
        [HttpGet("{campaignId}")]
        public async Task<ActionResult<CampaignData>> GetCampaignData(int campaignId)
        {
            var campaignData = await _context.CampaignData.FindAsync(campaignId);

            if (campaignData == null)
            {
                return NotFound();
            }

            return campaignData;
        }
    }
}
