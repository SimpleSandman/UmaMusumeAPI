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
    public class ChampionsNewsRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsRace>>> GetChampionsNewsRaces()
        {
            return await _context.ChampionsNewsRaces.ToListAsync();
        }

        // GET: api/ChampionsNewsRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsRace>> GetChampionsNewsRace(int id)
        {
            var championsNewsRace = await _context.ChampionsNewsRaces.FindAsync(id);

            if (championsNewsRace == null)
            {
                return NotFound();
            }

            return championsNewsRace;
        }

        // PUT: api/ChampionsNewsRace/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsRace(int id, ChampionsNewsRace championsNewsRace)
        {
            if (id != championsNewsRace.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsRace).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsRaceExists(id))
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

        // POST: api/ChampionsNewsRace
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsRace>> PostChampionsNewsRace(ChampionsNewsRace championsNewsRace)
        {
            _context.ChampionsNewsRaces.Add(championsNewsRace);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsRaceExists(championsNewsRace.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsRace", new { id = championsNewsRace.Id }, championsNewsRace);
        }

        // DELETE: api/ChampionsNewsRace/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsRace(int id)
        {
            var championsNewsRace = await _context.ChampionsNewsRaces.FindAsync(id);
            if (championsNewsRace == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsRaces.Remove(championsNewsRace);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsRaceExists(int id)
        {
            return _context.ChampionsNewsRaces.Any(e => e.Id == id);
        }
    }
}
