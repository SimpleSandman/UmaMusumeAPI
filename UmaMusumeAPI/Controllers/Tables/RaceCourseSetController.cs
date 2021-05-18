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
    public class RaceCourseSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceCourseSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceCourseSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceCourseSet>>> GetRaceCourseSets()
        {
            return await _context.RaceCourseSets.ToListAsync();
        }

        // GET: api/RaceCourseSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceCourseSet>> GetRaceCourseSet(int id)
        {
            var raceCourseSet = await _context.RaceCourseSets.FindAsync(id);

            if (raceCourseSet == null)
            {
                return NotFound();
            }

            return raceCourseSet;
        }
    }
}
