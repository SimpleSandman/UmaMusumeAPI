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
    public class RaceConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceCondition>>> GetRaceConditions()
        {
            return await _context.RaceConditions.ToListAsync();
        }

        // GET: api/RaceCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceCondition>> GetRaceCondition(int id)
        {
            var raceCondition = await _context.RaceConditions.FindAsync(id);

            if (raceCondition == null)
            {
                return NotFound();
            }

            return raceCondition;
        }

        // PUT: api/RaceCondition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceCondition(int id, RaceCondition raceCondition)
        {
            if (id != raceCondition.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceCondition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceConditionExists(id))
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

        // POST: api/RaceCondition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceCondition>> PostRaceCondition(RaceCondition raceCondition)
        {
            _context.RaceConditions.Add(raceCondition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceConditionExists(raceCondition.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceCondition", new { id = raceCondition.Id }, raceCondition);
        }

        // DELETE: api/RaceCondition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceCondition(int id)
        {
            var raceCondition = await _context.RaceConditions.FindAsync(id);
            if (raceCondition == null)
            {
                return NotFound();
            }

            _context.RaceConditions.Remove(raceCondition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceConditionExists(int id)
        {
            return _context.RaceConditions.Any(e => e.Id == id);
        }
    }
}
