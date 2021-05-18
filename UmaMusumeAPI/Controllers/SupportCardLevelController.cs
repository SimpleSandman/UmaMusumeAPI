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
    public class SupportCardLevelController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardLevelController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardLevel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardLevel>>> GetSupportCardLevels()
        {
            return await _context.SupportCardLevels.ToListAsync();
        }

        // GET: api/SupportCardLevel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardLevel>> GetSupportCardLevel(int id)
        {
            var supportCardLevel = await _context.SupportCardLevels.FindAsync(id);

            if (supportCardLevel == null)
            {
                return NotFound();
            }

            return supportCardLevel;
        }

        // PUT: api/SupportCardLevel/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardLevel(int id, SupportCardLevel supportCardLevel)
        {
            if (id != supportCardLevel.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportCardLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardLevelExists(id))
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

        // POST: api/SupportCardLevel
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardLevel>> PostSupportCardLevel(SupportCardLevel supportCardLevel)
        {
            _context.SupportCardLevels.Add(supportCardLevel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardLevelExists(supportCardLevel.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardLevel", new { id = supportCardLevel.Id }, supportCardLevel);
        }

        // DELETE: api/SupportCardLevel/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardLevel(int id)
        {
            var supportCardLevel = await _context.SupportCardLevels.FindAsync(id);
            if (supportCardLevel == null)
            {
                return NotFound();
            }

            _context.SupportCardLevels.Remove(supportCardLevel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardLevelExists(int id)
        {
            return _context.SupportCardLevels.Any(e => e.Id == id);
        }
    }
}
