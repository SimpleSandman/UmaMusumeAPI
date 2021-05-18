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
    public class NoteProfileTextTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NoteProfileTextTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NoteProfileTextType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteProfileTextType>>> GetNoteProfileTextTypes()
        {
            return await _context.NoteProfileTextTypes.ToListAsync();
        }

        // GET: api/NoteProfileTextType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteProfileTextType>> GetNoteProfileTextType(int id)
        {
            var noteProfileTextType = await _context.NoteProfileTextTypes.FindAsync(id);

            if (noteProfileTextType == null)
            {
                return NotFound();
            }

            return noteProfileTextType;
        }

        // PUT: api/NoteProfileTextType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNoteProfileTextType(int id, NoteProfileTextType noteProfileTextType)
        {
            if (id != noteProfileTextType.Id)
            {
                return BadRequest();
            }

            _context.Entry(noteProfileTextType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteProfileTextTypeExists(id))
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

        // POST: api/NoteProfileTextType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NoteProfileTextType>> PostNoteProfileTextType(NoteProfileTextType noteProfileTextType)
        {
            _context.NoteProfileTextTypes.Add(noteProfileTextType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NoteProfileTextTypeExists(noteProfileTextType.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNoteProfileTextType", new { id = noteProfileTextType.Id }, noteProfileTextType);
        }

        // DELETE: api/NoteProfileTextType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNoteProfileTextType(int id)
        {
            var noteProfileTextType = await _context.NoteProfileTextTypes.FindAsync(id);
            if (noteProfileTextType == null)
            {
                return NotFound();
            }

            _context.NoteProfileTextTypes.Remove(noteProfileTextType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NoteProfileTextTypeExists(int id)
        {
            return _context.NoteProfileTextTypes.Any(e => e.Id == id);
        }
    }
}
