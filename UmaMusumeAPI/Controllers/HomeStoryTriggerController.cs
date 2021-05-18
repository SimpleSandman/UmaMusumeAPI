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
    public class HomeStoryTriggerController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeStoryTriggerController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeStoryTrigger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeStoryTrigger>>> GetHomeStoryTriggers()
        {
            return await _context.HomeStoryTriggers.ToListAsync();
        }

        // GET: api/HomeStoryTrigger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeStoryTrigger>> GetHomeStoryTrigger(int id)
        {
            var homeStoryTrigger = await _context.HomeStoryTriggers.FindAsync(id);

            if (homeStoryTrigger == null)
            {
                return NotFound();
            }

            return homeStoryTrigger;
        }

        // PUT: api/HomeStoryTrigger/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomeStoryTrigger(int id, HomeStoryTrigger homeStoryTrigger)
        {
            if (id != homeStoryTrigger.Id)
            {
                return BadRequest();
            }

            _context.Entry(homeStoryTrigger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeStoryTriggerExists(id))
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

        // POST: api/HomeStoryTrigger
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HomeStoryTrigger>> PostHomeStoryTrigger(HomeStoryTrigger homeStoryTrigger)
        {
            _context.HomeStoryTriggers.Add(homeStoryTrigger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HomeStoryTriggerExists(homeStoryTrigger.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHomeStoryTrigger", new { id = homeStoryTrigger.Id }, homeStoryTrigger);
        }

        // DELETE: api/HomeStoryTrigger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeStoryTrigger(int id)
        {
            var homeStoryTrigger = await _context.HomeStoryTriggers.FindAsync(id);
            if (homeStoryTrigger == null)
            {
                return NotFound();
            }

            _context.HomeStoryTriggers.Remove(homeStoryTrigger);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HomeStoryTriggerExists(int id)
        {
            return _context.HomeStoryTriggers.Any(e => e.Id == id);
        }
    }
}
