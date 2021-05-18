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
    public class AnnounceCharacterController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceCharacterController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceCharacter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceCharacter>>> GetAnnounceCharacters()
        {
            return await _context.AnnounceCharacters.ToListAsync();
        }

        // GET: api/AnnounceCharacter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceCharacter>> GetAnnounceCharacter(int id)
        {
            var announceCharacter = await _context.AnnounceCharacters.FindAsync(id);

            if (announceCharacter == null)
            {
                return NotFound();
            }

            return announceCharacter;
        }

        // PUT: api/AnnounceCharacter/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnnounceCharacter(int id, AnnounceCharacter announceCharacter)
        {
            if (id != announceCharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(announceCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnnounceCharacterExists(id))
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

        // POST: api/AnnounceCharacter
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnnounceCharacter>> PostAnnounceCharacter(AnnounceCharacter announceCharacter)
        {
            _context.AnnounceCharacters.Add(announceCharacter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnnounceCharacterExists(announceCharacter.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnnounceCharacter", new { id = announceCharacter.Id }, announceCharacter);
        }

        // DELETE: api/AnnounceCharacter/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnounceCharacter(int id)
        {
            var announceCharacter = await _context.AnnounceCharacters.FindAsync(id);
            if (announceCharacter == null)
            {
                return NotFound();
            }

            _context.AnnounceCharacters.Remove(announceCharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnnounceCharacterExists(int id)
        {
            return _context.AnnounceCharacters.Any(e => e.Id == id);
        }
    }
}
