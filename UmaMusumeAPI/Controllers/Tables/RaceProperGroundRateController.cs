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
    public class RaceProperGroundRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperGroundRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperGroundRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperGroundRate>>> GetRaceProperGroundRates()
        {
            return await _context.RaceProperGroundRates.ToListAsync();
        }

        // GET: api/RaceProperGroundRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperGroundRate>> GetRaceProperGroundRate(int id)
        {
            var raceProperGroundRate = await _context.RaceProperGroundRates.FindAsync(id);

            if (raceProperGroundRate == null)
            {
                return NotFound();
            }

            return raceProperGroundRate;
        }

        // PUT: api/RaceProperGroundRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceProperGroundRate(int id, RaceProperGroundRate raceProperGroundRate)
        {
            if (id != raceProperGroundRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceProperGroundRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceProperGroundRateExists(id))
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

        // POST: api/RaceProperGroundRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceProperGroundRate>> PostRaceProperGroundRate(RaceProperGroundRate raceProperGroundRate)
        {
            _context.RaceProperGroundRates.Add(raceProperGroundRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceProperGroundRateExists(raceProperGroundRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceProperGroundRate", new { id = raceProperGroundRate.Id }, raceProperGroundRate);
        }

        // DELETE: api/RaceProperGroundRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceProperGroundRate(int id)
        {
            var raceProperGroundRate = await _context.RaceProperGroundRates.FindAsync(id);
            if (raceProperGroundRate == null)
            {
                return NotFound();
            }

            _context.RaceProperGroundRates.Remove(raceProperGroundRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceProperGroundRateExists(int id)
        {
            return _context.RaceProperGroundRates.Any(e => e.Id == id);
        }
    }
}
