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
    public class StoryEventRouletteBingoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventRouletteBingoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventRouletteBingo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventRouletteBingo>>> GetStoryEventRouletteBingos()
        {
            return await _context.StoryEventRouletteBingos.ToListAsync();
        }

        // GET: api/StoryEventRouletteBingo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventRouletteBingo>> GetStoryEventRouletteBingo(int id)
        {
            var storyEventRouletteBingo = await _context.StoryEventRouletteBingos.FindAsync(id);

            if (storyEventRouletteBingo == null)
            {
                return NotFound();
            }

            return storyEventRouletteBingo;
        }

        // PUT: api/StoryEventRouletteBingo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventRouletteBingo(int id, StoryEventRouletteBingo storyEventRouletteBingo)
        {
            if (id != storyEventRouletteBingo.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventRouletteBingo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventRouletteBingoExists(id))
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

        // POST: api/StoryEventRouletteBingo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventRouletteBingo>> PostStoryEventRouletteBingo(StoryEventRouletteBingo storyEventRouletteBingo)
        {
            _context.StoryEventRouletteBingos.Add(storyEventRouletteBingo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventRouletteBingoExists(storyEventRouletteBingo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventRouletteBingo", new { id = storyEventRouletteBingo.Id }, storyEventRouletteBingo);
        }

        // DELETE: api/StoryEventRouletteBingo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventRouletteBingo(int id)
        {
            var storyEventRouletteBingo = await _context.StoryEventRouletteBingos.FindAsync(id);
            if (storyEventRouletteBingo == null)
            {
                return NotFound();
            }

            _context.StoryEventRouletteBingos.Remove(storyEventRouletteBingo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventRouletteBingoExists(int id)
        {
            return _context.StoryEventRouletteBingos.Any(e => e.Id == id);
        }
    }
}
