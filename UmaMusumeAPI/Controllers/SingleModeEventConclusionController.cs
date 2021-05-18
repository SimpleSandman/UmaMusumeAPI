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
    public class SingleModeEventConclusionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventConclusionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventConclusion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventConclusion>>> GetSingleModeEventConclusions()
        {
            return await _context.SingleModeEventConclusions.ToListAsync();
        }

        // GET: api/SingleModeEventConclusion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEventConclusion>> GetSingleModeEventConclusion(int id)
        {
            var singleModeEventConclusion = await _context.SingleModeEventConclusions.FindAsync(id);

            if (singleModeEventConclusion == null)
            {
                return NotFound();
            }

            return singleModeEventConclusion;
        }

        // PUT: api/SingleModeEventConclusion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeEventConclusion(int id, SingleModeEventConclusion singleModeEventConclusion)
        {
            if (id != singleModeEventConclusion.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeEventConclusion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeEventConclusionExists(id))
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

        // POST: api/SingleModeEventConclusion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeEventConclusion>> PostSingleModeEventConclusion(SingleModeEventConclusion singleModeEventConclusion)
        {
            _context.SingleModeEventConclusions.Add(singleModeEventConclusion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeEventConclusionExists(singleModeEventConclusion.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeEventConclusion", new { id = singleModeEventConclusion.Id }, singleModeEventConclusion);
        }

        // DELETE: api/SingleModeEventConclusion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeEventConclusion(int id)
        {
            var singleModeEventConclusion = await _context.SingleModeEventConclusions.FindAsync(id);
            if (singleModeEventConclusion == null)
            {
                return NotFound();
            }

            _context.SingleModeEventConclusions.Remove(singleModeEventConclusion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeEventConclusionExists(int id)
        {
            return _context.SingleModeEventConclusions.Any(e => e.Id == id);
        }
    }
}
