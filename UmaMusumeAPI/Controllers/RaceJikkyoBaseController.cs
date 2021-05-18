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
    public class RaceJikkyoBaseController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoBaseController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoBase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoBase>>> GetRaceJikkyoBases()
        {
            return await _context.RaceJikkyoBases.ToListAsync();
        }

        // GET: api/RaceJikkyoBase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoBase>> GetRaceJikkyoBase(int id)
        {
            var raceJikkyoBase = await _context.RaceJikkyoBases.FindAsync(id);

            if (raceJikkyoBase == null)
            {
                return NotFound();
            }

            return raceJikkyoBase;
        }

        // PUT: api/RaceJikkyoBase/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoBase(int id, RaceJikkyoBase raceJikkyoBase)
        {
            if (id != raceJikkyoBase.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoBaseExists(id))
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

        // POST: api/RaceJikkyoBase
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoBase>> PostRaceJikkyoBase(RaceJikkyoBase raceJikkyoBase)
        {
            _context.RaceJikkyoBases.Add(raceJikkyoBase);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoBaseExists(raceJikkyoBase.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoBase", new { id = raceJikkyoBase.Id }, raceJikkyoBase);
        }

        // DELETE: api/RaceJikkyoBase/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoBase(int id)
        {
            var raceJikkyoBase = await _context.RaceJikkyoBases.FindAsync(id);
            if (raceJikkyoBase == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoBases.Remove(raceJikkyoBase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoBaseExists(int id)
        {
            return _context.RaceJikkyoBases.Any(e => e.Id == id);
        }
    }
}
