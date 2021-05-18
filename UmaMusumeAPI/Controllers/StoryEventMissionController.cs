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
    public class StoryEventMissionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventMissionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventMission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventMission>>> GetStoryEventMissions()
        {
            return await _context.StoryEventMissions.ToListAsync();
        }

        // GET: api/StoryEventMission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventMission>> GetStoryEventMission(int id)
        {
            var storyEventMission = await _context.StoryEventMissions.FindAsync(id);

            if (storyEventMission == null)
            {
                return NotFound();
            }

            return storyEventMission;
        }

        // PUT: api/StoryEventMission/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventMission(int id, StoryEventMission storyEventMission)
        {
            if (id != storyEventMission.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventMission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventMissionExists(id))
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

        // POST: api/StoryEventMission
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventMission>> PostStoryEventMission(StoryEventMission storyEventMission)
        {
            _context.StoryEventMissions.Add(storyEventMission);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventMissionExists(storyEventMission.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventMission", new { id = storyEventMission.Id }, storyEventMission);
        }

        // DELETE: api/StoryEventMission/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventMission(int id)
        {
            var storyEventMission = await _context.StoryEventMissions.FindAsync(id);
            if (storyEventMission == null)
            {
                return NotFound();
            }

            _context.StoryEventMissions.Remove(storyEventMission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventMissionExists(int id)
        {
            return _context.StoryEventMissions.Any(e => e.Id == id);
        }
    }
}
