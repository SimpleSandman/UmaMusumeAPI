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
    public class DailyRaceBillingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceBillingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRaceBilling
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRaceBilling>>> GetDailyRaceBillings()
        {
            return await _context.DailyRaceBillings.ToListAsync();
        }

        // GET: api/DailyRaceBilling/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRaceBilling>> GetDailyRaceBilling(int id)
        {
            var dailyRaceBilling = await _context.DailyRaceBillings.FindAsync(id);

            if (dailyRaceBilling == null)
            {
                return NotFound();
            }

            return dailyRaceBilling;
        }

        // PUT: api/DailyRaceBilling/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailyRaceBilling(int id, DailyRaceBilling dailyRaceBilling)
        {
            if (id != dailyRaceBilling.Id)
            {
                return BadRequest();
            }

            _context.Entry(dailyRaceBilling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyRaceBillingExists(id))
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

        // POST: api/DailyRaceBilling
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DailyRaceBilling>> PostDailyRaceBilling(DailyRaceBilling dailyRaceBilling)
        {
            _context.DailyRaceBillings.Add(dailyRaceBilling);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DailyRaceBillingExists(dailyRaceBilling.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDailyRaceBilling", new { id = dailyRaceBilling.Id }, dailyRaceBilling);
        }

        // DELETE: api/DailyRaceBilling/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDailyRaceBilling(int id)
        {
            var dailyRaceBilling = await _context.DailyRaceBillings.FindAsync(id);
            if (dailyRaceBilling == null)
            {
                return NotFound();
            }

            _context.DailyRaceBillings.Remove(dailyRaceBilling);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DailyRaceBillingExists(int id)
        {
            return _context.DailyRaceBillings.Any(e => e.Id == id);
        }
    }
}
