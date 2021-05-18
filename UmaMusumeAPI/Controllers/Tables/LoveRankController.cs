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
    public class LoveRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LoveRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LoveRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoveRank>>> GetLoveRanks()
        {
            return await _context.LoveRanks.ToListAsync();
        }

        // GET: api/LoveRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoveRank>> GetLoveRank(int id)
        {
            var loveRank = await _context.LoveRanks.FindAsync(id);

            if (loveRank == null)
            {
                return NotFound();
            }

            return loveRank;
        }

        // PUT: api/LoveRank/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoveRank(int id, LoveRank loveRank)
        {
            if (id != loveRank.Id)
            {
                return BadRequest();
            }

            _context.Entry(loveRank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoveRankExists(id))
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

        // POST: api/LoveRank
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoveRank>> PostLoveRank(LoveRank loveRank)
        {
            _context.LoveRanks.Add(loveRank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoveRankExists(loveRank.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoveRank", new { id = loveRank.Id }, loveRank);
        }

        // DELETE: api/LoveRank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoveRank(int id)
        {
            var loveRank = await _context.LoveRanks.FindAsync(id);
            if (loveRank == null)
            {
                return NotFound();
            }

            _context.LoveRanks.Remove(loveRank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoveRankExists(int id)
        {
            return _context.LoveRanks.Any(e => e.Id == id);
        }
    }
}
