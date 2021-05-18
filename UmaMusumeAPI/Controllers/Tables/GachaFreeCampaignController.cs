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
    public class GachaFreeCampaignController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaFreeCampaignController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaFreeCampaign
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaFreeCampaign>>> GetGachaFreeCampaigns()
        {
            return await _context.GachaFreeCampaigns.ToListAsync();
        }

        // GET: api/GachaFreeCampaign/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaFreeCampaign>> GetGachaFreeCampaign(int id)
        {
            var gachaFreeCampaign = await _context.GachaFreeCampaigns.FindAsync(id);

            if (gachaFreeCampaign == null)
            {
                return NotFound();
            }

            return gachaFreeCampaign;
        }
    }
}
