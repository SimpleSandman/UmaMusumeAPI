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
    public class AudioCuesheetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudioCuesheetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudioCuesheet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioCuesheet>>> GetAudioCuesheets()
        {
            return await _context.AudioCuesheets.ToListAsync();
        }

        // GET: api/AudioCuesheet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AudioCuesheet>> GetAudioCuesheet(int id)
        {
            var audioCuesheet = await _context.AudioCuesheets.FindAsync(id);

            if (audioCuesheet == null)
            {
                return NotFound();
            }

            return audioCuesheet;
        }

        // PUT: api/AudioCuesheet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAudioCuesheet(int id, AudioCuesheet audioCuesheet)
        {
            if (id != audioCuesheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(audioCuesheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AudioCuesheetExists(id))
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

        // POST: api/AudioCuesheet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AudioCuesheet>> PostAudioCuesheet(AudioCuesheet audioCuesheet)
        {
            _context.AudioCuesheets.Add(audioCuesheet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AudioCuesheetExists(audioCuesheet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAudioCuesheet", new { id = audioCuesheet.Id }, audioCuesheet);
        }

        // DELETE: api/AudioCuesheet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAudioCuesheet(int id)
        {
            var audioCuesheet = await _context.AudioCuesheets.FindAsync(id);
            if (audioCuesheet == null)
            {
                return NotFound();
            }

            _context.AudioCuesheets.Remove(audioCuesheet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AudioCuesheetExists(int id)
        {
            return _context.AudioCuesheets.Any(e => e.Id == id);
        }
    }
}
