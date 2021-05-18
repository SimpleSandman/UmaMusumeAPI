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
    public class CraneGamePropController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePropController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameProp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameProp>>> GetCraneGameProps()
        {
            return await _context.CraneGameProps.ToListAsync();
        }

        // GET: api/CraneGameProp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameProp>> GetCraneGameProp(int id)
        {
            var craneGameProp = await _context.CraneGameProps.FindAsync(id);

            if (craneGameProp == null)
            {
                return NotFound();
            }

            return craneGameProp;
        }

        // PUT: api/CraneGameProp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameProp(int id, CraneGameProp craneGameProp)
        {
            if (id != craneGameProp.Type)
            {
                return BadRequest();
            }

            _context.Entry(craneGameProp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGamePropExists(id))
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

        // POST: api/CraneGameProp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameProp>> PostCraneGameProp(CraneGameProp craneGameProp)
        {
            _context.CraneGameProps.Add(craneGameProp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGamePropExists(craneGameProp.Type))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameProp", new { id = craneGameProp.Type }, craneGameProp);
        }

        // DELETE: api/CraneGameProp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameProp(int id)
        {
            var craneGameProp = await _context.CraneGameProps.FindAsync(id);
            if (craneGameProp == null)
            {
                return NotFound();
            }

            _context.CraneGameProps.Remove(craneGameProp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGamePropExists(int id)
        {
            return _context.CraneGameProps.Any(e => e.Type == id);
        }
    }
}
