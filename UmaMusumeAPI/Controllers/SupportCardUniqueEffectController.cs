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
    public class SupportCardUniqueEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardUniqueEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardUniqueEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardUniqueEffect>>> GetSupportCardUniqueEffects()
        {
            return await _context.SupportCardUniqueEffects.ToListAsync();
        }

        // GET: api/SupportCardUniqueEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardUniqueEffect>> GetSupportCardUniqueEffect(int id)
        {
            var supportCardUniqueEffect = await _context.SupportCardUniqueEffects.FindAsync(id);

            if (supportCardUniqueEffect == null)
            {
                return NotFound();
            }

            return supportCardUniqueEffect;
        }

        // PUT: api/SupportCardUniqueEffect/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardUniqueEffect(int id, SupportCardUniqueEffect supportCardUniqueEffect)
        {
            if (id != supportCardUniqueEffect.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportCardUniqueEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardUniqueEffectExists(id))
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

        // POST: api/SupportCardUniqueEffect
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardUniqueEffect>> PostSupportCardUniqueEffect(SupportCardUniqueEffect supportCardUniqueEffect)
        {
            _context.SupportCardUniqueEffects.Add(supportCardUniqueEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardUniqueEffectExists(supportCardUniqueEffect.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardUniqueEffect", new { id = supportCardUniqueEffect.Id }, supportCardUniqueEffect);
        }

        // DELETE: api/SupportCardUniqueEffect/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardUniqueEffect(int id)
        {
            var supportCardUniqueEffect = await _context.SupportCardUniqueEffects.FindAsync(id);
            if (supportCardUniqueEffect == null)
            {
                return NotFound();
            }

            _context.SupportCardUniqueEffects.Remove(supportCardUniqueEffect);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardUniqueEffectExists(int id)
        {
            return _context.SupportCardUniqueEffects.Any(e => e.Id == id);
        }
    }
}
