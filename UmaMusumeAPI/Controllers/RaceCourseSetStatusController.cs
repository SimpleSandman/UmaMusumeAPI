using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers
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

        // PUT: api/RaceCourseSetStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceCourseSetStatus(int id, RaceCourseSetStatus raceCourseSetStatus)
        {
            if (id != raceCourseSetStatus.CourseSetStatusId)
            {
                return BadRequest();
            }

            _context.Entry(raceCourseSetStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceCourseSetStatusExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RaceCourseSetStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceCourseSetStatus>> PostRaceCourseSetStatus(RaceCourseSetStatus raceCourseSetStatus)
        {
            _context.RaceCourseSetStatuses.Add(raceCourseSetStatus);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceCourseSetStatusExists(raceCourseSetStatus.CourseSetStatusId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceCourseSetStatus", new { id = raceCourseSetStatus.CourseSetStatusId }, raceCourseSetStatus);
        }

        // DELETE: api/RaceCourseSetStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceCourseSetStatus(int id)
        {
            var raceCourseSetStatus = await _context.RaceCourseSetStatuses.FindAsync(id);
            if (raceCourseSetStatus == null)
            {
                return NotFound();
            }

            _context.RaceCourseSetStatuses.Remove(raceCourseSetStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceCourseSetStatusExists(int id)
        {
            return _context.RaceCourseSetStatuses.Any(e => e.CourseSetStatusId == id);
        }
    }
}
