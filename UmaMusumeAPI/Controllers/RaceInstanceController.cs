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
    public class RaceInstanceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceInstanceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceInstance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceInstance>>> GetRaceInstances()
        {
            return await _context.RaceInstances.ToListAsync();
        }

        // GET: api/RaceInstance/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceInstance>> GetRaceInstance(int id)
        {
            var raceInstance = await _context.RaceInstances.FindAsync(id);

            if (raceInstance == null)
            {
                return NotFound();
            }

            return raceInstance;
        }

        // PUT: api/RaceInstance/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceInstance(int id, RaceInstance raceInstance)
        {
            if (id != raceInstance.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceInstance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceInstanceExists(id))
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

        // POST: api/RaceInstance
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceInstance>> PostRaceInstance(RaceInstance raceInstance)
        {
            _context.RaceInstances.Add(raceInstance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceInstanceExists(raceInstance.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceInstance", new { id = raceInstance.Id }, raceInstance);
        }

        // DELETE: api/RaceInstance/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceInstance(int id)
        {
            var raceInstance = await _context.RaceInstances.FindAsync(id);
            if (raceInstance == null)
            {
                return NotFound();
            }

            _context.RaceInstances.Remove(raceInstance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceInstanceExists(int id)
        {
            return _context.RaceInstances.Any(e => e.Id == id);
        }
    }
}
