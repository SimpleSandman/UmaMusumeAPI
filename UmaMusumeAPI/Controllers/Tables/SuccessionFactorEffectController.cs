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
    public class SuccessionFactorEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionFactorEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionFactorEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionFactorEffect>>> GetSuccessionFactorEffects()
        {
            return await _context.SuccessionFactorEffects.ToListAsync();
        }

        // GET: api/SuccessionFactorEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionFactorEffect>> GetSuccessionFactorEffect(int id)
        {
            var successionFactorEffect = await _context.SuccessionFactorEffects.FindAsync(id);

            if (successionFactorEffect == null)
            {
                return NotFound();
            }

            return successionFactorEffect;
        }

        // PUT: api/SuccessionFactorEffect/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionFactorEffect(int id, SuccessionFactorEffect successionFactorEffect)
        {
            if (id != successionFactorEffect.Id)
            {
                return BadRequest();
            }

            _context.Entry(successionFactorEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionFactorEffectExists(id))
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

        // POST: api/SuccessionFactorEffect
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionFactorEffect>> PostSuccessionFactorEffect(SuccessionFactorEffect successionFactorEffect)
        {
            _context.SuccessionFactorEffects.Add(successionFactorEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionFactorEffectExists(successionFactorEffect.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionFactorEffect", new { id = successionFactorEffect.Id }, successionFactorEffect);
        }

        // DELETE: api/SuccessionFactorEffect/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionFactorEffect(int id)
        {
            var successionFactorEffect = await _context.SuccessionFactorEffects.FindAsync(id);
            if (successionFactorEffect == null)
            {
                return NotFound();
            }

            _context.SuccessionFactorEffects.Remove(successionFactorEffect);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionFactorEffectExists(int id)
        {
            return _context.SuccessionFactorEffects.Any(e => e.Id == id);
        }
    }
}
