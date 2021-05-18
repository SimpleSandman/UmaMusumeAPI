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
    public class RaceBgmPatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmPatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgmPattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgmPattern>>> GetRaceBgmPatterns()
        {
            return await _context.RaceBgmPatterns.ToListAsync();
        }

        // GET: api/RaceBgmPattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgmPattern>> GetRaceBgmPattern(int id)
        {
            var raceBgmPattern = await _context.RaceBgmPatterns.FindAsync(id);

            if (raceBgmPattern == null)
            {
                return NotFound();
            }

            return raceBgmPattern;
        }

        // PUT: api/RaceBgmPattern/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceBgmPattern(int id, RaceBgmPattern raceBgmPattern)
        {
            if (id != raceBgmPattern.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceBgmPattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceBgmPatternExists(id))
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

        // POST: api/RaceBgmPattern
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceBgmPattern>> PostRaceBgmPattern(RaceBgmPattern raceBgmPattern)
        {
            _context.RaceBgmPatterns.Add(raceBgmPattern);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceBgmPatternExists(raceBgmPattern.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceBgmPattern", new { id = raceBgmPattern.Id }, raceBgmPattern);
        }

        // DELETE: api/RaceBgmPattern/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceBgmPattern(int id)
        {
            var raceBgmPattern = await _context.RaceBgmPatterns.FindAsync(id);
            if (raceBgmPattern == null)
            {
                return NotFound();
            }

            _context.RaceBgmPatterns.Remove(raceBgmPattern);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceBgmPatternExists(int id)
        {
            return _context.RaceBgmPatterns.Any(e => e.Id == id);
        }
    }
}
