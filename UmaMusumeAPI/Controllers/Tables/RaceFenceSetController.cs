using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceFenceSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceFenceSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceFenceSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceFenceSet>>> GetRaceFenceSets()
        {
            return await _context.RaceFenceSets.ToListAsync();
        }

        // GET: api/RaceFenceSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceFenceSet>> GetRaceFenceSet(int id)
        {
            var raceFenceSet = await _context.RaceFenceSets.FindAsync(id);

            if (raceFenceSet == null)
            {
                return NotFound();
            }

            return raceFenceSet;
        }

        // PUT: api/RaceFenceSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceFenceSet(int id, RaceFenceSet raceFenceSet)
        {
            if (id != raceFenceSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceFenceSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceFenceSetExists(id))
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

        // POST: api/RaceFenceSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceFenceSet>> PostRaceFenceSet(RaceFenceSet raceFenceSet)
        {
            _context.RaceFenceSets.Add(raceFenceSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceFenceSetExists(raceFenceSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceFenceSet", new { id = raceFenceSet.Id }, raceFenceSet);
        }

        // DELETE: api/RaceFenceSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceFenceSet(int id)
        {
            var raceFenceSet = await _context.RaceFenceSets.FindAsync(id);
            if (raceFenceSet == null)
            {
                return NotFound();
            }

            _context.RaceFenceSets.Remove(raceFenceSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceFenceSetExists(int id)
        {
            return _context.RaceFenceSets.Any(e => e.Id == id);
        }
    }
}
