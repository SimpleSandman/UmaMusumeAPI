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
    public class StoryLiveSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryLiveSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryLiveSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryLiveSet>>> GetStoryLiveSets()
        {
            return await _context.StoryLiveSets.ToListAsync();
        }

        // GET: api/StoryLiveSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryLiveSet>> GetStoryLiveSet(int id)
        {
            var storyLiveSet = await _context.StoryLiveSets.FindAsync(id);

            if (storyLiveSet == null)
            {
                return NotFound();
            }

            return storyLiveSet;
        }

        // PUT: api/StoryLiveSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryLiveSet(int id, StoryLiveSet storyLiveSet)
        {
            if (id != storyLiveSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyLiveSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryLiveSetExists(id))
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

        // POST: api/StoryLiveSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryLiveSet>> PostStoryLiveSet(StoryLiveSet storyLiveSet)
        {
            _context.StoryLiveSets.Add(storyLiveSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryLiveSetExists(storyLiveSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryLiveSet", new { id = storyLiveSet.Id }, storyLiveSet);
        }

        // DELETE: api/StoryLiveSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryLiveSet(int id)
        {
            var storyLiveSet = await _context.StoryLiveSets.FindAsync(id);
            if (storyLiveSet == null)
            {
                return NotFound();
            }

            _context.StoryLiveSets.Remove(storyLiveSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryLiveSetExists(int id)
        {
            return _context.StoryLiveSets.Any(e => e.Id == id);
        }
    }
}
