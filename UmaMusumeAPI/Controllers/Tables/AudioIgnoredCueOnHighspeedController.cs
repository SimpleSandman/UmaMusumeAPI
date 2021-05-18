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
    public class AudioIgnoredCueOnHighspeedController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudioIgnoredCueOnHighspeedController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudioIgnoredCueOnHighspeed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioIgnoredCueOnHighspeed>>> GetAudioIgnoredCueOnHighspeeds()
        {
            return await _context.AudioIgnoredCueOnHighspeeds.ToListAsync();
        }

        // GET: api/AudioIgnoredCueOnHighspeed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AudioIgnoredCueOnHighspeed>> GetAudioIgnoredCueOnHighspeed(int id)
        {
            var audioIgnoredCueOnHighspeed = await _context.AudioIgnoredCueOnHighspeeds.FindAsync(id);

            if (audioIgnoredCueOnHighspeed == null)
            {
                return NotFound();
            }

            return audioIgnoredCueOnHighspeed;
        }

        // PUT: api/AudioIgnoredCueOnHighspeed/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAudioIgnoredCueOnHighspeed(int id, AudioIgnoredCueOnHighspeed audioIgnoredCueOnHighspeed)
        {
            if (id != audioIgnoredCueOnHighspeed.Id)
            {
                return BadRequest();
            }

            _context.Entry(audioIgnoredCueOnHighspeed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AudioIgnoredCueOnHighspeedExists(id))
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

        // POST: api/AudioIgnoredCueOnHighspeed
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AudioIgnoredCueOnHighspeed>> PostAudioIgnoredCueOnHighspeed(AudioIgnoredCueOnHighspeed audioIgnoredCueOnHighspeed)
        {
            _context.AudioIgnoredCueOnHighspeeds.Add(audioIgnoredCueOnHighspeed);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AudioIgnoredCueOnHighspeedExists(audioIgnoredCueOnHighspeed.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAudioIgnoredCueOnHighspeed", new { id = audioIgnoredCueOnHighspeed.Id }, audioIgnoredCueOnHighspeed);
        }

        // DELETE: api/AudioIgnoredCueOnHighspeed/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAudioIgnoredCueOnHighspeed(int id)
        {
            var audioIgnoredCueOnHighspeed = await _context.AudioIgnoredCueOnHighspeeds.FindAsync(id);
            if (audioIgnoredCueOnHighspeed == null)
            {
                return NotFound();
            }

            _context.AudioIgnoredCueOnHighspeeds.Remove(audioIgnoredCueOnHighspeed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AudioIgnoredCueOnHighspeedExists(int id)
        {
            return _context.AudioIgnoredCueOnHighspeeds.Any(e => e.Id == id);
        }
    }
}
