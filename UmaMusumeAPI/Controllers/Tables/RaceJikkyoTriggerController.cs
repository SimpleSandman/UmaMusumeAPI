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
    public class RaceJikkyoTriggerController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoTriggerController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoTrigger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoTrigger>>> GetRaceJikkyoTriggers()
        {
            return await _context.RaceJikkyoTriggers.ToListAsync();
        }

        // GET: api/RaceJikkyoTrigger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoTrigger>> GetRaceJikkyoTrigger(int id)
        {
            var raceJikkyoTrigger = await _context.RaceJikkyoTriggers.FindAsync(id);

            if (raceJikkyoTrigger == null)
            {
                return NotFound();
            }

            return raceJikkyoTrigger;
        }

        // PUT: api/RaceJikkyoTrigger/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoTrigger(int id, RaceJikkyoTrigger raceJikkyoTrigger)
        {
            if (id != raceJikkyoTrigger.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoTrigger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoTriggerExists(id))
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

        // POST: api/RaceJikkyoTrigger
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoTrigger>> PostRaceJikkyoTrigger(RaceJikkyoTrigger raceJikkyoTrigger)
        {
            _context.RaceJikkyoTriggers.Add(raceJikkyoTrigger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoTriggerExists(raceJikkyoTrigger.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoTrigger", new { id = raceJikkyoTrigger.Id }, raceJikkyoTrigger);
        }

        // DELETE: api/RaceJikkyoTrigger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoTrigger(int id)
        {
            var raceJikkyoTrigger = await _context.RaceJikkyoTriggers.FindAsync(id);
            if (raceJikkyoTrigger == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoTriggers.Remove(raceJikkyoTrigger);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoTriggerExists(int id)
        {
            return _context.RaceJikkyoTriggers.Any(e => e.Id == id);
        }
    }
}
