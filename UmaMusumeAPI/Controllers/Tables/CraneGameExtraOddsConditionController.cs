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
    public class CraneGameExtraOddsConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameExtraOddsConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameExtraOddsCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameExtraOddsCondition>>> GetCraneGameExtraOddsConditions()
        {
            return await _context.CraneGameExtraOddsConditions.ToListAsync();
        }

        // GET: api/CraneGameExtraOddsCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameExtraOddsCondition>> GetCraneGameExtraOddsCondition(int id)
        {
            var craneGameExtraOddsCondition = await _context.CraneGameExtraOddsConditions.FindAsync(id);

            if (craneGameExtraOddsCondition == null)
            {
                return NotFound();
            }

            return craneGameExtraOddsCondition;
        }

        // PUT: api/CraneGameExtraOddsCondition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameExtraOddsCondition(int id, CraneGameExtraOddsCondition craneGameExtraOddsCondition)
        {
            if (id != craneGameExtraOddsCondition.Credit)
            {
                return BadRequest();
            }

            _context.Entry(craneGameExtraOddsCondition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGameExtraOddsConditionExists(id))
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

        // POST: api/CraneGameExtraOddsCondition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameExtraOddsCondition>> PostCraneGameExtraOddsCondition(CraneGameExtraOddsCondition craneGameExtraOddsCondition)
        {
            _context.CraneGameExtraOddsConditions.Add(craneGameExtraOddsCondition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGameExtraOddsConditionExists(craneGameExtraOddsCondition.Credit))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameExtraOddsCondition", new { id = craneGameExtraOddsCondition.Credit }, craneGameExtraOddsCondition);
        }

        // DELETE: api/CraneGameExtraOddsCondition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameExtraOddsCondition(int id)
        {
            var craneGameExtraOddsCondition = await _context.CraneGameExtraOddsConditions.FindAsync(id);
            if (craneGameExtraOddsCondition == null)
            {
                return NotFound();
            }

            _context.CraneGameExtraOddsConditions.Remove(craneGameExtraOddsCondition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGameExtraOddsConditionExists(int id)
        {
            return _context.CraneGameExtraOddsConditions.Any(e => e.Credit == id);
        }
    }
}
