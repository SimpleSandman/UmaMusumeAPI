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
    public class ChampionsRoundScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRoundScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRoundSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRoundSchedule>>> GetChampionsRoundSchedules()
        {
            return await _context.ChampionsRoundSchedules.ToListAsync();
        }

        // GET: api/ChampionsRoundSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRoundSchedule>> GetChampionsRoundSchedule(int id)
        {
            var championsRoundSchedule = await _context.ChampionsRoundSchedules.FindAsync(id);

            if (championsRoundSchedule == null)
            {
                return NotFound();
            }

            return championsRoundSchedule;
        }

        // PUT: api/ChampionsRoundSchedule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsRoundSchedule(int id, ChampionsRoundSchedule championsRoundSchedule)
        {
            if (id != championsRoundSchedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsRoundSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsRoundScheduleExists(id))
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

        // POST: api/ChampionsRoundSchedule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsRoundSchedule>> PostChampionsRoundSchedule(ChampionsRoundSchedule championsRoundSchedule)
        {
            _context.ChampionsRoundSchedules.Add(championsRoundSchedule);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsRoundScheduleExists(championsRoundSchedule.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsRoundSchedule", new { id = championsRoundSchedule.Id }, championsRoundSchedule);
        }

        // DELETE: api/ChampionsRoundSchedule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsRoundSchedule(int id)
        {
            var championsRoundSchedule = await _context.ChampionsRoundSchedules.FindAsync(id);
            if (championsRoundSchedule == null)
            {
                return NotFound();
            }

            _context.ChampionsRoundSchedules.Remove(championsRoundSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsRoundScheduleExists(int id)
        {
            return _context.ChampionsRoundSchedules.Any(e => e.Id == id);
        }
    }
}
