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
    public class AudienceImpostorColorSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudienceImpostorColorSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudienceImpostorColorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudienceImpostorColorSet>>> GetAudienceImpostorColorSet()
        {
            return await _context.AudienceImpostorColorSets.ToListAsync();
        }

        // GET: api/AudienceImpostorColorSet/5
        [HttpGet("{colorGroupId}")]
        public async Task<ActionResult<IEnumerable<AudienceImpostorColorSet>>> GetAudienceImpostorColorSet(int colorGroupId)
        {
            var audienceImpostorColorSets = await _context.AudienceImpostorColorSets
                .Where(c => c.ColorGroupId == colorGroupId)
                .ToListAsync();

            if (audienceImpostorColorSets == null)
            {
                return NotFound();
            }

            return audienceImpostorColorSets;
        }
    }
}
