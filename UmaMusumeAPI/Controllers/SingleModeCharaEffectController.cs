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
    public class SingleModeCharaEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaEffect>>> GetSingleModeCharaEffects()
        {
            return await _context.SingleModeCharaEffects.ToListAsync();
        }

        // GET: api/SingleModeCharaEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaEffect>> GetSingleModeCharaEffect(int id)
        {
            var singleModeCharaEffect = await _context.SingleModeCharaEffects.FindAsync(id);

            if (singleModeCharaEffect == null)
            {
                return NotFound();
            }

            return singleModeCharaEffect;
        }

        // PUT: api/SingleModeCharaEffect/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeCharaEffect(int id, SingleModeCharaEffect singleModeCharaEffect)
        {
            if (id != singleModeCharaEffect.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeCharaEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeCharaEffectExists(id))
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

        // POST: api/SingleModeCharaEffect
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeCharaEffect>> PostSingleModeCharaEffect(SingleModeCharaEffect singleModeCharaEffect)
        {
            _context.SingleModeCharaEffects.Add(singleModeCharaEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeCharaEffectExists(singleModeCharaEffect.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeCharaEffect", new { id = singleModeCharaEffect.Id }, singleModeCharaEffect);
        }

        // DELETE: api/SingleModeCharaEffect/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeCharaEffect(int id)
        {
            var singleModeCharaEffect = await _context.SingleModeCharaEffects.FindAsync(id);
            if (singleModeCharaEffect == null)
            {
                return NotFound();
            }

            _context.SingleModeCharaEffects.Remove(singleModeCharaEffect);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeCharaEffectExists(int id)
        {
            return _context.SingleModeCharaEffects.Any(e => e.Id == id);
        }
    }
}
