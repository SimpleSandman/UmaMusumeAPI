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
    public class SingleModeOutingSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeOutingSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeOutingSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeOutingSet>>> GetSingleModeOutingSets()
        {
            return await _context.SingleModeOutingSets.ToListAsync();
        }

        // GET: api/SingleModeOutingSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeOutingSet>> GetSingleModeOutingSet(int id)
        {
            var singleModeOutingSet = await _context.SingleModeOutingSets.FindAsync(id);

            if (singleModeOutingSet == null)
            {
                return NotFound();
            }

            return singleModeOutingSet;
        }

        // PUT: api/SingleModeOutingSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeOutingSet(int id, SingleModeOutingSet singleModeOutingSet)
        {
            if (id != singleModeOutingSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeOutingSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeOutingSetExists(id))
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

        // POST: api/SingleModeOutingSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeOutingSet>> PostSingleModeOutingSet(SingleModeOutingSet singleModeOutingSet)
        {
            _context.SingleModeOutingSets.Add(singleModeOutingSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeOutingSetExists(singleModeOutingSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeOutingSet", new { id = singleModeOutingSet.Id }, singleModeOutingSet);
        }

        // DELETE: api/SingleModeOutingSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeOutingSet(int id)
        {
            var singleModeOutingSet = await _context.SingleModeOutingSets.FindAsync(id);
            if (singleModeOutingSet == null)
            {
                return NotFound();
            }

            _context.SingleModeOutingSets.Remove(singleModeOutingSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeOutingSetExists(int id)
        {
            return _context.SingleModeOutingSets.Any(e => e.Id == id);
        }
    }
}
