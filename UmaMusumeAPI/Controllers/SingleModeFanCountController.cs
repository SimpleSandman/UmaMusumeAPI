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
    public class SingleModeFanCountController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeFanCountController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeFanCount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeFanCount>>> GetSingleModeFanCounts()
        {
            return await _context.SingleModeFanCounts.ToListAsync();
        }

        // GET: api/SingleModeFanCount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeFanCount>> GetSingleModeFanCount(int id)
        {
            var singleModeFanCount = await _context.SingleModeFanCounts.FindAsync(id);

            if (singleModeFanCount == null)
            {
                return NotFound();
            }

            return singleModeFanCount;
        }

        // PUT: api/SingleModeFanCount/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeFanCount(int id, SingleModeFanCount singleModeFanCount)
        {
            if (id != singleModeFanCount.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeFanCount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeFanCountExists(id))
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

        // POST: api/SingleModeFanCount
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeFanCount>> PostSingleModeFanCount(SingleModeFanCount singleModeFanCount)
        {
            _context.SingleModeFanCounts.Add(singleModeFanCount);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeFanCountExists(singleModeFanCount.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeFanCount", new { id = singleModeFanCount.Id }, singleModeFanCount);
        }

        // DELETE: api/SingleModeFanCount/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeFanCount(int id)
        {
            var singleModeFanCount = await _context.SingleModeFanCounts.FindAsync(id);
            if (singleModeFanCount == null)
            {
                return NotFound();
            }

            _context.SingleModeFanCounts.Remove(singleModeFanCount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeFanCountExists(int id)
        {
            return _context.SingleModeFanCounts.Any(e => e.Id == id);
        }
    }
}
