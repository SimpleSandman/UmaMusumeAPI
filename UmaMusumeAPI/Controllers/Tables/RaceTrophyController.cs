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
    public class RaceTrophyController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrophyController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrophy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrophy>>> GetRaceTrophies()
        {
            return await _context.RaceTrophies.ToListAsync();
        }

        // GET: api/RaceTrophy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrophy>> GetRaceTrophy(int id)
        {
            var raceTrophy = await _context.RaceTrophies.FindAsync(id);

            if (raceTrophy == null)
            {
                return NotFound();
            }

            return raceTrophy;
        }

        // PUT: api/RaceTrophy/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceTrophy(int id, RaceTrophy raceTrophy)
        {
            if (id != raceTrophy.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceTrophy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceTrophyExists(id))
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

        // POST: api/RaceTrophy
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceTrophy>> PostRaceTrophy(RaceTrophy raceTrophy)
        {
            _context.RaceTrophies.Add(raceTrophy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceTrophyExists(raceTrophy.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceTrophy", new { id = raceTrophy.Id }, raceTrophy);
        }

        // DELETE: api/RaceTrophy/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceTrophy(int id)
        {
            var raceTrophy = await _context.RaceTrophies.FindAsync(id);
            if (raceTrophy == null)
            {
                return NotFound();
            }

            _context.RaceTrophies.Remove(raceTrophy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceTrophyExists(int id)
        {
            return _context.RaceTrophies.Any(e => e.Id == id);
        }
    }
}
