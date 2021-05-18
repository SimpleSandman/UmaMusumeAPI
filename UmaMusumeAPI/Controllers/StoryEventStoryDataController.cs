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
    public class StoryEventStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventStoryData>>> GetStoryEventStoryData()
        {
            return await _context.StoryEventStoryData.ToListAsync();
        }

        // GET: api/StoryEventStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventStoryData>> GetStoryEventStoryData(int id)
        {
            var storyEventStoryData = await _context.StoryEventStoryData.FindAsync(id);

            if (storyEventStoryData == null)
            {
                return NotFound();
            }

            return storyEventStoryData;
        }

        // PUT: api/StoryEventStoryData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventStoryData(int id, StoryEventStoryData storyEventStoryData)
        {
            if (id != storyEventStoryData.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventStoryData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventStoryDataExists(id))
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

        // POST: api/StoryEventStoryData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventStoryData>> PostStoryEventStoryData(StoryEventStoryData storyEventStoryData)
        {
            _context.StoryEventStoryData.Add(storyEventStoryData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventStoryDataExists(storyEventStoryData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventStoryData", new { id = storyEventStoryData.Id }, storyEventStoryData);
        }

        // DELETE: api/StoryEventStoryData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventStoryData(int id)
        {
            var storyEventStoryData = await _context.StoryEventStoryData.FindAsync(id);
            if (storyEventStoryData == null)
            {
                return NotFound();
            }

            _context.StoryEventStoryData.Remove(storyEventStoryData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventStoryDataExists(int id)
        {
            return _context.StoryEventStoryData.Any(e => e.Id == id);
        }
    }
}
