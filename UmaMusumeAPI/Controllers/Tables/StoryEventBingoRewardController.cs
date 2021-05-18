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
    public class StoryEventBingoRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBingoRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBingoReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBingoReward>>> GetStoryEventBingoRewards()
        {
            return await _context.StoryEventBingoRewards.ToListAsync();
        }

        // GET: api/StoryEventBingoReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBingoReward>> GetStoryEventBingoReward(int id)
        {
            var storyEventBingoReward = await _context.StoryEventBingoRewards.FindAsync(id);

            if (storyEventBingoReward == null)
            {
                return NotFound();
            }

            return storyEventBingoReward;
        }

        // PUT: api/StoryEventBingoReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventBingoReward(int id, StoryEventBingoReward storyEventBingoReward)
        {
            if (id != storyEventBingoReward.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventBingoReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventBingoRewardExists(id))
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

        // POST: api/StoryEventBingoReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventBingoReward>> PostStoryEventBingoReward(StoryEventBingoReward storyEventBingoReward)
        {
            _context.StoryEventBingoRewards.Add(storyEventBingoReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventBingoRewardExists(storyEventBingoReward.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventBingoReward", new { id = storyEventBingoReward.Id }, storyEventBingoReward);
        }

        // DELETE: api/StoryEventBingoReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventBingoReward(int id)
        {
            var storyEventBingoReward = await _context.StoryEventBingoRewards.FindAsync(id);
            if (storyEventBingoReward == null)
            {
                return NotFound();
            }

            _context.StoryEventBingoRewards.Remove(storyEventBingoReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventBingoRewardExists(int id)
        {
            return _context.StoryEventBingoRewards.Any(e => e.Id == id);
        }
    }
}
