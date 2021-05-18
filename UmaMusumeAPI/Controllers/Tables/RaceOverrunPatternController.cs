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
    public class RaceOverrunPatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceOverrunPatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceOverrunPattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceOverrunPattern>>> GetRaceOverrunPatterns()
        {
            return await _context.RaceOverrunPatterns.ToListAsync();
        }

        // GET: api/RaceOverrunPattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceOverrunPattern>> GetRaceOverrunPattern(int id)
        {
            var raceOverrunPattern = await _context.RaceOverrunPatterns.FindAsync(id);

            if (raceOverrunPattern == null)
            {
                return NotFound();
            }

            return raceOverrunPattern;
        }

        // PUT: api/RaceOverrunPattern/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceOverrunPattern(int id, RaceOverrunPattern raceOverrunPattern)
        {
            if (id != raceOverrunPattern.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceOverrunPattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceOverrunPatternExists(id))
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

        // POST: api/RaceOverrunPattern
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceOverrunPattern>> PostRaceOverrunPattern(RaceOverrunPattern raceOverrunPattern)
        {
            _context.RaceOverrunPatterns.Add(raceOverrunPattern);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceOverrunPatternExists(raceOverrunPattern.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceOverrunPattern", new { id = raceOverrunPattern.Id }, raceOverrunPattern);
        }

        // DELETE: api/RaceOverrunPattern/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceOverrunPattern(int id)
        {
            var raceOverrunPattern = await _context.RaceOverrunPatterns.FindAsync(id);
            if (raceOverrunPattern == null)
            {
                return NotFound();
            }

            _context.RaceOverrunPatterns.Remove(raceOverrunPattern);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceOverrunPatternExists(int id)
        {
            return _context.RaceOverrunPatterns.Any(e => e.Id == id);
        }
    }
}
