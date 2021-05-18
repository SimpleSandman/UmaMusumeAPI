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
    public class SingleModeRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRank>>> GetSingleModeRanks()
        {
            return await _context.SingleModeRanks.ToListAsync();
        }

        // GET: api/SingleModeRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRank>> GetSingleModeRank(int id)
        {
            var singleModeRank = await _context.SingleModeRanks.FindAsync(id);

            if (singleModeRank == null)
            {
                return NotFound();
            }

            return singleModeRank;
        }

        // PUT: api/SingleModeRank/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRank(int id, SingleModeRank singleModeRank)
        {
            if (id != singleModeRank.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRankExists(id))
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

        // POST: api/SingleModeRank
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRank>> PostSingleModeRank(SingleModeRank singleModeRank)
        {
            _context.SingleModeRanks.Add(singleModeRank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRankExists(singleModeRank.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRank", new { id = singleModeRank.Id }, singleModeRank);
        }

        // DELETE: api/SingleModeRank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRank(int id)
        {
            var singleModeRank = await _context.SingleModeRanks.FindAsync(id);
            if (singleModeRank == null)
            {
                return NotFound();
            }

            _context.SingleModeRanks.Remove(singleModeRank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRankExists(int id)
        {
            return _context.SingleModeRanks.Any(e => e.Id == id);
        }
    }
}
