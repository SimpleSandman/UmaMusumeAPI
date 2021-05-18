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
    public class RaceTrophyRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrophyRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrophyReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrophyReward>>> GetRaceTrophyRewards()
        {
            return await _context.RaceTrophyRewards.ToListAsync();
        }

        // GET: api/RaceTrophyReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrophyReward>> GetRaceTrophyReward(int id)
        {
            var raceTrophyReward = await _context.RaceTrophyRewards.FindAsync(id);

            if (raceTrophyReward == null)
            {
                return NotFound();
            }

            return raceTrophyReward;
        }

        // PUT: api/RaceTrophyReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceTrophyReward(int id, RaceTrophyReward raceTrophyReward)
        {
            if (id != raceTrophyReward.TrophyId)
            {
                return BadRequest();
            }

            _context.Entry(raceTrophyReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceTrophyRewardExists(id))
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

        // POST: api/RaceTrophyReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceTrophyReward>> PostRaceTrophyReward(RaceTrophyReward raceTrophyReward)
        {
            _context.RaceTrophyRewards.Add(raceTrophyReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceTrophyRewardExists(raceTrophyReward.TrophyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceTrophyReward", new { id = raceTrophyReward.TrophyId }, raceTrophyReward);
        }

        // DELETE: api/RaceTrophyReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceTrophyReward(int id)
        {
            var raceTrophyReward = await _context.RaceTrophyRewards.FindAsync(id);
            if (raceTrophyReward == null)
            {
                return NotFound();
            }

            _context.RaceTrophyRewards.Remove(raceTrophyReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceTrophyRewardExists(int id)
        {
            return _context.RaceTrophyRewards.Any(e => e.TrophyId == id);
        }
    }
}
