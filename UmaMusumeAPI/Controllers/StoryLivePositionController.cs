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
    public class StoryLivePositionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryLivePositionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryLivePosition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryLivePosition>>> GetStoryLivePositions()
        {
            return await _context.StoryLivePositions.ToListAsync();
        }

        // GET: api/StoryLivePosition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryLivePosition>> GetStoryLivePosition(int id)
        {
            var storyLivePosition = await _context.StoryLivePositions.FindAsync(id);

            if (storyLivePosition == null)
            {
                return NotFound();
            }

            return storyLivePosition;
        }

        // PUT: api/StoryLivePosition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryLivePosition(int id, StoryLivePosition storyLivePosition)
        {
            if (id != storyLivePosition.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyLivePosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryLivePositionExists(id))
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

        // POST: api/StoryLivePosition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryLivePosition>> PostStoryLivePosition(StoryLivePosition storyLivePosition)
        {
            _context.StoryLivePositions.Add(storyLivePosition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryLivePositionExists(storyLivePosition.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryLivePosition", new { id = storyLivePosition.Id }, storyLivePosition);
        }

        // DELETE: api/StoryLivePosition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryLivePosition(int id)
        {
            var storyLivePosition = await _context.StoryLivePositions.FindAsync(id);
            if (storyLivePosition == null)
            {
                return NotFound();
            }

            _context.StoryLivePositions.Remove(storyLivePosition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryLivePositionExists(int id)
        {
            return _context.StoryLivePositions.Any(e => e.Id == id);
        }
    }
}
