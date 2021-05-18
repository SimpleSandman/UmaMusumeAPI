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
    public class ChampionsRaceConditionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRaceConditionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRaceCondition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRaceCondition>>> GetChampionsRaceConditions()
        {
            return await _context.ChampionsRaceConditions.ToListAsync();
        }

        // GET: api/ChampionsRaceCondition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRaceCondition>> GetChampionsRaceCondition(int id)
        {
            var championsRaceCondition = await _context.ChampionsRaceConditions.FindAsync(id);

            if (championsRaceCondition == null)
            {
                return NotFound();
            }

            return championsRaceCondition;
        }

        // PUT: api/ChampionsRaceCondition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsRaceCondition(int id, ChampionsRaceCondition championsRaceCondition)
        {
            if (id != championsRaceCondition.ChampionsId)
            {
                return BadRequest();
            }

            _context.Entry(championsRaceCondition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsRaceConditionExists(id))
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

        // POST: api/ChampionsRaceCondition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsRaceCondition>> PostChampionsRaceCondition(ChampionsRaceCondition championsRaceCondition)
        {
            _context.ChampionsRaceConditions.Add(championsRaceCondition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsRaceConditionExists(championsRaceCondition.ChampionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsRaceCondition", new { id = championsRaceCondition.ChampionsId }, championsRaceCondition);
        }

        // DELETE: api/ChampionsRaceCondition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsRaceCondition(int id)
        {
            var championsRaceCondition = await _context.ChampionsRaceConditions.FindAsync(id);
            if (championsRaceCondition == null)
            {
                return NotFound();
            }

            _context.ChampionsRaceConditions.Remove(championsRaceCondition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsRaceConditionExists(int id)
        {
            return _context.ChampionsRaceConditions.Any(e => e.ChampionsId == id);
        }
    }
}
