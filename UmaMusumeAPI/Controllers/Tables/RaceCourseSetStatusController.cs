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
    public class RaceCourseSetStatusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceCourseSetStatusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceCourseSetStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceCourseSetStatus>>> GetRaceCourseSetStatuses()
        {
            return await _context.RaceCourseSetStatuses.ToListAsync();
        }

        // GET: api/RaceCourseSetStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceCourseSetStatus>> GetRaceCourseSetStatus(int id)
        {
            var raceCourseSetStatus = await _context.RaceCourseSetStatuses.FindAsync(id);

            if (raceCourseSetStatus == null)
            {
                return NotFound();
            }

            return raceCourseSetStatus;
        }
    }
}
