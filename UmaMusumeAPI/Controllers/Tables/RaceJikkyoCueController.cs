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
    public class RaceJikkyoCueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoCueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoCue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoCue>>> GetRaceJikkyoCues()
        {
            return await _context.RaceJikkyoCues.ToListAsync();
        }

        // GET: api/RaceJikkyoCue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoCue>> GetRaceJikkyoCue(int id)
        {
            var raceJikkyoCue = await _context.RaceJikkyoCues.FindAsync(id);

            if (raceJikkyoCue == null)
            {
                return NotFound();
            }

            return raceJikkyoCue;
        }

        // PUT: api/RaceJikkyoCue/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoCue(int id, RaceJikkyoCue raceJikkyoCue)
        {
            if (id != raceJikkyoCue.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoCue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoCueExists(id))
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

        // POST: api/RaceJikkyoCue
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoCue>> PostRaceJikkyoCue(RaceJikkyoCue raceJikkyoCue)
        {
            _context.RaceJikkyoCues.Add(raceJikkyoCue);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoCueExists(raceJikkyoCue.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoCue", new { id = raceJikkyoCue.Id }, raceJikkyoCue);
        }

        // DELETE: api/RaceJikkyoCue/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoCue(int id)
        {
            var raceJikkyoCue = await _context.RaceJikkyoCues.FindAsync(id);
            if (raceJikkyoCue == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoCues.Remove(raceJikkyoCue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoCueExists(int id)
        {
            return _context.RaceJikkyoCues.Any(e => e.Id == id);
        }
    }
}
