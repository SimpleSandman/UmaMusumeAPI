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
    public class HighlightInterpolateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HighlightInterpolateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HighlightInterpolate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HighlightInterpolate>>> GetHighlightInterpolates()
        {
            return await _context.HighlightInterpolates.ToListAsync();
        }

        // GET: api/HighlightInterpolate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HighlightInterpolate>> GetHighlightInterpolate(int id)
        {
            var highlightInterpolate = await _context.HighlightInterpolates.FindAsync(id);

            if (highlightInterpolate == null)
            {
                return NotFound();
            }

            return highlightInterpolate;
        }

        // PUT: api/HighlightInterpolate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHighlightInterpolate(int id, HighlightInterpolate highlightInterpolate)
        {
            if (id != highlightInterpolate.Id)
            {
                return BadRequest();
            }

            _context.Entry(highlightInterpolate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HighlightInterpolateExists(id))
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

        // POST: api/HighlightInterpolate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HighlightInterpolate>> PostHighlightInterpolate(HighlightInterpolate highlightInterpolate)
        {
            _context.HighlightInterpolates.Add(highlightInterpolate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HighlightInterpolateExists(highlightInterpolate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHighlightInterpolate", new { id = highlightInterpolate.Id }, highlightInterpolate);
        }

        // DELETE: api/HighlightInterpolate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHighlightInterpolate(int id)
        {
            var highlightInterpolate = await _context.HighlightInterpolates.FindAsync(id);
            if (highlightInterpolate == null)
            {
                return NotFound();
            }

            _context.HighlightInterpolates.Remove(highlightInterpolate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HighlightInterpolateExists(int id)
        {
            return _context.HighlightInterpolates.Any(e => e.Id == id);
        }
    }
}
