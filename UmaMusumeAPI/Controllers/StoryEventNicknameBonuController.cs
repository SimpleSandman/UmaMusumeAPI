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
    public class StoryEventNicknameBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventNicknameBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventNicknameBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventNicknameBonu>>> GetStoryEventNicknameBonus()
        {
            return await _context.StoryEventNicknameBonus.ToListAsync();
        }

        // GET: api/StoryEventNicknameBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventNicknameBonu>> GetStoryEventNicknameBonu(int id)
        {
            var storyEventNicknameBonu = await _context.StoryEventNicknameBonus.FindAsync(id);

            if (storyEventNicknameBonu == null)
            {
                return NotFound();
            }

            return storyEventNicknameBonu;
        }

        // PUT: api/StoryEventNicknameBonu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventNicknameBonu(int id, StoryEventNicknameBonu storyEventNicknameBonu)
        {
            if (id != storyEventNicknameBonu.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventNicknameBonu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventNicknameBonuExists(id))
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

        // POST: api/StoryEventNicknameBonu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventNicknameBonu>> PostStoryEventNicknameBonu(StoryEventNicknameBonu storyEventNicknameBonu)
        {
            _context.StoryEventNicknameBonus.Add(storyEventNicknameBonu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventNicknameBonuExists(storyEventNicknameBonu.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventNicknameBonu", new { id = storyEventNicknameBonu.Id }, storyEventNicknameBonu);
        }

        // DELETE: api/StoryEventNicknameBonu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventNicknameBonu(int id)
        {
            var storyEventNicknameBonu = await _context.StoryEventNicknameBonus.FindAsync(id);
            if (storyEventNicknameBonu == null)
            {
                return NotFound();
            }

            _context.StoryEventNicknameBonus.Remove(storyEventNicknameBonu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventNicknameBonuExists(int id)
        {
            return _context.StoryEventNicknameBonus.Any(e => e.Id == id);
        }
    }
}
