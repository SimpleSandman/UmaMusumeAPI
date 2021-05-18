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
    public class GachaPieceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaPieceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaPiece
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaPiece>>> GetGachaPieces()
        {
            return await _context.GachaPieces.ToListAsync();
        }

        // GET: api/GachaPiece/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaPiece>> GetGachaPiece(int id)
        {
            var gachaPiece = await _context.GachaPieces.FindAsync(id);

            if (gachaPiece == null)
            {
                return NotFound();
            }

            return gachaPiece;
        }

        // PUT: api/GachaPiece/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaPiece(int id, GachaPiece gachaPiece)
        {
            if (id != gachaPiece.Id)
            {
                return BadRequest();
            }

            _context.Entry(gachaPiece).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaPieceExists(id))
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

        // POST: api/GachaPiece
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaPiece>> PostGachaPiece(GachaPiece gachaPiece)
        {
            _context.GachaPieces.Add(gachaPiece);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaPieceExists(gachaPiece.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaPiece", new { id = gachaPiece.Id }, gachaPiece);
        }

        // DELETE: api/GachaPiece/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaPiece(int id)
        {
            var gachaPiece = await _context.GachaPieces.FindAsync(id);
            if (gachaPiece == null)
            {
                return NotFound();
            }

            _context.GachaPieces.Remove(gachaPiece);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaPieceExists(int id)
        {
            return _context.GachaPieces.Any(e => e.Id == id);
        }
    }
}
