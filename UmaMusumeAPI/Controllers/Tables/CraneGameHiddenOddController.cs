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
    public class CraneGameHiddenOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameHiddenOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameHiddenOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameHiddenOdd>>> GetCraneGameHiddenOdds()
        {
            return await _context.CraneGameHiddenOdds.ToListAsync();
        }

        // GET: api/CraneGameHiddenOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameHiddenOdd>> GetCraneGameHiddenOdd(int id)
        {
            var craneGameHiddenOdd = await _context.CraneGameHiddenOdds.FindAsync(id);

            if (craneGameHiddenOdd == null)
            {
                return NotFound();
            }

            return craneGameHiddenOdd;
        }

        // PUT: api/CraneGameHiddenOdd/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameHiddenOdd(int id, CraneGameHiddenOdd craneGameHiddenOdd)
        {
            if (id != craneGameHiddenOdd.Id)
            {
                return BadRequest();
            }

            _context.Entry(craneGameHiddenOdd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGameHiddenOddExists(id))
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

        // POST: api/CraneGameHiddenOdd
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameHiddenOdd>> PostCraneGameHiddenOdd(CraneGameHiddenOdd craneGameHiddenOdd)
        {
            _context.CraneGameHiddenOdds.Add(craneGameHiddenOdd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGameHiddenOddExists(craneGameHiddenOdd.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameHiddenOdd", new { id = craneGameHiddenOdd.Id }, craneGameHiddenOdd);
        }

        // DELETE: api/CraneGameHiddenOdd/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameHiddenOdd(int id)
        {
            var craneGameHiddenOdd = await _context.CraneGameHiddenOdds.FindAsync(id);
            if (craneGameHiddenOdd == null)
            {
                return NotFound();
            }

            _context.CraneGameHiddenOdds.Remove(craneGameHiddenOdd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGameHiddenOddExists(int id)
        {
            return _context.CraneGameHiddenOdds.Any(e => e.Id == id);
        }
    }
}
