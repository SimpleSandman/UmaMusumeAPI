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
    public class NoteProfileController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NoteProfileController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NoteProfile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteProfile>>> GetNoteProfiles()
        {
            return await _context.NoteProfiles.ToListAsync();
        }

        // GET: api/NoteProfile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteProfile>> GetNoteProfile(int id)
        {
            var noteProfile = await _context.NoteProfiles.FindAsync(id);

            if (noteProfile == null)
            {
                return NotFound();
            }

            return noteProfile;
        }

        // PUT: api/NoteProfile/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNoteProfile(int id, NoteProfile noteProfile)
        {
            if (id != noteProfile.Id)
            {
                return BadRequest();
            }

            _context.Entry(noteProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteProfileExists(id))
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

        // POST: api/NoteProfile
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NoteProfile>> PostNoteProfile(NoteProfile noteProfile)
        {
            _context.NoteProfiles.Add(noteProfile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NoteProfileExists(noteProfile.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNoteProfile", new { id = noteProfile.Id }, noteProfile);
        }

        // DELETE: api/NoteProfile/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNoteProfile(int id)
        {
            var noteProfile = await _context.NoteProfiles.FindAsync(id);
            if (noteProfile == null)
            {
                return NotFound();
            }

            _context.NoteProfiles.Remove(noteProfile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NoteProfileExists(int id)
        {
            return _context.NoteProfiles.Any(e => e.Id == id);
        }
    }
}
