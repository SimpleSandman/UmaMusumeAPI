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
    public class SingleModeAoharuScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAoharuScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAoharuSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAoharuSchedule>>> GetSingleModeAoharuSchedules()
        {
            return await _context.SingleModeAoharuSchedules.ToListAsync();
        }

        // GET: api/SingleModeAoharuSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAoharuSchedule>> GetSingleModeAoharuSchedule(int id)
        {
            var singleModeAoharuSchedule = await _context.SingleModeAoharuSchedules.FindAsync(id);

            if (singleModeAoharuSchedule == null)
            {
                return NotFound();
            }

            return singleModeAoharuSchedule;
        }
    }
}
