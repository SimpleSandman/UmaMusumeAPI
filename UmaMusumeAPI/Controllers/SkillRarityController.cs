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
    public class SkillRarityController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillRarityController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillRarity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillRarity>>> GetSkillRarities()
        {
            return await _context.SkillRarities.ToListAsync();
        }

        // GET: api/SkillRarity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillRarity>> GetSkillRarity(int id)
        {
            var skillRarity = await _context.SkillRarities.FindAsync(id);

            if (skillRarity == null)
            {
                return NotFound();
            }

            return skillRarity;
        }

        // PUT: api/SkillRarity/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillRarity(int id, SkillRarity skillRarity)
        {
            if (id != skillRarity.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillRarity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillRarityExists(id))
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

        // POST: api/SkillRarity
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillRarity>> PostSkillRarity(SkillRarity skillRarity)
        {
            _context.SkillRarities.Add(skillRarity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkillRarityExists(skillRarity.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSkillRarity", new { id = skillRarity.Id }, skillRarity);
        }

        // DELETE: api/SkillRarity/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillRarity(int id)
        {
            var skillRarity = await _context.SkillRarities.FindAsync(id);
            if (skillRarity == null)
            {
                return NotFound();
            }

            _context.SkillRarities.Remove(skillRarity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillRarityExists(int id)
        {
            return _context.SkillRarities.Any(e => e.Id == id);
        }
    }
}
