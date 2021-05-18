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
    public class StoryHipOffsetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryHipOffsetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryHipOffset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryHipOffset>>> GetStoryHipOffsets()
        {
            return await _context.StoryHipOffsets.ToListAsync();
        }

        // GET: api/StoryHipOffset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryHipOffset>> GetStoryHipOffset(long id)
        {
            var storyHipOffset = await _context.StoryHipOffsets.FindAsync(id);

            if (storyHipOffset == null)
            {
                return NotFound();
            }

            return storyHipOffset;
        }

        // PUT: api/StoryHipOffset/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryHipOffset(long id, StoryHipOffset storyHipOffset)
        {
            if (id != storyHipOffset.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(storyHipOffset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryHipOffsetExists(id))
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

        // POST: api/StoryHipOffset
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryHipOffset>> PostStoryHipOffset(StoryHipOffset storyHipOffset)
        {
            _context.StoryHipOffsets.Add(storyHipOffset);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryHipOffsetExists(storyHipOffset.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryHipOffset", new { id = storyHipOffset.CategoryId }, storyHipOffset);
        }

        // DELETE: api/StoryHipOffset/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryHipOffset(long id)
        {
            var storyHipOffset = await _context.StoryHipOffsets.FindAsync(id);
            if (storyHipOffset == null)
            {
                return NotFound();
            }

            _context.StoryHipOffsets.Remove(storyHipOffset);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryHipOffsetExists(long id)
        {
            return _context.StoryHipOffsets.Any(e => e.CategoryId == id);
        }
    }
}
