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
    public class EventMotionPlusDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public EventMotionPlusDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/EventMotionPlusData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventMotionPlusData>>> GetEventMotionPlusData()
        {
            return await _context.EventMotionPlusData.ToListAsync();
        }

        // GET: api/EventMotionPlusData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventMotionPlusData>> GetEventMotionPlusData(int id)
        {
            var eventMotionPlusData = await _context.EventMotionPlusData.FindAsync(id);

            if (eventMotionPlusData == null)
            {
                return NotFound();
            }

            return eventMotionPlusData;
        }
    }
}
