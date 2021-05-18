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
    public class SingleModeRouteRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRouteRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRouteRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRouteRace>>> GetSingleModeRouteRaces()
        {
            return await _context.SingleModeRouteRaces.ToListAsync();
        }

        // GET: api/SingleModeRouteRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRouteRace>> GetSingleModeRouteRace(int id)
        {
            var singleModeRouteRace = await _context.SingleModeRouteRaces.FindAsync(id);

            if (singleModeRouteRace == null)
            {
                return NotFound();
            }

            return singleModeRouteRace;
        }

        // PUT: api/SingleModeRouteRace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRouteRace(int id, SingleModeRouteRace singleModeRouteRace)
        {
            if (id != singleModeRouteRace.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRouteRace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRouteRaceExists(id))
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

        // POST: api/SingleModeRouteRace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRouteRace>> PostSingleModeRouteRace(SingleModeRouteRace singleModeRouteRace)
        {
            _context.SingleModeRouteRaces.Add(singleModeRouteRace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRouteRaceExists(singleModeRouteRace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRouteRace", new { id = singleModeRouteRace.Id }, singleModeRouteRace);
        }

        // DELETE: api/SingleModeRouteRace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRouteRace(int id)
        {
            var singleModeRouteRace = await _context.SingleModeRouteRaces.FindAsync(id);
            if (singleModeRouteRace == null)
            {
                return NotFound();
            }

            _context.SingleModeRouteRaces.Remove(singleModeRouteRace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRouteRaceExists(int id)
        {
            return _context.SingleModeRouteRaces.Any(e => e.Id == id);
        }
    }
}
