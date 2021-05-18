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
    public class CharaMotionSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaMotionSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaMotionSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaMotionSet>>> GetCharaMotionSets()
        {
            return await _context.CharaMotionSets.ToListAsync();
        }

        // GET: api/CharaMotionSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaMotionSet>> GetCharaMotionSet(int id)
        {
            var charaMotionSet = await _context.CharaMotionSets.FindAsync(id);

            if (charaMotionSet == null)
            {
                return NotFound();
            }

            return charaMotionSet;
        }

        // PUT: api/CharaMotionSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaMotionSet(int id, CharaMotionSet charaMotionSet)
        {
            if (id != charaMotionSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(charaMotionSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaMotionSetExists(id))
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

        // POST: api/CharaMotionSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaMotionSet>> PostCharaMotionSet(CharaMotionSet charaMotionSet)
        {
            _context.CharaMotionSets.Add(charaMotionSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaMotionSetExists(charaMotionSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaMotionSet", new { id = charaMotionSet.Id }, charaMotionSet);
        }

        // DELETE: api/CharaMotionSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaMotionSet(int id)
        {
            var charaMotionSet = await _context.CharaMotionSets.FindAsync(id);
            if (charaMotionSet == null)
            {
                return NotFound();
            }

            _context.CharaMotionSets.Remove(charaMotionSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaMotionSetExists(int id)
        {
            return _context.CharaMotionSets.Any(e => e.Id == id);
        }
    }
}
