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
    public class AudienceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudienceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudienceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudienceData>>> GetAudienceData()
        {
            return await _context.AudienceData.ToListAsync();
        }

        // GET: api/AudienceData/5
        [HttpGet("{audienceId}")]
        public async Task<ActionResult<AudienceData>> GetAudienceData(int audienceId)
        {
            var audienceData = await _context.AudienceData.FindAsync(audienceId);

            if (audienceData == null)
            {
                return NotFound();
            }

            return audienceData;
        }
    }
}
