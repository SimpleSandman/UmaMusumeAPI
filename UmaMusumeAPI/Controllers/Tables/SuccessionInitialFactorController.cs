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
    public class SuccessionInitialFactorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionInitialFactorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionInitialFactor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionInitialFactor>>> GetSuccessionInitialFactors()
        {
            return await _context.SuccessionInitialFactors.ToListAsync();
        }

        // GET: api/SuccessionInitialFactor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionInitialFactor>> GetSuccessionInitialFactor(int id)
        {
            var successionInitialFactor = await _context.SuccessionInitialFactors.FindAsync(id);

            if (successionInitialFactor == null)
            {
                return NotFound();
            }

            return successionInitialFactor;
        }

        // PUT: api/SuccessionInitialFactor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionInitialFactor(int id, SuccessionInitialFactor successionInitialFactor)
        {
            if (id != successionInitialFactor.Id)
            {
                return BadRequest();
            }

            _context.Entry(successionInitialFactor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionInitialFactorExists(id))
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

        // POST: api/SuccessionInitialFactor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionInitialFactor>> PostSuccessionInitialFactor(SuccessionInitialFactor successionInitialFactor)
        {
            _context.SuccessionInitialFactors.Add(successionInitialFactor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionInitialFactorExists(successionInitialFactor.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionInitialFactor", new { id = successionInitialFactor.Id }, successionInitialFactor);
        }

        // DELETE: api/SuccessionInitialFactor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionInitialFactor(int id)
        {
            var successionInitialFactor = await _context.SuccessionInitialFactors.FindAsync(id);
            if (successionInitialFactor == null)
            {
                return NotFound();
            }

            _context.SuccessionInitialFactors.Remove(successionInitialFactor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionInitialFactorExists(int id)
        {
            return _context.SuccessionInitialFactors.Any(e => e.Id == id);
        }
    }
}
