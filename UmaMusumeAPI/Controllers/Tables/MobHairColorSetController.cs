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
    public class MobHairColorSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobHairColorSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobHairColorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobHairColorSet>>> GetMobHairColorSets()
        {
            return await _context.MobHairColorSets.ToListAsync();
        }

        // GET: api/MobHairColorSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobHairColorSet>> GetMobHairColorSet(int id)
        {
            var mobHairColorSet = await _context.MobHairColorSets.FindAsync(id);

            if (mobHairColorSet == null)
            {
                return NotFound();
            }

            return mobHairColorSet;
        }

        // PUT: api/MobHairColorSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobHairColorSet(int id, MobHairColorSet mobHairColorSet)
        {
            if (id != mobHairColorSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(mobHairColorSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobHairColorSetExists(id))
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

        // POST: api/MobHairColorSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MobHairColorSet>> PostMobHairColorSet(MobHairColorSet mobHairColorSet)
        {
            _context.MobHairColorSets.Add(mobHairColorSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MobHairColorSetExists(mobHairColorSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMobHairColorSet", new { id = mobHairColorSet.Id }, mobHairColorSet);
        }

        // DELETE: api/MobHairColorSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMobHairColorSet(int id)
        {
            var mobHairColorSet = await _context.MobHairColorSets.FindAsync(id);
            if (mobHairColorSet == null)
            {
                return NotFound();
            }

            _context.MobHairColorSets.Remove(mobHairColorSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MobHairColorSetExists(int id)
        {
            return _context.MobHairColorSets.Any(e => e.Id == id);
        }
    }
}
