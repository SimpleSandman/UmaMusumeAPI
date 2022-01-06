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
    public class TimezoneDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TimezoneDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TimezoneData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimezoneData>>> GetTimezoneData()
        {
            return await _context.TimezoneData.ToListAsync();
        }

        // GET: api/TimezoneData/5
        [HttpGet("{timezone}")]
        public async Task<ActionResult<TimezoneData>> GetTimezoneData(int timezone)
        {
            var timezoneData = await _context.TimezoneData.FindAsync(timezone);

            if (timezoneData == null)
            {
                return NotFound();
            }

            return timezoneData;
        }
    }
}
