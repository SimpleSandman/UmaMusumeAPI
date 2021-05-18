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
    public class CharaCategoryMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaCategoryMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaCategoryMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaCategoryMotion>>> GetCharaCategoryMotions()
        {
            return await _context.CharaCategoryMotions.ToListAsync();
        }

        // GET: api/CharaCategoryMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaCategoryMotion>> GetCharaCategoryMotion(int id)
        {
            var charaCategoryMotion = await _context.CharaCategoryMotions.FindAsync(id);

            if (charaCategoryMotion == null)
            {
                return NotFound();
            }

            return charaCategoryMotion;
        }

        // PUT: api/CharaCategoryMotion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaCategoryMotion(int id, CharaCategoryMotion charaCategoryMotion)
        {
            if (id != charaCategoryMotion.CharaId)
            {
                return BadRequest();
            }

            _context.Entry(charaCategoryMotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaCategoryMotionExists(id))
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

        // POST: api/CharaCategoryMotion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaCategoryMotion>> PostCharaCategoryMotion(CharaCategoryMotion charaCategoryMotion)
        {
            _context.CharaCategoryMotions.Add(charaCategoryMotion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaCategoryMotionExists(charaCategoryMotion.CharaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaCategoryMotion", new { id = charaCategoryMotion.CharaId }, charaCategoryMotion);
        }

        // DELETE: api/CharaCategoryMotion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaCategoryMotion(int id)
        {
            var charaCategoryMotion = await _context.CharaCategoryMotions.FindAsync(id);
            if (charaCategoryMotion == null)
            {
                return NotFound();
            }

            _context.CharaCategoryMotions.Remove(charaCategoryMotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaCategoryMotionExists(int id)
        {
            return _context.CharaCategoryMotions.Any(e => e.CharaId == id);
        }
    }
}
