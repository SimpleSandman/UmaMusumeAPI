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
    public class ChampionsBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsBgm>>> GetChampionsBgms()
        {
            return await _context.ChampionsBgms.ToListAsync();
        }

        // GET: api/ChampionsBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsBgm>> GetChampionsBgm(int id)
        {
            var championsBgm = await _context.ChampionsBgms.FindAsync(id);

            if (championsBgm == null)
            {
                return NotFound();
            }

            return championsBgm;
        }

        // PUT: api/ChampionsBgm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsBgm(int id, ChampionsBgm championsBgm)
        {
            if (id != championsBgm.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsBgm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsBgmExists(id))
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

        // POST: api/ChampionsBgm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsBgm>> PostChampionsBgm(ChampionsBgm championsBgm)
        {
            _context.ChampionsBgms.Add(championsBgm);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsBgmExists(championsBgm.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsBgm", new { id = championsBgm.Id }, championsBgm);
        }

        // DELETE: api/ChampionsBgm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsBgm(int id)
        {
            var championsBgm = await _context.ChampionsBgms.FindAsync(id);
            if (championsBgm == null)
            {
                return NotFound();
            }

            _context.ChampionsBgms.Remove(championsBgm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsBgmExists(int id)
        {
            return _context.ChampionsBgms.Any(e => e.Id == id);
        }
    }
}
