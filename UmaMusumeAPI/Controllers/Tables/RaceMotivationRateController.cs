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
    public class RaceMotivationRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceMotivationRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceMotivationRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceMotivationRate>>> GetRaceMotivationRates()
        {
            return await _context.RaceMotivationRates.ToListAsync();
        }

        // GET: api/RaceMotivationRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceMotivationRate>> GetRaceMotivationRate(int id)
        {
            var raceMotivationRate = await _context.RaceMotivationRates.FindAsync(id);

            if (raceMotivationRate == null)
            {
                return NotFound();
            }

            return raceMotivationRate;
        }

        // PUT: api/RaceMotivationRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceMotivationRate(int id, RaceMotivationRate raceMotivationRate)
        {
            if (id != raceMotivationRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceMotivationRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceMotivationRateExists(id))
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

        // POST: api/RaceMotivationRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceMotivationRate>> PostRaceMotivationRate(RaceMotivationRate raceMotivationRate)
        {
            _context.RaceMotivationRates.Add(raceMotivationRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceMotivationRateExists(raceMotivationRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceMotivationRate", new { id = raceMotivationRate.Id }, raceMotivationRate);
        }

        // DELETE: api/RaceMotivationRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceMotivationRate(int id)
        {
            var raceMotivationRate = await _context.RaceMotivationRates.FindAsync(id);
            if (raceMotivationRate == null)
            {
                return NotFound();
            }

            _context.RaceMotivationRates.Remove(raceMotivationRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceMotivationRateExists(int id)
        {
            return _context.RaceMotivationRates.Any(e => e.Id == id);
        }
    }
}
