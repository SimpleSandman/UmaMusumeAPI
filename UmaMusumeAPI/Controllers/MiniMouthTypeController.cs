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
    public class MiniMouthTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniMouthTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniMouthType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniMouthType>>> GetMiniMouthTypes()
        {
            return await _context.MiniMouthTypes.ToListAsync();
        }

        // GET: api/MiniMouthType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniMouthType>> GetMiniMouthType(int id)
        {
            var miniMouthType = await _context.MiniMouthTypes.FindAsync(id);

            if (miniMouthType == null)
            {
                return NotFound();
            }

            return miniMouthType;
        }

        // PUT: api/MiniMouthType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiniMouthType(int id, MiniMouthType miniMouthType)
        {
            if (id != miniMouthType.Id)
            {
                return BadRequest();
            }

            _context.Entry(miniMouthType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniMouthTypeExists(id))
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

        // POST: api/MiniMouthType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MiniMouthType>> PostMiniMouthType(MiniMouthType miniMouthType)
        {
            _context.MiniMouthTypes.Add(miniMouthType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MiniMouthTypeExists(miniMouthType.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMiniMouthType", new { id = miniMouthType.Id }, miniMouthType);
        }

        // DELETE: api/MiniMouthType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiniMouthType(int id)
        {
            var miniMouthType = await _context.MiniMouthTypes.FindAsync(id);
            if (miniMouthType == null)
            {
                return NotFound();
            }

            _context.MiniMouthTypes.Remove(miniMouthType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MiniMouthTypeExists(int id)
        {
            return _context.MiniMouthTypes.Any(e => e.Id == id);
        }
    }
}
