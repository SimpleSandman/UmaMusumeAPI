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
    public class SingleModeEvaluationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEvaluationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEvaluation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEvaluation>>> GetSingleModeEvaluations()
        {
            return await _context.SingleModeEvaluations.ToListAsync();
        }

        // GET: api/SingleModeEvaluation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEvaluation>> GetSingleModeEvaluation(int id)
        {
            var singleModeEvaluation = await _context.SingleModeEvaluations.FindAsync(id);

            if (singleModeEvaluation == null)
            {
                return NotFound();
            }

            return singleModeEvaluation;
        }

        // PUT: api/SingleModeEvaluation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeEvaluation(int id, SingleModeEvaluation singleModeEvaluation)
        {
            if (id != singleModeEvaluation.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeEvaluation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeEvaluationExists(id))
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

        // POST: api/SingleModeEvaluation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeEvaluation>> PostSingleModeEvaluation(SingleModeEvaluation singleModeEvaluation)
        {
            _context.SingleModeEvaluations.Add(singleModeEvaluation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeEvaluationExists(singleModeEvaluation.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeEvaluation", new { id = singleModeEvaluation.Id }, singleModeEvaluation);
        }

        // DELETE: api/SingleModeEvaluation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeEvaluation(int id)
        {
            var singleModeEvaluation = await _context.SingleModeEvaluations.FindAsync(id);
            if (singleModeEvaluation == null)
            {
                return NotFound();
            }

            _context.SingleModeEvaluations.Remove(singleModeEvaluation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeEvaluationExists(int id)
        {
            return _context.SingleModeEvaluations.Any(e => e.Id == id);
        }
    }
}
