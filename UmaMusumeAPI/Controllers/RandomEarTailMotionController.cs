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
    public class RandomEarTailMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RandomEarTailMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RandomEarTailMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RandomEarTailMotion>>> GetRandomEarTailMotions()
        {
            return await _context.RandomEarTailMotions.ToListAsync();
        }

        // GET: api/RandomEarTailMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RandomEarTailMotion>> GetRandomEarTailMotion(int id)
        {
            var randomEarTailMotion = await _context.RandomEarTailMotions.FindAsync(id);

            if (randomEarTailMotion == null)
            {
                return NotFound();
            }

            return randomEarTailMotion;
        }

        // PUT: api/RandomEarTailMotion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRandomEarTailMotion(int id, RandomEarTailMotion randomEarTailMotion)
        {
            if (id != randomEarTailMotion.Id)
            {
                return BadRequest();
            }

            _context.Entry(randomEarTailMotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RandomEarTailMotionExists(id))
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

        // POST: api/RandomEarTailMotion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RandomEarTailMotion>> PostRandomEarTailMotion(RandomEarTailMotion randomEarTailMotion)
        {
            _context.RandomEarTailMotions.Add(randomEarTailMotion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RandomEarTailMotionExists(randomEarTailMotion.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRandomEarTailMotion", new { id = randomEarTailMotion.Id }, randomEarTailMotion);
        }

        // DELETE: api/RandomEarTailMotion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRandomEarTailMotion(int id)
        {
            var randomEarTailMotion = await _context.RandomEarTailMotions.FindAsync(id);
            if (randomEarTailMotion == null)
            {
                return NotFound();
            }

            _context.RandomEarTailMotions.Remove(randomEarTailMotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RandomEarTailMotionExists(int id)
        {
            return _context.RandomEarTailMotions.Any(e => e.Id == id);
        }
    }
}
