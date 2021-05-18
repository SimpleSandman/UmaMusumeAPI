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
    public class MobDressColorSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobDressColorSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobDressColorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobDressColorSet>>> GetMobDressColorSets()
        {
            return await _context.MobDressColorSets.ToListAsync();
        }

        // GET: api/MobDressColorSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobDressColorSet>> GetMobDressColorSet(int id)
        {
            var mobDressColorSet = await _context.MobDressColorSets.FindAsync(id);

            if (mobDressColorSet == null)
            {
                return NotFound();
            }

            return mobDressColorSet;
        }

        // PUT: api/MobDressColorSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobDressColorSet(int id, MobDressColorSet mobDressColorSet)
        {
            if (id != mobDressColorSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(mobDressColorSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobDressColorSetExists(id))
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

        // POST: api/MobDressColorSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MobDressColorSet>> PostMobDressColorSet(MobDressColorSet mobDressColorSet)
        {
            _context.MobDressColorSets.Add(mobDressColorSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MobDressColorSetExists(mobDressColorSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMobDressColorSet", new { id = mobDressColorSet.Id }, mobDressColorSet);
        }

        // DELETE: api/MobDressColorSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMobDressColorSet(int id)
        {
            var mobDressColorSet = await _context.MobDressColorSets.FindAsync(id);
            if (mobDressColorSet == null)
            {
                return NotFound();
            }

            _context.MobDressColorSets.Remove(mobDressColorSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MobDressColorSetExists(int id)
        {
            return _context.MobDressColorSets.Any(e => e.Id == id);
        }
    }
}
