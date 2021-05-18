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
    public class ChampionsEntryRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsEntryRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsEntryReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsEntryReward>>> GetChampionsEntryRewards()
        {
            return await _context.ChampionsEntryRewards.ToListAsync();
        }

        // GET: api/ChampionsEntryReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsEntryReward>> GetChampionsEntryReward(int id)
        {
            var championsEntryReward = await _context.ChampionsEntryRewards.FindAsync(id);

            if (championsEntryReward == null)
            {
                return NotFound();
            }

            return championsEntryReward;
        }

        // PUT: api/ChampionsEntryReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsEntryReward(int id, ChampionsEntryReward championsEntryReward)
        {
            if (id != championsEntryReward.ChampionsId)
            {
                return BadRequest();
            }

            _context.Entry(championsEntryReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsEntryRewardExists(id))
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

        // POST: api/ChampionsEntryReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsEntryReward>> PostChampionsEntryReward(ChampionsEntryReward championsEntryReward)
        {
            _context.ChampionsEntryRewards.Add(championsEntryReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsEntryRewardExists(championsEntryReward.ChampionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsEntryReward", new { id = championsEntryReward.ChampionsId }, championsEntryReward);
        }

        // DELETE: api/ChampionsEntryReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsEntryReward(int id)
        {
            var championsEntryReward = await _context.ChampionsEntryRewards.FindAsync(id);
            if (championsEntryReward == null)
            {
                return NotFound();
            }

            _context.ChampionsEntryRewards.Remove(championsEntryReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsEntryRewardExists(int id)
        {
            return _context.ChampionsEntryRewards.Any(e => e.ChampionsId == id);
        }
    }
}
