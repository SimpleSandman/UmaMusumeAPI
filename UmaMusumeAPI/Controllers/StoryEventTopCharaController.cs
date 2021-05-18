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
    public class StoryEventTopCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public StoryEventTopCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/StoryEventTopChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoryEventTopChara>>> GetStoryEventTopCharas()
        {
            return await _context.StoryEventTopCharas.ToListAsync();
        }

        // GET: api/StoryEventTopChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryEventTopChara>> GetStoryEventTopChara(int id)
        {
            var storyEventTopChara = await _context.StoryEventTopCharas.FindAsync(id);

            if (storyEventTopChara == null)
            {
                return NotFound();
            }

            return storyEventTopChara;
        }

        // PUT: api/StoryEventTopChara/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryEventTopChara(int id, StoryEventTopChara storyEventTopChara)
        {
            if (id != storyEventTopChara.Id)
            {
                return BadRequest();
            }

            _context.Entry(storyEventTopChara).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryEventTopCharaExists(id))
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

        // POST: api/StoryEventTopChara
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoryEventTopChara>> PostStoryEventTopChara(StoryEventTopChara storyEventTopChara)
        {
            _context.StoryEventTopCharas.Add(storyEventTopChara);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StoryEventTopCharaExists(storyEventTopChara.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStoryEventTopChara", new { id = storyEventTopChara.Id }, storyEventTopChara);
        }

        // DELETE: api/StoryEventTopChara/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryEventTopChara(int id)
        {
            var storyEventTopChara = await _context.StoryEventTopCharas.FindAsync(id);
            if (storyEventTopChara == null)
            {
                return NotFound();
            }

            _context.StoryEventTopCharas.Remove(storyEventTopChara);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoryEventTopCharaExists(int id)
        {
            return _context.StoryEventTopCharas.Any(e => e.Id == id);
        }
    }
}
