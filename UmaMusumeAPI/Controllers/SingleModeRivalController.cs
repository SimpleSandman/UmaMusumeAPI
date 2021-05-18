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
    public class SingleModeRivalController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRivalController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRival
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRival>>> GetSingleModeRivals()
        {
            return await _context.SingleModeRivals.ToListAsync();
        }

        // GET: api/SingleModeRival/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRival>> GetSingleModeRival(int id)
        {
            var singleModeRival = await _context.SingleModeRivals.FindAsync(id);

            if (singleModeRival == null)
            {
                return NotFound();
            }

            return singleModeRival;
        }

        // PUT: api/SingleModeRival/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRival(int id, SingleModeRival singleModeRival)
        {
            if (id != singleModeRival.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRival).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRivalExists(id))
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

        // POST: api/SingleModeRival
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRival>> PostSingleModeRival(SingleModeRival singleModeRival)
        {
            _context.SingleModeRivals.Add(singleModeRival);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRivalExists(singleModeRival.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRival", new { id = singleModeRival.Id }, singleModeRival);
        }

        // DELETE: api/SingleModeRival/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRival(int id)
        {
            var singleModeRival = await _context.SingleModeRivals.FindAsync(id);
            if (singleModeRival == null)
            {
                return NotFound();
            }

            _context.SingleModeRivals.Remove(singleModeRival);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRivalExists(int id)
        {
            return _context.SingleModeRivals.Any(e => e.Id == id);
        }
    }
}
