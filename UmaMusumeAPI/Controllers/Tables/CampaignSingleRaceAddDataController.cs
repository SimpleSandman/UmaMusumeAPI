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
    public class CampaignSingleRaceAddDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CampaignSingleRaceAddDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CampaignSingleRaceAddData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignSingleRaceAddData>>> GetCampaignSingleRaceAddData()
        {
            return await _context.CampaignSingleRaceAddData.ToListAsync();
        }

        // GET: api/CampaignSingleRaceAddData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignSingleRaceAddData>> GetCampaignSingleRaceAddData(int id)
        {
            var campaignSingleRaceAddData = await _context.CampaignSingleRaceAddData.FindAsync(id);

            if (campaignSingleRaceAddData == null)
            {
                return NotFound();
            }

            return campaignSingleRaceAddData;
        }
    }
}
