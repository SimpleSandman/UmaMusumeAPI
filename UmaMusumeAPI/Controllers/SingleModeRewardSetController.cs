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
    public class SingleModeRewardSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRewardSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRewardSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRewardSet>>> GetSingleModeRewardSets()
        {
            return await _context.SingleModeRewardSets.ToListAsync();
        }

        // GET: api/SingleModeRewardSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRewardSet>> GetSingleModeRewardSet(int id)
        {
            var singleModeRewardSet = await _context.SingleModeRewardSets.FindAsync(id);

            if (singleModeRewardSet == null)
            {
                return NotFound();
            }

            return singleModeRewardSet;
        }

        // PUT: api/SingleModeRewardSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRewardSet(int id, SingleModeRewardSet singleModeRewardSet)
        {
            if (id != singleModeRewardSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRewardSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRewardSetExists(id))
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

        // POST: api/SingleModeRewardSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRewardSet>> PostSingleModeRewardSet(SingleModeRewardSet singleModeRewardSet)
        {
            _context.SingleModeRewardSets.Add(singleModeRewardSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRewardSetExists(singleModeRewardSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRewardSet", new { id = singleModeRewardSet.Id }, singleModeRewardSet);
        }

        // DELETE: api/SingleModeRewardSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRewardSet(int id)
        {
            var singleModeRewardSet = await _context.SingleModeRewardSets.FindAsync(id);
            if (singleModeRewardSet == null)
            {
                return NotFound();
            }

            _context.SingleModeRewardSets.Remove(singleModeRewardSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRewardSetExists(int id)
        {
            return _context.SingleModeRewardSets.Any(e => e.Id == id);
        }
    }
}
