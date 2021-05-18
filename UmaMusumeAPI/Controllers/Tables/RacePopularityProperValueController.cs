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
    public class RacePopularityProperValueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RacePopularityProperValueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RacePopularityProperValue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RacePopularityProperValue>>> GetRacePopularityProperValues()
        {
            return await _context.RacePopularityProperValues.ToListAsync();
        }

        // GET: api/RacePopularityProperValue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RacePopularityProperValue>> GetRacePopularityProperValue(int id)
        {
            var racePopularityProperValue = await _context.RacePopularityProperValues.FindAsync(id);

            if (racePopularityProperValue == null)
            {
                return NotFound();
            }

            return racePopularityProperValue;
        }

        // PUT: api/RacePopularityProperValue/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRacePopularityProperValue(int id, RacePopularityProperValue racePopularityProperValue)
        {
            if (id != racePopularityProperValue.Id)
            {
                return BadRequest();
            }

            _context.Entry(racePopularityProperValue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacePopularityProperValueExists(id))
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

        // POST: api/RacePopularityProperValue
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RacePopularityProperValue>> PostRacePopularityProperValue(RacePopularityProperValue racePopularityProperValue)
        {
            _context.RacePopularityProperValues.Add(racePopularityProperValue);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RacePopularityProperValueExists(racePopularityProperValue.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRacePopularityProperValue", new { id = racePopularityProperValue.Id }, racePopularityProperValue);
        }

        // DELETE: api/RacePopularityProperValue/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRacePopularityProperValue(int id)
        {
            var racePopularityProperValue = await _context.RacePopularityProperValues.FindAsync(id);
            if (racePopularityProperValue == null)
            {
                return NotFound();
            }

            _context.RacePopularityProperValues.Remove(racePopularityProperValue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RacePopularityProperValueExists(int id)
        {
            return _context.RacePopularityProperValues.Any(e => e.Id == id);
        }
    }
}
