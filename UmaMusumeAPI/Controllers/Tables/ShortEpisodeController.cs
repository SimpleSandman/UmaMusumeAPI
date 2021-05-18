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
    public class ShortEpisodeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ShortEpisodeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ShortEpisode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShortEpisode>>> GetShortEpisodes()
        {
            return await _context.ShortEpisodes.ToListAsync();
        }

        // GET: api/ShortEpisode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShortEpisode>> GetShortEpisode(int id)
        {
            var shortEpisode = await _context.ShortEpisodes.FindAsync(id);

            if (shortEpisode == null)
            {
                return NotFound();
            }

            return shortEpisode;
        }

        // PUT: api/ShortEpisode/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShortEpisode(int id, ShortEpisode shortEpisode)
        {
            if (id != shortEpisode.Id)
            {
                return BadRequest();
            }

            _context.Entry(shortEpisode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShortEpisodeExists(id))
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

        // POST: api/ShortEpisode
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShortEpisode>> PostShortEpisode(ShortEpisode shortEpisode)
        {
            _context.ShortEpisodes.Add(shortEpisode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShortEpisodeExists(shortEpisode.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShortEpisode", new { id = shortEpisode.Id }, shortEpisode);
        }

        // DELETE: api/ShortEpisode/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShortEpisode(int id)
        {
            var shortEpisode = await _context.ShortEpisodes.FindAsync(id);
            if (shortEpisode == null)
            {
                return NotFound();
            }

            _context.ShortEpisodes.Remove(shortEpisode);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShortEpisodeExists(int id)
        {
            return _context.ShortEpisodes.Any(e => e.Id == id);
        }
    }
}
