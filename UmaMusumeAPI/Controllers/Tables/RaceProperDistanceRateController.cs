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
    public class RaceProperDistanceRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperDistanceRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperDistanceRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperDistanceRate>>> GetRaceProperDistanceRates()
        {
            return await _context.RaceProperDistanceRates.ToListAsync();
        }

        // GET: api/RaceProperDistanceRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperDistanceRate>> GetRaceProperDistanceRate(int id)
        {
            var raceProperDistanceRate = await _context.RaceProperDistanceRates.FindAsync(id);

            if (raceProperDistanceRate == null)
            {
                return NotFound();
            }

            return raceProperDistanceRate;
        }

        // PUT: api/RaceProperDistanceRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceProperDistanceRate(int id, RaceProperDistanceRate raceProperDistanceRate)
        {
            if (id != raceProperDistanceRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceProperDistanceRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceProperDistanceRateExists(id))
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

        // POST: api/RaceProperDistanceRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceProperDistanceRate>> PostRaceProperDistanceRate(RaceProperDistanceRate raceProperDistanceRate)
        {
            _context.RaceProperDistanceRates.Add(raceProperDistanceRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceProperDistanceRateExists(raceProperDistanceRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceProperDistanceRate", new { id = raceProperDistanceRate.Id }, raceProperDistanceRate);
        }

        // DELETE: api/RaceProperDistanceRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceProperDistanceRate(int id)
        {
            var raceProperDistanceRate = await _context.RaceProperDistanceRates.FindAsync(id);
            if (raceProperDistanceRate == null)
            {
                return NotFound();
            }

            _context.RaceProperDistanceRates.Remove(raceProperDistanceRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceProperDistanceRateExists(int id)
        {
            return _context.RaceProperDistanceRates.Any(e => e.Id == id);
        }
    }
}
