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
    public class DailyRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRace>>> GetDailyRaces()
        {
            return await _context.DailyRaces.ToListAsync();
        }

        // GET: api/DailyRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRace>> GetDailyRace(int id)
        {
            var dailyRace = await _context.DailyRaces.FindAsync(id);

            if (dailyRace == null)
            {
                return NotFound();
            }

            return dailyRace;
        }

        // PUT: api/DailyRace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailyRace(int id, DailyRace dailyRace)
        {
            if (id != dailyRace.Id)
            {
                return BadRequest();
            }

            _context.Entry(dailyRace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyRaceExists(id))
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

        // POST: api/DailyRace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DailyRace>> PostDailyRace(DailyRace dailyRace)
        {
            _context.DailyRaces.Add(dailyRace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DailyRaceExists(dailyRace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDailyRace", new { id = dailyRace.Id }, dailyRace);
        }

        // DELETE: api/DailyRace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDailyRace(int id)
        {
            var dailyRace = await _context.DailyRaces.FindAsync(id);
            if (dailyRace == null)
            {
                return NotFound();
            }

            _context.DailyRaces.Remove(dailyRace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DailyRaceExists(int id)
        {
            return _context.DailyRaces.Any(e => e.Id == id);
        }
    }
}
