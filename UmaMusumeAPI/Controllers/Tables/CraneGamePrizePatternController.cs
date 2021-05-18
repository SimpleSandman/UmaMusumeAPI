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
    public class CraneGamePrizePatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePrizePatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGamePrizePattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGamePrizePattern>>> GetCraneGamePrizePatterns()
        {
            return await _context.CraneGamePrizePatterns.ToListAsync();
        }

        // GET: api/CraneGamePrizePattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGamePrizePattern>> GetCraneGamePrizePattern(int id)
        {
            var craneGamePrizePattern = await _context.CraneGamePrizePatterns.FindAsync(id);

            if (craneGamePrizePattern == null)
            {
                return NotFound();
            }

            return craneGamePrizePattern;
        }

        // PUT: api/CraneGamePrizePattern/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGamePrizePattern(int id, CraneGamePrizePattern craneGamePrizePattern)
        {
            if (id != craneGamePrizePattern.Id)
            {
                return BadRequest();
            }

            _context.Entry(craneGamePrizePattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGamePrizePatternExists(id))
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

        // POST: api/CraneGamePrizePattern
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGamePrizePattern>> PostCraneGamePrizePattern(CraneGamePrizePattern craneGamePrizePattern)
        {
            _context.CraneGamePrizePatterns.Add(craneGamePrizePattern);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGamePrizePatternExists(craneGamePrizePattern.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGamePrizePattern", new { id = craneGamePrizePattern.Id }, craneGamePrizePattern);
        }

        // DELETE: api/CraneGamePrizePattern/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGamePrizePattern(int id)
        {
            var craneGamePrizePattern = await _context.CraneGamePrizePatterns.FindAsync(id);
            if (craneGamePrizePattern == null)
            {
                return NotFound();
            }

            _context.CraneGamePrizePatterns.Remove(craneGamePrizePattern);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGamePrizePatternExists(int id)
        {
            return _context.CraneGamePrizePatterns.Any(e => e.Id == id);
        }
    }
}
