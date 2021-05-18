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
    public class MiniBgCharaMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniBgCharaMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniBgCharaMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniBgCharaMotion>>> GetMiniBgCharaMotions()
        {
            return await _context.MiniBgCharaMotions.ToListAsync();
        }

        // GET: api/MiniBgCharaMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniBgCharaMotion>> GetMiniBgCharaMotion(int id)
        {
            var miniBgCharaMotion = await _context.MiniBgCharaMotions.FindAsync(id);

            if (miniBgCharaMotion == null)
            {
                return NotFound();
            }

            return miniBgCharaMotion;
        }

        // PUT: api/MiniBgCharaMotion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiniBgCharaMotion(int id, MiniBgCharaMotion miniBgCharaMotion)
        {
            if (id != miniBgCharaMotion.Id)
            {
                return BadRequest();
            }

            _context.Entry(miniBgCharaMotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniBgCharaMotionExists(id))
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

        // POST: api/MiniBgCharaMotion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MiniBgCharaMotion>> PostMiniBgCharaMotion(MiniBgCharaMotion miniBgCharaMotion)
        {
            _context.MiniBgCharaMotions.Add(miniBgCharaMotion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MiniBgCharaMotionExists(miniBgCharaMotion.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMiniBgCharaMotion", new { id = miniBgCharaMotion.Id }, miniBgCharaMotion);
        }

        // DELETE: api/MiniBgCharaMotion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiniBgCharaMotion(int id)
        {
            var miniBgCharaMotion = await _context.MiniBgCharaMotions.FindAsync(id);
            if (miniBgCharaMotion == null)
            {
                return NotFound();
            }

            _context.MiniBgCharaMotions.Remove(miniBgCharaMotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MiniBgCharaMotionExists(int id)
        {
            return _context.MiniBgCharaMotions.Any(e => e.Id == id);
        }
    }
}
