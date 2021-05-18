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
    public class MiniBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniBg>>> GetMiniBgs()
        {
            return await _context.MiniBgs.ToListAsync();
        }

        // GET: api/MiniBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniBg>> GetMiniBg(int id)
        {
            var miniBg = await _context.MiniBgs.FindAsync(id);

            if (miniBg == null)
            {
                return NotFound();
            }

            return miniBg;
        }

        // PUT: api/MiniBg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiniBg(int id, MiniBg miniBg)
        {
            if (id != miniBg.Id)
            {
                return BadRequest();
            }

            _context.Entry(miniBg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniBgExists(id))
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

        // POST: api/MiniBg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MiniBg>> PostMiniBg(MiniBg miniBg)
        {
            _context.MiniBgs.Add(miniBg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MiniBgExists(miniBg.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMiniBg", new { id = miniBg.Id }, miniBg);
        }

        // DELETE: api/MiniBg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiniBg(int id)
        {
            var miniBg = await _context.MiniBgs.FindAsync(id);
            if (miniBg == null)
            {
                return NotFound();
            }

            _context.MiniBgs.Remove(miniBg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MiniBgExists(int id)
        {
            return _context.MiniBgs.Any(e => e.Id == id);
        }
    }
}
