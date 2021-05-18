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
    public class SuccessionRelationRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelationRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelationRank>>> GetSuccessionRelationRanks()
        {
            return await _context.SuccessionRelationRanks.ToListAsync();
        }

        // GET: api/SuccessionRelationRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelationRank>> GetSuccessionRelationRank(int id)
        {
            var successionRelationRank = await _context.SuccessionRelationRanks.FindAsync(id);

            if (successionRelationRank == null)
            {
                return NotFound();
            }

            return successionRelationRank;
        }

        // PUT: api/SuccessionRelationRank/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionRelationRank(int id, SuccessionRelationRank successionRelationRank)
        {
            if (id != successionRelationRank.RelationRank)
            {
                return BadRequest();
            }

            _context.Entry(successionRelationRank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionRelationRankExists(id))
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

        // POST: api/SuccessionRelationRank
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionRelationRank>> PostSuccessionRelationRank(SuccessionRelationRank successionRelationRank)
        {
            _context.SuccessionRelationRanks.Add(successionRelationRank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionRelationRankExists(successionRelationRank.RelationRank))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionRelationRank", new { id = successionRelationRank.RelationRank }, successionRelationRank);
        }

        // DELETE: api/SuccessionRelationRank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionRelationRank(int id)
        {
            var successionRelationRank = await _context.SuccessionRelationRanks.FindAsync(id);
            if (successionRelationRank == null)
            {
                return NotFound();
            }

            _context.SuccessionRelationRanks.Remove(successionRelationRank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionRelationRankExists(int id)
        {
            return _context.SuccessionRelationRanks.Any(e => e.RelationRank == id);
        }
    }
}
