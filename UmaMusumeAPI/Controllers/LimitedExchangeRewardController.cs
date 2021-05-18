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
    public class LimitedExchangeRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchangeReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchangeReward>>> GetLimitedExchangeRewards()
        {
            return await _context.LimitedExchangeRewards.ToListAsync();
        }

        // GET: api/LimitedExchangeReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchangeReward>> GetLimitedExchangeReward(int id)
        {
            var limitedExchangeReward = await _context.LimitedExchangeRewards.FindAsync(id);

            if (limitedExchangeReward == null)
            {
                return NotFound();
            }

            return limitedExchangeReward;
        }

        // PUT: api/LimitedExchangeReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLimitedExchangeReward(int id, LimitedExchangeReward limitedExchangeReward)
        {
            if (id != limitedExchangeReward.Id)
            {
                return BadRequest();
            }

            _context.Entry(limitedExchangeReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LimitedExchangeRewardExists(id))
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

        // POST: api/LimitedExchangeReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LimitedExchangeReward>> PostLimitedExchangeReward(LimitedExchangeReward limitedExchangeReward)
        {
            _context.LimitedExchangeRewards.Add(limitedExchangeReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LimitedExchangeRewardExists(limitedExchangeReward.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLimitedExchangeReward", new { id = limitedExchangeReward.Id }, limitedExchangeReward);
        }

        // DELETE: api/LimitedExchangeReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLimitedExchangeReward(int id)
        {
            var limitedExchangeReward = await _context.LimitedExchangeRewards.FindAsync(id);
            if (limitedExchangeReward == null)
            {
                return NotFound();
            }

            _context.LimitedExchangeRewards.Remove(limitedExchangeReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LimitedExchangeRewardExists(int id)
        {
            return _context.LimitedExchangeRewards.Any(e => e.Id == id);
        }
    }
}
