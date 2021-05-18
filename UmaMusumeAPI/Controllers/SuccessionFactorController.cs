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
    public class SuccessionFactorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionFactorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionFactor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionFactor>>> GetSuccessionFactors()
        {
            return await _context.SuccessionFactors.ToListAsync();
        }

        // GET: api/SuccessionFactor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionFactor>> GetSuccessionFactor(int id)
        {
            var successionFactor = await _context.SuccessionFactors.FindAsync(id);

            if (successionFactor == null)
            {
                return NotFound();
            }

            return successionFactor;
        }

        // PUT: api/SuccessionFactor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionFactor(int id, SuccessionFactor successionFactor)
        {
            if (id != successionFactor.FactorId)
            {
                return BadRequest();
            }

            _context.Entry(successionFactor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionFactorExists(id))
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

        // POST: api/SuccessionFactor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionFactor>> PostSuccessionFactor(SuccessionFactor successionFactor)
        {
            _context.SuccessionFactors.Add(successionFactor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionFactorExists(successionFactor.FactorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionFactor", new { id = successionFactor.FactorId }, successionFactor);
        }

        // DELETE: api/SuccessionFactor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionFactor(int id)
        {
            var successionFactor = await _context.SuccessionFactors.FindAsync(id);
            if (successionFactor == null)
            {
                return NotFound();
            }

            _context.SuccessionFactors.Remove(successionFactor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionFactorExists(int id)
        {
            return _context.SuccessionFactors.Any(e => e.FactorId == id);
        }
    }
}
