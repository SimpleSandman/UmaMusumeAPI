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
    public class RaceTrackController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrackController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrack>>> GetRaceTracks()
        {
            return await _context.RaceTracks.ToListAsync();
        }

        // GET: api/RaceTrack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrack>> GetRaceTrack(int id)
        {
            var raceTrack = await _context.RaceTracks.FindAsync(id);

            if (raceTrack == null)
            {
                return NotFound();
            }

            return raceTrack;
        }

        // PUT: api/RaceTrack/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceTrack(int id, RaceTrack raceTrack)
        {
            if (id != raceTrack.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceTrack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceTrackExists(id))
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

        // POST: api/RaceTrack
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceTrack>> PostRaceTrack(RaceTrack raceTrack)
        {
            _context.RaceTracks.Add(raceTrack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceTrackExists(raceTrack.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceTrack", new { id = raceTrack.Id }, raceTrack);
        }

        // DELETE: api/RaceTrack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceTrack(int id)
        {
            var raceTrack = await _context.RaceTracks.FindAsync(id);
            if (raceTrack == null)
            {
                return NotFound();
            }

            _context.RaceTracks.Remove(raceTrack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceTrackExists(int id)
        {
            return _context.RaceTracks.Any(e => e.Id == id);
        }
    }
}
