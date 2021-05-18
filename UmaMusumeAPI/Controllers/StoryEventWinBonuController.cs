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
    public class StoryEventWinBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventWinBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventWinBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventWinBonu>>> GetStoryEventWinBonus()
        {
            return await _context.StoryEventWinBonus.ToListAsync();
        }

        // GET: api/StoryEventWinBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventWinBonu>> GetStoryEventWinBonu(int id)
        {
            var storyEventWinBonu = await _context.StoryEventWinBonus.FindAsync(id);

            if (storyEventWinBonu == null)
            {
                return NotFound();
            }

            return storyEventWinBonu;
        }

        // PUT: api/StoryEventWinBonu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventWinBonu(int id, StoryEventWinBonu storyEventWinBonu)
        {
            if (id != storyEventWinBonu.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventWinBonu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventWinBonuExists(id))
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

        // POST: api/StoryEventWinBonu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventWinBonu>> PostStoryEventWinBonu(StoryEventWinBonu storyEventWinBonu)
        {
            _context.StoryEventWinBonus.Add(storyEventWinBonu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventWinBonuExists(storyEventWinBonu.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventWinBonu", new { id = storyEventWinBonu.Id }, storyEventWinBonu);
        }

        // DELETE: api/StoryEventWinBonu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventWinBonu(int id)
        {
            var storyEventWinBonu = await _context.StoryEventWinBonus.FindAsync(id);
            if (storyEventWinBonu == null)
            {
                return NotFound();
            }

            _context.StoryEventWinBonus.Remove(storyEventWinBonu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventWinBonuExists(int id)
        {
            return _context.StoryEventWinBonus.Any(e => e.Id == id);
        }
    }
}
