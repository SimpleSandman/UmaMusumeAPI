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
    public class CampaignWalkingCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignWalkingCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignWalkingChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignWalkingChara>>> GetCampaignWalkingChara()
        {
            return await _context.CampaignWalkingCharas.ToListAsync();
        }

        // GET: api/CampaignWalkingChara/5
        [HttpGet("{campaignId}")]
        public async Task<ActionResult<IEnumerable<CampaignWalkingChara>>> GetCampaignWalkingChara(int campaignId)
        {
            var campaignWalkingChara = await _context.CampaignWalkingCharas
                .Where(c => c.CampaignId == campaignId)
                .ToListAsync();

            if (campaignWalkingChara == null)
            {
                return NotFound();
            }

            return campaignWalkingChara;
        }
    }
}
