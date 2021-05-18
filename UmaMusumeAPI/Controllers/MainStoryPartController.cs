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
    public class MainStoryPartController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryPartController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryPart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryPart>>> GetMainStoryParts()
        {
            return await _context.MainStoryParts.ToListAsync();
        }

        // GET: api/MainStoryPart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryPart>> GetMainStoryPart(int id)
        {
            var mainStoryPart = await _context.MainStoryParts.FindAsync(id);

            if (mainStoryPart == null)
            {
                return NotFound();
            }

            return mainStoryPart;
        }

        // PUT: api/MainStoryPart/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainStoryPart(int id, MainStoryPart mainStoryPart)
        {
            if (id != mainStoryPart.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainStoryPart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainStoryPartExists(id))
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

        // POST: api/MainStoryPart
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MainStoryPart>> PostMainStoryPart(MainStoryPart mainStoryPart)
        {
            _context.MainStoryParts.Add(mainStoryPart);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MainStoryPartExists(mainStoryPart.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMainStoryPart", new { id = mainStoryPart.Id }, mainStoryPart);
        }

        // DELETE: api/MainStoryPart/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainStoryPart(int id)
        {
            var mainStoryPart = await _context.MainStoryParts.FindAsync(id);
            if (mainStoryPart == null)
            {
                return NotFound();
            }

            _context.MainStoryParts.Remove(mainStoryPart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainStoryPartExists(int id)
        {
            return _context.MainStoryParts.Any(e => e.Id == id);
        }
    }
}
