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
    public class CraneGameArmSwingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameArmSwingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameArmSwing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameArmSwing>>> GetCraneGameArmSwings()
        {
            return await _context.CraneGameArmSwings.ToListAsync();
        }

        // GET: api/CraneGameArmSwing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameArmSwing>> GetCraneGameArmSwing(int id)
        {
            var craneGameArmSwing = await _context.CraneGameArmSwings.FindAsync(id);

            if (craneGameArmSwing == null)
            {
                return NotFound();
            }

            return craneGameArmSwing;
        }

        // PUT: api/CraneGameArmSwing/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameArmSwing(int id, CraneGameArmSwing craneGameArmSwing)
        {
            if (id != craneGameArmSwing.ResultType)
            {
                return BadRequest();
            }

            _context.Entry(craneGameArmSwing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGameArmSwingExists(id))
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

        // POST: api/CraneGameArmSwing
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameArmSwing>> PostCraneGameArmSwing(CraneGameArmSwing craneGameArmSwing)
        {
            _context.CraneGameArmSwings.Add(craneGameArmSwing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGameArmSwingExists(craneGameArmSwing.ResultType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameArmSwing", new { id = craneGameArmSwing.ResultType }, craneGameArmSwing);
        }

        // DELETE: api/CraneGameArmSwing/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameArmSwing(int id)
        {
            var craneGameArmSwing = await _context.CraneGameArmSwings.FindAsync(id);
            if (craneGameArmSwing == null)
            {
                return NotFound();
            }

            _context.CraneGameArmSwings.Remove(craneGameArmSwing);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGameArmSwingExists(int id)
        {
            return _context.CraneGameArmSwings.Any(e => e.ResultType == id);
        }
    }
}
