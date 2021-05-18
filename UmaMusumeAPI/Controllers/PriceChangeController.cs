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
    public class PriceChangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public PriceChangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/PriceChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PriceChange>>> GetPriceChanges()
        {
            return await _context.PriceChanges.ToListAsync();
        }

        // GET: api/PriceChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PriceChange>> GetPriceChange(int id)
        {
            var priceChange = await _context.PriceChanges.FindAsync(id);

            if (priceChange == null)
            {
                return NotFound();
            }

            return priceChange;
        }

        // PUT: api/PriceChange/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPriceChange(int id, PriceChange priceChange)
        {
            if (id != priceChange.Id)
            {
                return BadRequest();
            }

            _context.Entry(priceChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceChangeExists(id))
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

        // POST: api/PriceChange
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PriceChange>> PostPriceChange(PriceChange priceChange)
        {
            _context.PriceChanges.Add(priceChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PriceChangeExists(priceChange.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPriceChange", new { id = priceChange.Id }, priceChange);
        }

        // DELETE: api/PriceChange/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePriceChange(int id)
        {
            var priceChange = await _context.PriceChanges.FindAsync(id);
            if (priceChange == null)
            {
                return NotFound();
            }

            _context.PriceChanges.Remove(priceChange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PriceChangeExists(int id)
        {
            return _context.PriceChanges.Any(e => e.Id == id);
        }
    }
}
