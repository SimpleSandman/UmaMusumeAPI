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
    public class StoryEventMissionTopCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventMissionTopCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventMissionTopChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventMissionTopChara>>> GetStoryEventMissionTopCharas()
        {
            return await _context.StoryEventMissionTopCharas.ToListAsync();
        }

        // GET: api/StoryEventMissionTopChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventMissionTopChara>> GetStoryEventMissionTopChara(int id)
        {
            var storyEventMissionTopChara = await _context.StoryEventMissionTopCharas.FindAsync(id);

            if (storyEventMissionTopChara == null)
            {
                return NotFound();
            }

            return storyEventMissionTopChara;
        }

        // PUT: api/StoryEventMissionTopChara/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventMissionTopChara(int id, StoryEventMissionTopChara storyEventMissionTopChara)
        {
            if (id != storyEventMissionTopChara.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventMissionTopChara).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventMissionTopCharaExists(id))
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

        // POST: api/StoryEventMissionTopChara
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventMissionTopChara>> PostStoryEventMissionTopChara(StoryEventMissionTopChara storyEventMissionTopChara)
        {
            _context.StoryEventMissionTopCharas.Add(storyEventMissionTopChara);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventMissionTopCharaExists(storyEventMissionTopChara.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventMissionTopChara", new { id = storyEventMissionTopChara.Id }, storyEventMissionTopChara);
        }

        // DELETE: api/StoryEventMissionTopChara/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventMissionTopChara(int id)
        {
            var storyEventMissionTopChara = await _context.StoryEventMissionTopCharas.FindAsync(id);
            if (storyEventMissionTopChara == null)
            {
                return NotFound();
            }

            _context.StoryEventMissionTopCharas.Remove(storyEventMissionTopChara);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventMissionTopCharaExists(int id)
        {
            return _context.StoryEventMissionTopCharas.Any(e => e.Id == id);
        }
    }
}
