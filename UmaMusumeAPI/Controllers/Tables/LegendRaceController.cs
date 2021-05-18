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
    public class LegendRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRace>>> GetLegendRaces()
        {
            return await _context.LegendRaces.ToListAsync();
        }

        // GET: api/LegendRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRace>> GetLegendRace(int id)
        {
            var legendRace = await _context.LegendRaces.FindAsync(id);

            if (legendRace == null)
            {
                return NotFound();
            }

            return legendRace;
        }

        // PUT: api/LegendRace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegendRace(int id, LegendRace legendRace)
        {
            if (id != legendRace.Id)
            {
                return BadRequest();
            }

            _context.Entry(legendRace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegendRaceExists(id))
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

        // POST: api/LegendRace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LegendRace>> PostLegendRace(LegendRace legendRace)
        {
            _context.LegendRaces.Add(legendRace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LegendRaceExists(legendRace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLegendRace", new { id = legendRace.Id }, legendRace);
        }

        // DELETE: api/LegendRace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegendRace(int id)
        {
            var legendRace = await _context.LegendRaces.FindAsync(id);
            if (legendRace == null)
            {
                return NotFound();
            }

            _context.LegendRaces.Remove(legendRace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegendRaceExists(int id)
        {
            return _context.LegendRaces.Any(e => e.Id == id);
        }
    }
}
