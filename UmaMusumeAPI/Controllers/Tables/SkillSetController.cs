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
    public class SkillSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillSet>>> GetSkillSets()
        {
            return await _context.SkillSets.ToListAsync();
        }

        // GET: api/SkillSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillSet>> GetSkillSet(int id)
        {
            var skillSet = await _context.SkillSets.FindAsync(id);

            if (skillSet == null)
            {
                return NotFound();
            }

            return skillSet;
        }

        // PUT: api/SkillSet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillSet(int id, SkillSet skillSet)
        {
            if (id != skillSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillSetExists(id))
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

        // POST: api/SkillSet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillSet>> PostSkillSet(SkillSet skillSet)
        {
            _context.SkillSets.Add(skillSet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkillSetExists(skillSet.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSkillSet", new { id = skillSet.Id }, skillSet);
        }

        // DELETE: api/SkillSet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillSet(int id)
        {
            var skillSet = await _context.SkillSets.FindAsync(id);
            if (skillSet == null)
            {
                return NotFound();
            }

            _context.SkillSets.Remove(skillSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillSetExists(int id)
        {
            return _context.SkillSets.Any(e => e.Id == id);
        }
    }
}
