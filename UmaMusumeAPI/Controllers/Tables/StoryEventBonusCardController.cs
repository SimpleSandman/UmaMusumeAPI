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
    public class StoryEventBonusCardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventBonusCardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventBonusCard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventBonusCard>>> GetStoryEventBonusCards()
        {
            return await _context.StoryEventBonusCards.ToListAsync();
        }

        // GET: api/StoryEventBonusCard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventBonusCard>> GetStoryEventBonusCard(int id)
        {
            var storyEventBonusCard = await _context.StoryEventBonusCards.FindAsync(id);

            if (storyEventBonusCard == null)
            {
                return NotFound();
            }

            return storyEventBonusCard;
        }

        // PUT: api/StoryEventBonusCard/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventBonusCard(int id, StoryEventBonusCard storyEventBonusCard)
        {
            if (id != storyEventBonusCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventBonusCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventBonusCardExists(id))
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

        // POST: api/StoryEventBonusCard
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventBonusCard>> PostStoryEventBonusCard(StoryEventBonusCard storyEventBonusCard)
        {
            _context.StoryEventBonusCards.Add(storyEventBonusCard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventBonusCardExists(storyEventBonusCard.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventBonusCard", new { id = storyEventBonusCard.Id }, storyEventBonusCard);
        }

        // DELETE: api/StoryEventBonusCard/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventBonusCard(int id)
        {
            var storyEventBonusCard = await _context.StoryEventBonusCards.FindAsync(id);
            if (storyEventBonusCard == null)
            {
                return NotFound();
            }

            _context.StoryEventBonusCards.Remove(storyEventBonusCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventBonusCardExists(int id)
        {
            return _context.StoryEventBonusCards.Any(e => e.Id == id);
        }
    }
}
