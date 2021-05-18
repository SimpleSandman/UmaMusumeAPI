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
    public class RaceBgmCutinExtensionTimeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmCutinExtensionTimeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgmCutinExtensionTime
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgmCutinExtensionTime>>> GetRaceBgmCutinExtensionTimes()
        {
            return await _context.RaceBgmCutinExtensionTimes.ToListAsync();
        }

        // GET: api/RaceBgmCutinExtensionTime/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgmCutinExtensionTime>> GetRaceBgmCutinExtensionTime(int id)
        {
            var raceBgmCutinExtensionTime = await _context.RaceBgmCutinExtensionTimes.FindAsync(id);

            if (raceBgmCutinExtensionTime == null)
            {
                return NotFound();
            }

            return raceBgmCutinExtensionTime;
        }

        // PUT: api/RaceBgmCutinExtensionTime/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceBgmCutinExtensionTime(int id, RaceBgmCutinExtensionTime raceBgmCutinExtensionTime)
        {
            if (id != raceBgmCutinExtensionTime.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceBgmCutinExtensionTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceBgmCutinExtensionTimeExists(id))
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

        // POST: api/RaceBgmCutinExtensionTime
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceBgmCutinExtensionTime>> PostRaceBgmCutinExtensionTime(RaceBgmCutinExtensionTime raceBgmCutinExtensionTime)
        {
            _context.RaceBgmCutinExtensionTimes.Add(raceBgmCutinExtensionTime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceBgmCutinExtensionTimeExists(raceBgmCutinExtensionTime.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceBgmCutinExtensionTime", new { id = raceBgmCutinExtensionTime.Id }, raceBgmCutinExtensionTime);
        }

        // DELETE: api/RaceBgmCutinExtensionTime/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceBgmCutinExtensionTime(int id)
        {
            var raceBgmCutinExtensionTime = await _context.RaceBgmCutinExtensionTimes.FindAsync(id);
            if (raceBgmCutinExtensionTime == null)
            {
                return NotFound();
            }

            _context.RaceBgmCutinExtensionTimes.Remove(raceBgmCutinExtensionTime);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceBgmCutinExtensionTimeExists(int id)
        {
            return _context.RaceBgmCutinExtensionTimes.Any(e => e.Id == id);
        }
    }
}
