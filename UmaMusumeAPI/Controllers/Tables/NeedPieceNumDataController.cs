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
    public class NeedPieceNumDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NeedPieceNumDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NeedPieceNumData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NeedPieceNumData>>> GetNeedPieceNumData()
        {
            return await _context.NeedPieceNumData.ToListAsync();
        }

        // GET: api/NeedPieceNumData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NeedPieceNumData>> GetNeedPieceNumData(int id)
        {
            var needPieceNumData = await _context.NeedPieceNumData.FindAsync(id);

            if (needPieceNumData == null)
            {
                return NotFound();
            }

            return needPieceNumData;
        }

        // PUT: api/NeedPieceNumData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNeedPieceNumData(int id, NeedPieceNumData needPieceNumData)
        {
            if (id != needPieceNumData.Id)
            {
                return BadRequest();
            }

            _context.Entry(needPieceNumData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NeedPieceNumDataExists(id))
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

        // POST: api/NeedPieceNumData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NeedPieceNumData>> PostNeedPieceNumData(NeedPieceNumData needPieceNumData)
        {
            _context.NeedPieceNumData.Add(needPieceNumData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NeedPieceNumDataExists(needPieceNumData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNeedPieceNumData", new { id = needPieceNumData.Id }, needPieceNumData);
        }

        // DELETE: api/NeedPieceNumData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNeedPieceNumData(int id)
        {
            var needPieceNumData = await _context.NeedPieceNumData.FindAsync(id);
            if (needPieceNumData == null)
            {
                return NotFound();
            }

            _context.NeedPieceNumData.Remove(needPieceNumData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NeedPieceNumDataExists(int id)
        {
            return _context.NeedPieceNumData.Any(e => e.Id == id);
        }
    }
}
