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
    public class SkillLevelValueController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillLevelValueController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillLevelValue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillLevelValue>>> GetSkillLevelValues()
        {
            return await _context.SkillLevelValues.ToListAsync();
        }

        // GET: api/SkillLevelValue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillLevelValue>> GetSkillLevelValue(int id)
        {
            var skillLevelValue = await _context.SkillLevelValues.FindAsync(id);

            if (skillLevelValue == null)
            {
                return NotFound();
            }

            return skillLevelValue;
        }

        // PUT: api/SkillLevelValue/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillLevelValue(int id, SkillLevelValue skillLevelValue)
        {
            if (id != skillLevelValue.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillLevelValue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillLevelValueExists(id))
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

        // POST: api/SkillLevelValue
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillLevelValue>> PostSkillLevelValue(SkillLevelValue skillLevelValue)
        {
            _context.SkillLevelValues.Add(skillLevelValue);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkillLevelValueExists(skillLevelValue.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSkillLevelValue", new { id = skillLevelValue.Id }, skillLevelValue);
        }

        // DELETE: api/SkillLevelValue/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillLevelValue(int id)
        {
            var skillLevelValue = await _context.SkillLevelValues.FindAsync(id);
            if (skillLevelValue == null)
            {
                return NotFound();
            }

            _context.SkillLevelValues.Remove(skillLevelValue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillLevelValueExists(int id)
        {
            return _context.SkillLevelValues.Any(e => e.Id == id);
        }
    }
}
