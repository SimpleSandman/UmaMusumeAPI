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
    public class StoryStillController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryStillController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryStill
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryStill>>> GetStoryStills()
        {
            return await _context.StoryStills.ToListAsync();
        }

        // GET: api/StoryStill/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryStill>> GetStoryStill(int id)
        {
            var storyStill = await _context.StoryStills.FindAsync(id);

            if (storyStill == null)
            {
                return NotFound();
            }

            return storyStill;
        }

        // PUT: api/StoryStill/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryStill(int id, StoryStill storyStill)
        {
            if (id != storyStill.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyStill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryStillExists(id))
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

        // POST: api/StoryStill
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryStill>> PostStoryStill(StoryStill storyStill)
        {
            _context.StoryStills.Add(storyStill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryStillExists(storyStill.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryStill", new { id = storyStill.Id }, storyStill);
        }

        // DELETE: api/StoryStill/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryStill(int id)
        {
            var storyStill = await _context.StoryStills.FindAsync(id);
            if (storyStill == null)
            {
                return NotFound();
            }

            _context.StoryStills.Remove(storyStill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryStillExists(int id)
        {
            return _context.StoryStills.Any(e => e.Id == id);
        }
    }
}
