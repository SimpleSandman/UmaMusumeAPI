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
    public class DailyRaceNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRaceNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRaceNpc>>> GetDailyRaceNpcs()
        {
            return await _context.DailyRaceNpcs.ToListAsync();
        }

        // GET: api/DailyRaceNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRaceNpc>> GetDailyRaceNpc(int id)
        {
            var dailyRaceNpc = await _context.DailyRaceNpcs.FindAsync(id);

            if (dailyRaceNpc == null)
            {
                return NotFound();
            }

            return dailyRaceNpc;
        }

        // PUT: api/DailyRaceNpc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailyRaceNpc(int id, DailyRaceNpc dailyRaceNpc)
        {
            if (id != dailyRaceNpc.Id)
            {
                return BadRequest();
            }

            _context.Entry(dailyRaceNpc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyRaceNpcExists(id))
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

        // POST: api/DailyRaceNpc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DailyRaceNpc>> PostDailyRaceNpc(DailyRaceNpc dailyRaceNpc)
        {
            _context.DailyRaceNpcs.Add(dailyRaceNpc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DailyRaceNpcExists(dailyRaceNpc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDailyRaceNpc", new { id = dailyRaceNpc.Id }, dailyRaceNpc);
        }

        // DELETE: api/DailyRaceNpc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDailyRaceNpc(int id)
        {
            var dailyRaceNpc = await _context.DailyRaceNpcs.FindAsync(id);
            if (dailyRaceNpc == null)
            {
                return NotFound();
            }

            _context.DailyRaceNpcs.Remove(dailyRaceNpc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DailyRaceNpcExists(int id)
        {
            return _context.DailyRaceNpcs.Any(e => e.Id == id);
        }
    }
}
