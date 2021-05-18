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
    public class CraneGameCatchResultController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameCatchResultController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameCatchResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameCatchResult>>> GetCraneGameCatchResults()
        {
            return await _context.CraneGameCatchResults.ToListAsync();
        }

        // GET: api/CraneGameCatchResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameCatchResult>> GetCraneGameCatchResult(int id)
        {
            var craneGameCatchResult = await _context.CraneGameCatchResults.FindAsync(id);

            if (craneGameCatchResult == null)
            {
                return NotFound();
            }

            return craneGameCatchResult;
        }

        // PUT: api/CraneGameCatchResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameCatchResult(int id, CraneGameCatchResult craneGameCatchResult)
        {
            if (id != craneGameCatchResult.OddsId)
            {
                return BadRequest();
            }

            _context.Entry(craneGameCatchResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGameCatchResultExists(id))
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

        // POST: api/CraneGameCatchResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameCatchResult>> PostCraneGameCatchResult(CraneGameCatchResult craneGameCatchResult)
        {
            _context.CraneGameCatchResults.Add(craneGameCatchResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGameCatchResultExists(craneGameCatchResult.OddsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameCatchResult", new { id = craneGameCatchResult.OddsId }, craneGameCatchResult);
        }

        // DELETE: api/CraneGameCatchResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameCatchResult(int id)
        {
            var craneGameCatchResult = await _context.CraneGameCatchResults.FindAsync(id);
            if (craneGameCatchResult == null)
            {
                return NotFound();
            }

            _context.CraneGameCatchResults.Remove(craneGameCatchResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGameCatchResultExists(int id)
        {
            return _context.CraneGameCatchResults.Any(e => e.OddsId == id);
        }
    }
}
