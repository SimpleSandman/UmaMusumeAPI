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
    public class AvailableSkillSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AvailableSkillSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AvailableSkillSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvailableSkillSet>>> GetAvailableSkillSets()
        {
            return await _context.AvailableSkillSets.ToListAsync();
        }

        // GET: api/AvailableSkillSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AvailableSkillSet>> GetAvailableSkillSet(int id)
        {
            var availableSkillSet = await _context.AvailableSkillSets.FindAsync(id);

            if (availableSkillSet == null)
            {
                return NotFound();
            }

            return availableSkillSet;
        }

        // PUT: api/AvailableSkillSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvailableSkillSet(int id, AvailableSkillSet availableSkillSet)
        {
            if (id != availableSkillSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(availableSkillSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvailableSkillSetExists(id))
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

        // POST: api/AvailableSkillSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AvailableSkillSet>> PostAvailableSkillSet(AvailableSkillSet availableSkillSet)
        {
            _context.AvailableSkillSets.Add(availableSkillSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AvailableSkillSetExists(availableSkillSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAvailableSkillSet", new { id = availableSkillSet.Id }, availableSkillSet);
        }

        // DELETE: api/AvailableSkillSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvailableSkillSet(int id)
        {
            var availableSkillSet = await _context.AvailableSkillSets.FindAsync(id);
            if (availableSkillSet == null)
            {
                return NotFound();
            }

            _context.AvailableSkillSets.Remove(availableSkillSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AvailableSkillSetExists(int id)
        {
            return _context.AvailableSkillSets.Any(e => e.Id == id);
        }
    }
}
