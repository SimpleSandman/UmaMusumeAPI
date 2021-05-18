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
    public class ChampionsStandMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsStandMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsStandMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsStandMotion>>> GetChampionsStandMotions()
        {
            return await _context.ChampionsStandMotions.ToListAsync();
        }

        // GET: api/ChampionsStandMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsStandMotion>> GetChampionsStandMotion(int id)
        {
            var championsStandMotion = await _context.ChampionsStandMotions.FindAsync(id);

            if (championsStandMotion == null)
            {
                return NotFound();
            }

            return championsStandMotion;
        }

        // PUT: api/ChampionsStandMotion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsStandMotion(int id, ChampionsStandMotion championsStandMotion)
        {
            if (id != championsStandMotion.CharaId)
            {
                return BadRequest();
            }

            _context.Entry(championsStandMotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsStandMotionExists(id))
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

        // POST: api/ChampionsStandMotion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsStandMotion>> PostChampionsStandMotion(ChampionsStandMotion championsStandMotion)
        {
            _context.ChampionsStandMotions.Add(championsStandMotion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsStandMotionExists(championsStandMotion.CharaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsStandMotion", new { id = championsStandMotion.CharaId }, championsStandMotion);
        }

        // DELETE: api/ChampionsStandMotion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsStandMotion(int id)
        {
            var championsStandMotion = await _context.ChampionsStandMotions.FindAsync(id);
            if (championsStandMotion == null)
            {
                return NotFound();
            }

            _context.ChampionsStandMotions.Remove(championsStandMotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsStandMotionExists(int id)
        {
            return _context.ChampionsStandMotions.Any(e => e.CharaId == id);
        }
    }
}
