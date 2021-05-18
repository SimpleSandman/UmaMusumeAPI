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
    public class PieceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public PieceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/PieceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PieceData>>> GetPieceData()
        {
            return await _context.PieceData.ToListAsync();
        }

        // GET: api/PieceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PieceData>> GetPieceData(int id)
        {
            var pieceData = await _context.PieceData.FindAsync(id);

            if (pieceData == null)
            {
                return NotFound();
            }

            return pieceData;
        }

        // PUT: api/PieceData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPieceData(int id, PieceData pieceData)
        {
            if (id != pieceData.Id)
            {
                return BadRequest();
            }

            _context.Entry(pieceData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PieceDataExists(id))
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

        // POST: api/PieceData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PieceData>> PostPieceData(PieceData pieceData)
        {
            _context.PieceData.Add(pieceData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PieceDataExists(pieceData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPieceData", new { id = pieceData.Id }, pieceData);
        }

        // DELETE: api/PieceData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePieceData(int id)
        {
            var pieceData = await _context.PieceData.FindAsync(id);
            if (pieceData == null)
            {
                return NotFound();
            }

            _context.PieceData.Remove(pieceData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PieceDataExists(int id)
        {
            return _context.PieceData.Any(e => e.Id == id);
        }
    }
}
