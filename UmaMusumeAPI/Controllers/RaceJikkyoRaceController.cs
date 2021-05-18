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
    public class RaceJikkyoRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoRace>>> GetRaceJikkyoRaces()
        {
            return await _context.RaceJikkyoRaces.ToListAsync();
        }

        // GET: api/RaceJikkyoRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoRace>> GetRaceJikkyoRace(int id)
        {
            var raceJikkyoRace = await _context.RaceJikkyoRaces.FindAsync(id);

            if (raceJikkyoRace == null)
            {
                return NotFound();
            }

            return raceJikkyoRace;
        }

        // PUT: api/RaceJikkyoRace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoRace(int id, RaceJikkyoRace raceJikkyoRace)
        {
            if (id != raceJikkyoRace.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoRace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoRaceExists(id))
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

        // POST: api/RaceJikkyoRace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoRace>> PostRaceJikkyoRace(RaceJikkyoRace raceJikkyoRace)
        {
            _context.RaceJikkyoRaces.Add(raceJikkyoRace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoRaceExists(raceJikkyoRace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoRace", new { id = raceJikkyoRace.Id }, raceJikkyoRace);
        }

        // DELETE: api/RaceJikkyoRace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoRace(int id)
        {
            var raceJikkyoRace = await _context.RaceJikkyoRaces.FindAsync(id);
            if (raceJikkyoRace == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoRaces.Remove(raceJikkyoRace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoRaceExists(int id)
        {
            return _context.RaceJikkyoRaces.Any(e => e.Id == id);
        }
    }
}
