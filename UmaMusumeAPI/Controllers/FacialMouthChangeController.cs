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
    public class FacialMouthChangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FacialMouthChangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FacialMouthChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacialMouthChange>>> GetFacialMouthChanges()
        {
            return await _context.FacialMouthChanges.ToListAsync();
        }

        // GET: api/FacialMouthChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacialMouthChange>> GetFacialMouthChange(int id)
        {
            var facialMouthChange = await _context.FacialMouthChanges.FindAsync(id);

            if (facialMouthChange == null)
            {
                return NotFound();
            }

            return facialMouthChange;
        }

        // PUT: api/FacialMouthChange/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacialMouthChange(int id, FacialMouthChange facialMouthChange)
        {
            if (id != facialMouthChange.Id)
            {
                return BadRequest();
            }

            _context.Entry(facialMouthChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacialMouthChangeExists(id))
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

        // POST: api/FacialMouthChange
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacialMouthChange>> PostFacialMouthChange(FacialMouthChange facialMouthChange)
        {
            _context.FacialMouthChanges.Add(facialMouthChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FacialMouthChangeExists(facialMouthChange.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFacialMouthChange", new { id = facialMouthChange.Id }, facialMouthChange);
        }

        // DELETE: api/FacialMouthChange/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacialMouthChange(int id)
        {
            var facialMouthChange = await _context.FacialMouthChanges.FindAsync(id);
            if (facialMouthChange == null)
            {
                return NotFound();
            }

            _context.FacialMouthChanges.Remove(facialMouthChange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacialMouthChangeExists(int id)
        {
            return _context.FacialMouthChanges.Any(e => e.Id == id);
        }
    }
}
