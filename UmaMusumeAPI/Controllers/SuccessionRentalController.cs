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
    public class SuccessionRentalController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRentalController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRental
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRental>>> GetSuccessionRentals()
        {
            return await _context.SuccessionRentals.ToListAsync();
        }

        // GET: api/SuccessionRental/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRental>> GetSuccessionRental(int id)
        {
            var successionRental = await _context.SuccessionRentals.FindAsync(id);

            if (successionRental == null)
            {
                return NotFound();
            }

            return successionRental;
        }

        // PUT: api/SuccessionRental/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionRental(int id, SuccessionRental successionRental)
        {
            if (id != successionRental.Id)
            {
                return BadRequest();
            }

            _context.Entry(successionRental).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionRentalExists(id))
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

        // POST: api/SuccessionRental
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionRental>> PostSuccessionRental(SuccessionRental successionRental)
        {
            _context.SuccessionRentals.Add(successionRental);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionRentalExists(successionRental.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionRental", new { id = successionRental.Id }, successionRental);
        }

        // DELETE: api/SuccessionRental/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionRental(int id)
        {
            var successionRental = await _context.SuccessionRentals.FindAsync(id);
            if (successionRental == null)
            {
                return NotFound();
            }

            _context.SuccessionRentals.Remove(successionRental);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionRentalExists(int id)
        {
            return _context.SuccessionRentals.Any(e => e.Id == id);
        }
    }
}
