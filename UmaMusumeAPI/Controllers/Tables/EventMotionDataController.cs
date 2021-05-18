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
    public class EventMotionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public EventMotionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/EventMotionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventMotionData>>> GetEventMotionData()
        {
            return await _context.EventMotionData.ToListAsync();
        }

        // GET: api/EventMotionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventMotionData>> GetEventMotionData(int id)
        {
            var eventMotionData = await _context.EventMotionData.FindAsync(id);

            if (eventMotionData == null)
            {
                return NotFound();
            }

            return eventMotionData;
        }
    }
}
