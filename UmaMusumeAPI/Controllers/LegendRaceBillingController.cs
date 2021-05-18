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
    public class LegendRaceBillingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceBillingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceBilling
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceBilling>>> GetLegendRaceBillings()
        {
            return await _context.LegendRaceBillings.ToListAsync();
        }

        // GET: api/LegendRaceBilling/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceBilling>> GetLegendRaceBilling(int id)
        {
            var legendRaceBilling = await _context.LegendRaceBillings.FindAsync(id);

            if (legendRaceBilling == null)
            {
                return NotFound();
            }

            return legendRaceBilling;
        }

        // PUT: api/LegendRaceBilling/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegendRaceBilling(int id, LegendRaceBilling legendRaceBilling)
        {
            if (id != legendRaceBilling.Id)
            {
                return BadRequest();
            }

            _context.Entry(legendRaceBilling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegendRaceBillingExists(id))
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

        // POST: api/LegendRaceBilling
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LegendRaceBilling>> PostLegendRaceBilling(LegendRaceBilling legendRaceBilling)
        {
            _context.LegendRaceBillings.Add(legendRaceBilling);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LegendRaceBillingExists(legendRaceBilling.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLegendRaceBilling", new { id = legendRaceBilling.Id }, legendRaceBilling);
        }

        // DELETE: api/LegendRaceBilling/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegendRaceBilling(int id)
        {
            var legendRaceBilling = await _context.LegendRaceBillings.FindAsync(id);
            if (legendRaceBilling == null)
            {
                return NotFound();
            }

            _context.LegendRaceBillings.Remove(legendRaceBilling);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegendRaceBillingExists(int id)
        {
            return _context.LegendRaceBillings.Any(e => e.Id == id);
        }
    }
}
