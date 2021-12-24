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
    public class GachaStockCampaignController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaStockCampaignController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaStockCampaign
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaStockCampaign>>> GetGachaStockCampaign()
        {
            return await _context.GachaStockCampaigns.ToListAsync();
        }

        // GET: api/GachaStockCampaign/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaStockCampaign>> GetGachaStockCampaign(int id)
        {
            var gachaStockCampaign = await _context.GachaStockCampaigns.FindAsync(id);

            if (gachaStockCampaign == null)
            {
                return NotFound();
            }

            return gachaStockCampaign;
        }
    }
}
