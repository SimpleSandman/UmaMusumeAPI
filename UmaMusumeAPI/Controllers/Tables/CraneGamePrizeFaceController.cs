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
    public class CraneGamePrizeFaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePrizeFaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGamePrizeFace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGamePrizeFace>>> GetCraneGamePrizeFaces()
        {
            return await _context.CraneGamePrizeFaces.ToListAsync();
        }

        // GET: api/CraneGamePrizeFace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGamePrizeFace>> GetCraneGamePrizeFace(int id)
        {
            var craneGamePrizeFace = await _context.CraneGamePrizeFaces.FindAsync(id);

            if (craneGamePrizeFace == null)
            {
                return NotFound();
            }

            return craneGamePrizeFace;
        }

        // PUT: api/CraneGamePrizeFace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGamePrizeFace(int id, CraneGamePrizeFace craneGamePrizeFace)
        {
            if (id != craneGamePrizeFace.Id)
            {
                return BadRequest();
            }

            _context.Entry(craneGamePrizeFace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGamePrizeFaceExists(id))
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

        // POST: api/CraneGamePrizeFace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGamePrizeFace>> PostCraneGamePrizeFace(CraneGamePrizeFace craneGamePrizeFace)
        {
            _context.CraneGamePrizeFaces.Add(craneGamePrizeFace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGamePrizeFaceExists(craneGamePrizeFace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGamePrizeFace", new { id = craneGamePrizeFace.Id }, craneGamePrizeFace);
        }

        // DELETE: api/CraneGamePrizeFace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGamePrizeFace(int id)
        {
            var craneGamePrizeFace = await _context.CraneGamePrizeFaces.FindAsync(id);
            if (craneGamePrizeFace == null)
            {
                return NotFound();
            }

            _context.CraneGamePrizeFaces.Remove(craneGamePrizeFace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGamePrizeFaceExists(int id)
        {
            return _context.CraneGamePrizeFaces.Any(e => e.Id == id);
        }
    }
}
