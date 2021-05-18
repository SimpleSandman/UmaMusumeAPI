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
    public class SingleModeTurnController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTurnController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTurn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTurn>>> GetSingleModeTurns()
        {
            return await _context.SingleModeTurns.ToListAsync();
        }

        // GET: api/SingleModeTurn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTurn>> GetSingleModeTurn(int id)
        {
            var singleModeTurn = await _context.SingleModeTurns.FindAsync(id);

            if (singleModeTurn == null)
            {
                return NotFound();
            }

            return singleModeTurn;
        }

        // PUT: api/SingleModeTurn/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTurn(int id, SingleModeTurn singleModeTurn)
        {
            if (id != singleModeTurn.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTurn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTurnExists(id))
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

        // POST: api/SingleModeTurn
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTurn>> PostSingleModeTurn(SingleModeTurn singleModeTurn)
        {
            _context.SingleModeTurns.Add(singleModeTurn);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTurnExists(singleModeTurn.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTurn", new { id = singleModeTurn.Id }, singleModeTurn);
        }

        // DELETE: api/SingleModeTurn/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTurn(int id)
        {
            var singleModeTurn = await _context.SingleModeTurns.FindAsync(id);
            if (singleModeTurn == null)
            {
                return NotFound();
            }

            _context.SingleModeTurns.Remove(singleModeTurn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTurnExists(int id)
        {
            return _context.SingleModeTurns.Any(e => e.Id == id);
        }
    }
}
