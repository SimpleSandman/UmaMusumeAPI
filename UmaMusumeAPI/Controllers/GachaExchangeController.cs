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
    public class GachaExchangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaExchangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaExchange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaExchange>>> GetGachaExchanges()
        {
            return await _context.GachaExchanges.ToListAsync();
        }

        // GET: api/GachaExchange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaExchange>> GetGachaExchange(int id)
        {
            var gachaExchange = await _context.GachaExchanges.FindAsync(id);

            if (gachaExchange == null)
            {
                return NotFound();
            }

            return gachaExchange;
        }

        // PUT: api/GachaExchange/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaExchange(int id, GachaExchange gachaExchange)
        {
            if (id != gachaExchange.GachaId)
            {
                return BadRequest();
            }

            _context.Entry(gachaExchange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaExchangeExists(id))
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

        // POST: api/GachaExchange
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaExchange>> PostGachaExchange(GachaExchange gachaExchange)
        {
            _context.GachaExchanges.Add(gachaExchange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaExchangeExists(gachaExchange.GachaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaExchange", new { id = gachaExchange.GachaId }, gachaExchange);
        }

        // DELETE: api/GachaExchange/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaExchange(int id)
        {
            var gachaExchange = await _context.GachaExchanges.FindAsync(id);
            if (gachaExchange == null)
            {
                return NotFound();
            }

            _context.GachaExchanges.Remove(gachaExchange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaExchangeExists(int id)
        {
            return _context.GachaExchanges.Any(e => e.GachaId == id);
        }
    }
}
