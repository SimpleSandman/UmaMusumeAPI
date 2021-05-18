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
    public class ChampionsScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsSchedule>>> GetChampionsSchedules()
        {
            return await _context.ChampionsSchedules.ToListAsync();
        }

        // GET: api/ChampionsSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsSchedule>> GetChampionsSchedule(int id)
        {
            var championsSchedule = await _context.ChampionsSchedules.FindAsync(id);

            if (championsSchedule == null)
            {
                return NotFound();
            }

            return championsSchedule;
        }

        // PUT: api/ChampionsSchedule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsSchedule(int id, ChampionsSchedule championsSchedule)
        {
            if (id != championsSchedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsScheduleExists(id))
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

        // POST: api/ChampionsSchedule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsSchedule>> PostChampionsSchedule(ChampionsSchedule championsSchedule)
        {
            _context.ChampionsSchedules.Add(championsSchedule);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsScheduleExists(championsSchedule.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsSchedule", new { id = championsSchedule.Id }, championsSchedule);
        }

        // DELETE: api/ChampionsSchedule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsSchedule(int id)
        {
            var championsSchedule = await _context.ChampionsSchedules.FindAsync(id);
            if (championsSchedule == null)
            {
                return NotFound();
            }

            _context.ChampionsSchedules.Remove(championsSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsScheduleExists(int id)
        {
            return _context.ChampionsSchedules.Any(e => e.Id == id);
        }
    }
}
