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
    public class LimitedExchangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchange>>> GetLimitedExchanges()
        {
            return await _context.LimitedExchanges.ToListAsync();
        }

        // GET: api/LimitedExchange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchange>> GetLimitedExchange(int id)
        {
            var limitedExchange = await _context.LimitedExchanges.FindAsync(id);

            if (limitedExchange == null)
            {
                return NotFound();
            }

            return limitedExchange;
        }

        // PUT: api/LimitedExchange/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLimitedExchange(int id, LimitedExchange limitedExchange)
        {
            if (id != limitedExchange.Id)
            {
                return BadRequest();
            }

            _context.Entry(limitedExchange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LimitedExchangeExists(id))
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

        // POST: api/LimitedExchange
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LimitedExchange>> PostLimitedExchange(LimitedExchange limitedExchange)
        {
            _context.LimitedExchanges.Add(limitedExchange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LimitedExchangeExists(limitedExchange.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLimitedExchange", new { id = limitedExchange.Id }, limitedExchange);
        }

        // DELETE: api/LimitedExchange/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLimitedExchange(int id)
        {
            var limitedExchange = await _context.LimitedExchanges.FindAsync(id);
            if (limitedExchange == null)
            {
                return NotFound();
            }

            _context.LimitedExchanges.Remove(limitedExchange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LimitedExchangeExists(int id)
        {
            return _context.LimitedExchanges.Any(e => e.Id == id);
        }
    }
}
