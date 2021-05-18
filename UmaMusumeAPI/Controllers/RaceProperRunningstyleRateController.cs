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
    public class RaceProperRunningstyleRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceProperRunningstyleRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceProperRunningstyleRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceProperRunningstyleRate>>> GetRaceProperRunningstyleRates()
        {
            return await _context.RaceProperRunningstyleRates.ToListAsync();
        }

        // GET: api/RaceProperRunningstyleRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceProperRunningstyleRate>> GetRaceProperRunningstyleRate(int id)
        {
            var raceProperRunningstyleRate = await _context.RaceProperRunningstyleRates.FindAsync(id);

            if (raceProperRunningstyleRate == null)
            {
                return NotFound();
            }

            return raceProperRunningstyleRate;
        }

        // PUT: api/RaceProperRunningstyleRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceProperRunningstyleRate(int id, RaceProperRunningstyleRate raceProperRunningstyleRate)
        {
            if (id != raceProperRunningstyleRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceProperRunningstyleRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceProperRunningstyleRateExists(id))
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

        // POST: api/RaceProperRunningstyleRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceProperRunningstyleRate>> PostRaceProperRunningstyleRate(RaceProperRunningstyleRate raceProperRunningstyleRate)
        {
            _context.RaceProperRunningstyleRates.Add(raceProperRunningstyleRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceProperRunningstyleRateExists(raceProperRunningstyleRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceProperRunningstyleRate", new { id = raceProperRunningstyleRate.Id }, raceProperRunningstyleRate);
        }

        // DELETE: api/RaceProperRunningstyleRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceProperRunningstyleRate(int id)
        {
            var raceProperRunningstyleRate = await _context.RaceProperRunningstyleRates.FindAsync(id);
            if (raceProperRunningstyleRate == null)
            {
                return NotFound();
            }

            _context.RaceProperRunningstyleRates.Remove(raceProperRunningstyleRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceProperRunningstyleRateExists(int id)
        {
            return _context.RaceProperRunningstyleRates.Any(e => e.Id == id);
        }
    }
}
