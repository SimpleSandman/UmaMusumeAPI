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
    public class SuccessionRelationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelation>>> GetSuccessionRelations()
        {
            return await _context.SuccessionRelations.ToListAsync();
        }

        // GET: api/SuccessionRelation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelation>> GetSuccessionRelation(int id)
        {
            var successionRelation = await _context.SuccessionRelations.FindAsync(id);

            if (successionRelation == null)
            {
                return NotFound();
            }

            return successionRelation;
        }

        // PUT: api/SuccessionRelation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuccessionRelation(int id, SuccessionRelation successionRelation)
        {
            if (id != successionRelation.RelationType)
            {
                return BadRequest();
            }

            _context.Entry(successionRelation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuccessionRelationExists(id))
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

        // POST: api/SuccessionRelation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuccessionRelation>> PostSuccessionRelation(SuccessionRelation successionRelation)
        {
            _context.SuccessionRelations.Add(successionRelation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SuccessionRelationExists(successionRelation.RelationType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSuccessionRelation", new { id = successionRelation.RelationType }, successionRelation);
        }

        // DELETE: api/SuccessionRelation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuccessionRelation(int id)
        {
            var successionRelation = await _context.SuccessionRelations.FindAsync(id);
            if (successionRelation == null)
            {
                return NotFound();
            }

            _context.SuccessionRelations.Remove(successionRelation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuccessionRelationExists(int id)
        {
            return _context.SuccessionRelations.Any(e => e.RelationType == id);
        }
    }
}
