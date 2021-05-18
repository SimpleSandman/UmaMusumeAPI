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
    public class StoryEventDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventData>>> GetStoryEventData()
        {
            return await _context.StoryEventData.ToListAsync();
        }

        // GET: api/StoryEventData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventData>> GetStoryEventData(int id)
        {
            var storyEventData = await _context.StoryEventData.FindAsync(id);

            if (storyEventData == null)
            {
                return NotFound();
            }

            return storyEventData;
        }

        // PUT: api/StoryEventData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventData(int id, StoryEventData storyEventData)
        {
            if (id != storyEventData.StoryEventId)
            {
                return BadRequest();
            }

            _context.Entry(storyEventData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventDataExists(id))
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

        // POST: api/StoryEventData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventData>> PostStoryEventData(StoryEventData storyEventData)
        {
            _context.StoryEventData.Add(storyEventData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventDataExists(storyEventData.StoryEventId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventData", new { id = storyEventData.StoryEventId }, storyEventData);
        }

        // DELETE: api/StoryEventData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventData(int id)
        {
            var storyEventData = await _context.StoryEventData.FindAsync(id);
            if (storyEventData == null)
            {
                return NotFound();
            }

            _context.StoryEventData.Remove(storyEventData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventDataExists(int id)
        {
            return _context.StoryEventData.Any(e => e.StoryEventId == id);
        }
    }
}
