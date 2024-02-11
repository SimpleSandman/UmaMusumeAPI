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
    public class MapEventDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MapEventDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MapEventData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MapEventData>>> GetMapEventData()
        {
            return await _context.MapEventData.ToListAsync();
        }

        // GET: api/MapEventData/5
        [HttpGet("{eventId}")]
        public async Task<ActionResult<MapEventData>> GetMapEventData(int eventId)
        {
            var mapEventData = await _context.MapEventData.FindAsync(eventId);

            if (mapEventData == null)
            {
                return NotFound();
            }

            return mapEventData;
        }
    }
}
