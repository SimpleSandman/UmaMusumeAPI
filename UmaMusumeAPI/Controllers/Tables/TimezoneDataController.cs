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
    public class TimezoneDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TimezoneDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TimezoneData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimezoneData>>> GetTimezoneData()
        {
            return await _context.TimezoneData.ToListAsync();
        }

        // GET: api/TimezoneData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimezoneData>> GetTimezoneData(int id)
        {
            var timezoneData = await _context.TimezoneData.FindAsync(id);

            if (timezoneData == null)
            {
                return NotFound();
            }

            return timezoneData;
        }

        // PUT: api/TimezoneData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimezoneData(int id, TimezoneData timezoneData)
        {
            if (id != timezoneData.Timezone)
            {
                return BadRequest();
            }

            _context.Entry(timezoneData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimezoneDataExists(id))
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

        // POST: api/TimezoneData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TimezoneData>> PostTimezoneData(TimezoneData timezoneData)
        {
            _context.TimezoneData.Add(timezoneData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TimezoneDataExists(timezoneData.Timezone))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTimezoneData", new { id = timezoneData.Timezone }, timezoneData);
        }

        // DELETE: api/TimezoneData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimezoneData(int id)
        {
            var timezoneData = await _context.TimezoneData.FindAsync(id);
            if (timezoneData == null)
            {
                return NotFound();
            }

            _context.TimezoneData.Remove(timezoneData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TimezoneDataExists(int id)
        {
            return _context.TimezoneData.Any(e => e.Timezone == id);
        }
    }
}
