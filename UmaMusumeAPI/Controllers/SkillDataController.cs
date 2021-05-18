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
    public class SkillDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SkillDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SkillData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillData>>> GetSkillData()
        {
            return await _context.SkillData.ToListAsync();
        }

        // GET: api/SkillData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillData>> GetSkillData(int id)
        {
            var skillData = await _context.SkillData.FindAsync(id);

            if (skillData == null)
            {
                return NotFound();
            }

            return skillData;
        }

        // PUT: api/SkillData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillData(int id, SkillData skillData)
        {
            if (id != skillData.Id)
            {
                return BadRequest();
            }

            _context.Entry(skillData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillDataExists(id))
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

        // POST: api/SkillData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillData>> PostSkillData(SkillData skillData)
        {
            _context.SkillData.Add(skillData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SkillDataExists(skillData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSkillData", new { id = skillData.Id }, skillData);
        }

        // DELETE: api/SkillData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillData(int id)
        {
            var skillData = await _context.SkillData.FindAsync(id);
            if (skillData == null)
            {
                return NotFound();
            }

            _context.SkillData.Remove(skillData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillDataExists(int id)
        {
            return _context.SkillData.Any(e => e.Id == id);
        }
    }
}
