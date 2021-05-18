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
    public class BackgroundDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BackgroundDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BackgroundData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BackgroundData>>> GetBackgroundData()
        {
            return await _context.BackgroundData.ToListAsync();
        }

        // GET: api/BackgroundData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BackgroundData>> GetBackgroundData(int id)
        {
            var backgroundData = await _context.BackgroundData.FindAsync(id);

            if (backgroundData == null)
            {
                return NotFound();
            }

            return backgroundData;
        }

        // PUT: api/BackgroundData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBackgroundData(int id, BackgroundData backgroundData)
        {
            if (id != backgroundData.Id)
            {
                return BadRequest();
            }

            _context.Entry(backgroundData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BackgroundDataExists(id))
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

        // POST: api/BackgroundData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BackgroundData>> PostBackgroundData(BackgroundData backgroundData)
        {
            _context.BackgroundData.Add(backgroundData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BackgroundDataExists(backgroundData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBackgroundData", new { id = backgroundData.Id }, backgroundData);
        }

        // DELETE: api/BackgroundData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBackgroundData(int id)
        {
            var backgroundData = await _context.BackgroundData.FindAsync(id);
            if (backgroundData == null)
            {
                return NotFound();
            }

            _context.BackgroundData.Remove(backgroundData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BackgroundDataExists(int id)
        {
            return _context.BackgroundData.Any(e => e.Id == id);
        }
    }
}
