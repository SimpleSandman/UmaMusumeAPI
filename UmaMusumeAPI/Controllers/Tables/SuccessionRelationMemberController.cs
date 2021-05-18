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
    public class SuccessionRelationMemberController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationMemberController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelationMember
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelationMember>>> GetSuccessionRelationMembers()
        {
            return await _context.SuccessionRelationMembers.ToListAsync();
        }

        // GET: api/SuccessionRelationMember/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelationMember>> GetSuccessionRelationMember(int id)
        {
            var successionRelationMember = await _context.SuccessionRelationMembers.FindAsync(id);

            if (successionRelationMember == null)
            {
                return NotFound();
            }

            return successionRelationMember;
        }

        // PUT: api/SuccessionRelationMember/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionRelationMember(int id, SuccessionRelationMember successionRelationMember)
        {
            if (id != successionRelationMember.Id)
            {
                return BadRequest();
            }

            _context.Entry(successionRelationMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionRelationMemberExists(id))
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

        // POST: api/SuccessionRelationMember
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionRelationMember>> PostSuccessionRelationMember(SuccessionRelationMember successionRelationMember)
        {
            _context.SuccessionRelationMembers.Add(successionRelationMember);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionRelationMemberExists(successionRelationMember.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionRelationMember", new { id = successionRelationMember.Id }, successionRelationMember);
        }

        // DELETE: api/SuccessionRelationMember/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionRelationMember(int id)
        {
            var successionRelationMember = await _context.SuccessionRelationMembers.FindAsync(id);
            if (successionRelationMember == null)
            {
                return NotFound();
            }

            _context.SuccessionRelationMembers.Remove(successionRelationMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionRelationMemberExists(int id)
        {
            return _context.SuccessionRelationMembers.Any(e => e.Id == id);
        }
    }
}
