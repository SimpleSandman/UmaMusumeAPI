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
    public class SkillExpController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillExpController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillExp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillExp>>> GetSkillExps()
        {
            return await _context.SkillExps.ToListAsync();
        }

        // GET: api/SkillExp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillExp>> GetSkillExp(int id)
        {
            var skillExp = await _context.SkillExps.FindAsync(id);

            if (skillExp == null)
            {
                return NotFound();
            }

            return skillExp;
        }

        // PUT: api/SkillExp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillExp(int id, SkillExp skillExp)
        {
            if (id != skillExp.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillExp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillExpExists(id))
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

        // POST: api/SkillExp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillExp>> PostSkillExp(SkillExp skillExp)
        {
            _context.SkillExps.Add(skillExp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkillExpExists(skillExp.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSkillExp", new { id = skillExp.Id }, skillExp);
        }

        // DELETE: api/SkillExp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillExp(int id)
        {
            var skillExp = await _context.SkillExps.FindAsync(id);
            if (skillExp == null)
            {
                return NotFound();
            }

            _context.SkillExps.Remove(skillExp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillExpExists(int id)
        {
            return _context.SkillExps.Any(e => e.Id == id);
        }
    }
}
