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
    public class RaceEnvDefineController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceEnvDefineController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceEnvDefine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceEnvDefine>>> GetRaceEnvDefines()
        {
            return await _context.RaceEnvDefines.ToListAsync();
        }

        // GET: api/RaceEnvDefine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceEnvDefine>> GetRaceEnvDefine(int id)
        {
            var raceEnvDefine = await _context.RaceEnvDefines.FindAsync(id);

            if (raceEnvDefine == null)
            {
                return NotFound();
            }

            return raceEnvDefine;
        }

        // PUT: api/RaceEnvDefine/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceEnvDefine(int id, RaceEnvDefine raceEnvDefine)
        {
            if (id != raceEnvDefine.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceEnvDefine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceEnvDefineExists(id))
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

        // POST: api/RaceEnvDefine
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceEnvDefine>> PostRaceEnvDefine(RaceEnvDefine raceEnvDefine)
        {
            _context.RaceEnvDefines.Add(raceEnvDefine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceEnvDefineExists(raceEnvDefine.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceEnvDefine", new { id = raceEnvDefine.Id }, raceEnvDefine);
        }

        // DELETE: api/RaceEnvDefine/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceEnvDefine(int id)
        {
            var raceEnvDefine = await _context.RaceEnvDefines.FindAsync(id);
            if (raceEnvDefine == null)
            {
                return NotFound();
            }

            _context.RaceEnvDefines.Remove(raceEnvDefine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceEnvDefineExists(int id)
        {
            return _context.RaceEnvDefines.Any(e => e.Id == id);
        }
    }
}
