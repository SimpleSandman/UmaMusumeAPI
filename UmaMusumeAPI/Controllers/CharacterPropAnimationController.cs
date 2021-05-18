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
    public class CharacterPropAnimationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharacterPropAnimationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharacterPropAnimation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterPropAnimation>>> GetCharacterPropAnimations()
        {
            return await _context.CharacterPropAnimations.ToListAsync();
        }

        // GET: api/CharacterPropAnimation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterPropAnimation>> GetCharacterPropAnimation(int id)
        {
            var characterPropAnimation = await _context.CharacterPropAnimations.FindAsync(id);

            if (characterPropAnimation == null)
            {
                return NotFound();
            }

            return characterPropAnimation;
        }

        // PUT: api/CharacterPropAnimation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterPropAnimation(int id, CharacterPropAnimation characterPropAnimation)
        {
            if (id != characterPropAnimation.Id)
            {
                return BadRequest();
            }

            _context.Entry(characterPropAnimation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterPropAnimationExists(id))
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

        // POST: api/CharacterPropAnimation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharacterPropAnimation>> PostCharacterPropAnimation(CharacterPropAnimation characterPropAnimation)
        {
            _context.CharacterPropAnimations.Add(characterPropAnimation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterPropAnimationExists(characterPropAnimation.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterPropAnimation", new { id = characterPropAnimation.Id }, characterPropAnimation);
        }

        // DELETE: api/CharacterPropAnimation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterPropAnimation(int id)
        {
            var characterPropAnimation = await _context.CharacterPropAnimations.FindAsync(id);
            if (characterPropAnimation == null)
            {
                return NotFound();
            }

            _context.CharacterPropAnimations.Remove(characterPropAnimation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterPropAnimationExists(int id)
        {
            return _context.CharacterPropAnimations.Any(e => e.Id == id);
        }
    }
}
