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
    public class AudienceImpostorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudienceImpostorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudienceImpostor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudienceImpostor>>> GetAudienceImpostor()
        {
            return await _context.AudienceImpostors.ToListAsync();
        }

        // GET: api/AudienceImpostor/5
        [HttpGet("{groupId}")]
        public async Task<ActionResult<IEnumerable<AudienceImpostor>>> GetAudienceImpostor(int groupId)
        {
            var audienceImpostor = await _context.AudienceImpostors
                .Where(c => c.GroupId == groupId)
                .ToListAsync();

            if (audienceImpostor == null)
            {
                return NotFound();
            }

            return audienceImpostor;
        }
    }
}
