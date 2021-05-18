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
    public class StoryEventBonusSupportCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBonusSupportCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBonusSupportCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBonusSupportCard>>> GetStoryEventBonusSupportCards()
        {
            return await _context.StoryEventBonusSupportCards.ToListAsync();
        }

        // GET: api/StoryEventBonusSupportCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBonusSupportCard>> GetStoryEventBonusSupportCard(int id)
        {
            var storyEventBonusSupportCard = await _context.StoryEventBonusSupportCards.FindAsync(id);

            if (storyEventBonusSupportCard == null)
            {
                return NotFound();
            }

            return storyEventBonusSupportCard;
        }

        // PUT: api/StoryEventBonusSupportCard/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventBonusSupportCard(int id, StoryEventBonusSupportCard storyEventBonusSupportCard)
        {
            if (id != storyEventBonusSupportCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventBonusSupportCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventBonusSupportCardExists(id))
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

        // POST: api/StoryEventBonusSupportCard
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventBonusSupportCard>> PostStoryEventBonusSupportCard(StoryEventBonusSupportCard storyEventBonusSupportCard)
        {
            _context.StoryEventBonusSupportCards.Add(storyEventBonusSupportCard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventBonusSupportCardExists(storyEventBonusSupportCard.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventBonusSupportCard", new { id = storyEventBonusSupportCard.Id }, storyEventBonusSupportCard);
        }

        // DELETE: api/StoryEventBonusSupportCard/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventBonusSupportCard(int id)
        {
            var storyEventBonusSupportCard = await _context.StoryEventBonusSupportCards.FindAsync(id);
            if (storyEventBonusSupportCard == null)
            {
                return NotFound();
            }

            _context.StoryEventBonusSupportCards.Remove(storyEventBonusSupportCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventBonusSupportCardExists(int id)
        {
            return _context.StoryEventBonusSupportCards.Any(e => e.Id == id);
        }
    }
}
