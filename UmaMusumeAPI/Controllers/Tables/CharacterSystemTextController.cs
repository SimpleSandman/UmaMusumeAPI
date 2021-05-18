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
    public class CharacterSystemTextController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharacterSystemTextController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSystemText
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSystemText>>> GetCharacterSystemTexts()
        {
            return await _context.CharacterSystemTexts.ToListAsync();
        }

        // GET: api/CharacterSystemText/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSystemText>> GetCharacterSystemText(int id)
        {
            var characterSystemText = await _context.CharacterSystemTexts.FindAsync(id);

            if (characterSystemText == null)
            {
                return NotFound();
            }

            return characterSystemText;
        }

        // PUT: api/CharacterSystemText/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSystemText(int id, CharacterSystemText characterSystemText)
        {
            if (id != characterSystemText.CharacterId)
            {
                return BadRequest();
            }

            _context.Entry(characterSystemText).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSystemTextExists(id))
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

        // POST: api/CharacterSystemText
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharacterSystemText>> PostCharacterSystemText(CharacterSystemText characterSystemText)
        {
            _context.CharacterSystemTexts.Add(characterSystemText);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterSystemTextExists(characterSystemText.CharacterId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterSystemText", new { id = characterSystemText.CharacterId }, characterSystemText);
        }

        // DELETE: api/CharacterSystemText/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterSystemText(int id)
        {
            var characterSystemText = await _context.CharacterSystemTexts.FindAsync(id);
            if (characterSystemText == null)
            {
                return NotFound();
            }

            _context.CharacterSystemTexts.Remove(characterSystemText);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterSystemTextExists(int id)
        {
            return _context.CharacterSystemTexts.Any(e => e.CharacterId == id);
        }
    }
}
