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
    public class LimitedExchangeRewardOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeRewardOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchangeRewardOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchangeRewardOdd>>> GetLimitedExchangeRewardOdds()
        {
            return await _context.LimitedExchangeRewardOdds.ToListAsync();
        }

        // GET: api/LimitedExchangeRewardOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchangeRewardOdd>> GetLimitedExchangeRewardOdd(int id)
        {
            var limitedExchangeRewardOdd = await _context.LimitedExchangeRewardOdds.FindAsync(id);

            if (limitedExchangeRewardOdd == null)
            {
                return NotFound();
            }

            return limitedExchangeRewardOdd;
        }

        // PUT: api/LimitedExchangeRewardOdd/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLimitedExchangeRewardOdd(int id, LimitedExchangeRewardOdd limitedExchangeRewardOdd)
        {
            if (id != limitedExchangeRewardOdd.Id)
            {
                return BadRequest();
            }

            _context.Entry(limitedExchangeRewardOdd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LimitedExchangeRewardOddExists(id))
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

        // POST: api/LimitedExchangeRewardOdd
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LimitedExchangeRewardOdd>> PostLimitedExchangeRewardOdd(LimitedExchangeRewardOdd limitedExchangeRewardOdd)
        {
            _context.LimitedExchangeRewardOdds.Add(limitedExchangeRewardOdd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LimitedExchangeRewardOddExists(limitedExchangeRewardOdd.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLimitedExchangeRewardOdd", new { id = limitedExchangeRewardOdd.Id }, limitedExchangeRewardOdd);
        }

        // DELETE: api/LimitedExchangeRewardOdd/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLimitedExchangeRewardOdd(int id)
        {
            var limitedExchangeRewardOdd = await _context.LimitedExchangeRewardOdds.FindAsync(id);
            if (limitedExchangeRewardOdd == null)
            {
                return NotFound();
            }

            _context.LimitedExchangeRewardOdds.Remove(limitedExchangeRewardOdd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LimitedExchangeRewardOddExists(int id)
        {
            return _context.LimitedExchangeRewardOdds.Any(e => e.Id == id);
        }
    }
}
