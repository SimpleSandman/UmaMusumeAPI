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

        // PUT: api/RaceCourseSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceCourseSet(int id, RaceCourseSet raceCourseSet)
        {
            if (id != raceCourseSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceCourseSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceCourseSetExists(id))
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

        // POST: api/RaceCourseSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceCourseSet>> PostRaceCourseSet(RaceCourseSet raceCourseSet)
        {
            _context.RaceCourseSets.Add(raceCourseSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceCourseSetExists(raceCourseSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceCourseSet", new { id = raceCourseSet.Id }, raceCourseSet);
        }

        // DELETE: api/RaceCourseSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceCourseSet(int id)
        {
            var raceCourseSet = await _context.RaceCourseSets.FindAsync(id);
            if (raceCourseSet == null)
            {
                return NotFound();
            }

            _context.RaceCourseSets.Remove(raceCourseSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceCourseSetExists(int id)
        {
            return _context.RaceCourseSets.Any(e => e.Id == id);
        }
    }
}
