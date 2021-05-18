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
    public class MiniMotionSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniMotionSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniMotionSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniMotionSet>>> GetMiniMotionSets()
        {
            return await _context.MiniMotionSets.ToListAsync();
        }

        // GET: api/MiniMotionSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniMotionSet>> GetMiniMotionSet(string id)
        {
            var miniMotionSet = await _context.MiniMotionSets.FindAsync(id);

            if (miniMotionSet == null)
            {
                return NotFound();
            }

            return miniMotionSet;
        }

        // PUT: api/MiniMotionSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiniMotionSet(string id, MiniMotionSet miniMotionSet)
        {
            if (id != miniMotionSet.Label)
            {
                return BadRequest();
            }

            _context.Entry(miniMotionSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniMotionSetExists(id))
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

        // POST: api/MiniMotionSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MiniMotionSet>> PostMiniMotionSet(MiniMotionSet miniMotionSet)
        {
            _context.MiniMotionSets.Add(miniMotionSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MiniMotionSetExists(miniMotionSet.Label))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMiniMotionSet", new { id = miniMotionSet.Label }, miniMotionSet);
        }

        // DELETE: api/MiniMotionSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiniMotionSet(string id)
        {
            var miniMotionSet = await _context.MiniMotionSets.FindAsync(id);
            if (miniMotionSet == null)
            {
                return NotFound();
            }

            _context.MiniMotionSets.Remove(miniMotionSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MiniMotionSetExists(string id)
        {
            return _context.MiniMotionSets.Any(e => e.Label == id);
        }
    }
}
