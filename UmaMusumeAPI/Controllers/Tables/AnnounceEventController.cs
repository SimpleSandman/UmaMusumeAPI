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
    public class AnnounceEventController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceEventController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceEvent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceEvent>>> GetAnnounceEvent()
        {
            return await _context.AnnounceEvents.ToListAsync();
        }

        // GET: api/AnnounceEvent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceEvent>> GetAnnounceEvent(int id)
        {
            var announceEvent = await _context.AnnounceEvents.SingleOrDefaultAsync(c => c.Id == id);

            if (announceEvent == null)
            {
                return NotFound();
            }

            return announceEvent;
        }
    }
}
