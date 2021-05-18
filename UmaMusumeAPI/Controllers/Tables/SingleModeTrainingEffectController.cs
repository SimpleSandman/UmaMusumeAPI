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
    public class SingleModeTrainingEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTrainingEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTrainingEffect>>> GetSingleModeTrainingEffects()
        {
            return await _context.SingleModeTrainingEffects.ToListAsync();
        }

        // GET: api/SingleModeTrainingEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTrainingEffect>> GetSingleModeTrainingEffect(int id)
        {
            var singleModeTrainingEffect = await _context.SingleModeTrainingEffects.FindAsync(id);

            if (singleModeTrainingEffect == null)
            {
                return NotFound();
            }

            return singleModeTrainingEffect;
        }

        // PUT: api/SingleModeTrainingEffect/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTrainingEffect(int id, SingleModeTrainingEffect singleModeTrainingEffect)
        {
            if (id != singleModeTrainingEffect.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTrainingEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTrainingEffectExists(id))
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

        // POST: api/SingleModeTrainingEffect
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTrainingEffect>> PostSingleModeTrainingEffect(SingleModeTrainingEffect singleModeTrainingEffect)
        {
            _context.SingleModeTrainingEffects.Add(singleModeTrainingEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTrainingEffectExists(singleModeTrainingEffect.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTrainingEffect", new { id = singleModeTrainingEffect.Id }, singleModeTrainingEffect);
        }

        // DELETE: api/SingleModeTrainingEffect/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTrainingEffect(int id)
        {
            var singleModeTrainingEffect = await _context.SingleModeTrainingEffects.FindAsync(id);
            if (singleModeTrainingEffect == null)
            {
                return NotFound();
            }

            _context.SingleModeTrainingEffects.Remove(singleModeTrainingEffect);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTrainingEffectExists(int id)
        {
            return _context.SingleModeTrainingEffects.Any(e => e.Id == id);
        }
    }
}
