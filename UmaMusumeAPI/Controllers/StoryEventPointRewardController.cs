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
    public class StoryEventPointRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventPointRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventPointReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventPointReward>>> GetStoryEventPointRewards()
        {
            return await _context.StoryEventPointRewards.ToListAsync();
        }

        // GET: api/StoryEventPointReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventPointReward>> GetStoryEventPointReward(int id)
        {
            var storyEventPointReward = await _context.StoryEventPointRewards.FindAsync(id);

            if (storyEventPointReward == null)
            {
                return NotFound();
            }

            return storyEventPointReward;
        }

        // PUT: api/StoryEventPointReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventPointReward(int id, StoryEventPointReward storyEventPointReward)
        {
            if (id != storyEventPointReward.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventPointReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventPointRewardExists(id))
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

        // POST: api/StoryEventPointReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventPointReward>> PostStoryEventPointReward(StoryEventPointReward storyEventPointReward)
        {
            _context.StoryEventPointRewards.Add(storyEventPointReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventPointRewardExists(storyEventPointReward.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventPointReward", new { id = storyEventPointReward.Id }, storyEventPointReward);
        }

        // DELETE: api/StoryEventPointReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventPointReward(int id)
        {
            var storyEventPointReward = await _context.StoryEventPointRewards.FindAsync(id);
            if (storyEventPointReward == null)
            {
                return NotFound();
            }

            _context.StoryEventPointRewards.Remove(storyEventPointReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventPointRewardExists(int id)
        {
            return _context.StoryEventPointRewards.Any(e => e.Id == id);
        }
    }
}
