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
    public class GachaPrizeOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaPrizeOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaPrizeOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaPrizeOdd>>> GetGachaPrizeOdds()
        {
            return await _context.GachaPrizeOdds.ToListAsync();
        }

        // GET: api/GachaPrizeOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaPrizeOdd>> GetGachaPrizeOdd(int id)
        {
            var gachaPrizeOdd = await _context.GachaPrizeOdds.FindAsync(id);

            if (gachaPrizeOdd == null)
            {
                return NotFound();
            }

            return gachaPrizeOdd;
        }

        // PUT: api/GachaPrizeOdd/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaPrizeOdd(int id, GachaPrizeOdd gachaPrizeOdd)
        {
            if (id != gachaPrizeOdd.PrizeOddsId)
            {
                return BadRequest();
            }

            _context.Entry(gachaPrizeOdd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaPrizeOddExists(id))
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

        // POST: api/GachaPrizeOdd
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaPrizeOdd>> PostGachaPrizeOdd(GachaPrizeOdd gachaPrizeOdd)
        {
            _context.GachaPrizeOdds.Add(gachaPrizeOdd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaPrizeOddExists(gachaPrizeOdd.PrizeOddsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaPrizeOdd", new { id = gachaPrizeOdd.PrizeOddsId }, gachaPrizeOdd);
        }

        // DELETE: api/GachaPrizeOdd/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaPrizeOdd(int id)
        {
            var gachaPrizeOdd = await _context.GachaPrizeOdds.FindAsync(id);
            if (gachaPrizeOdd == null)
            {
                return NotFound();
            }

            _context.GachaPrizeOdds.Remove(gachaPrizeOdd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaPrizeOddExists(int id)
        {
            return _context.GachaPrizeOdds.Any(e => e.PrizeOddsId == id);
        }
    }
}
