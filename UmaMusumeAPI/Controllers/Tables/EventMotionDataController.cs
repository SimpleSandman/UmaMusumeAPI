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
    public class EventMotionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public EventMotionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/EventMotionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventMotionData>>> GetEventMotionData()
        {
            return await _context.EventMotionData.ToListAsync();
        }

        // GET: api/EventMotionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventMotionData>> GetEventMotionData(int id)
        {
            var eventMotionData = await _context.EventMotionData.FindAsync(id);

            if (eventMotionData == null)
            {
                return NotFound();
            }

            return eventMotionData;
        }

        // PUT: api/EventMotionData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventMotionData(int id, EventMotionData eventMotionData)
        {
            if (id != eventMotionData.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventMotionData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventMotionDataExists(id))
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

        // POST: api/EventMotionData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventMotionData>> PostEventMotionData(EventMotionData eventMotionData)
        {
            _context.EventMotionData.Add(eventMotionData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventMotionDataExists(eventMotionData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEventMotionData", new { id = eventMotionData.Id }, eventMotionData);
        }

        // DELETE: api/EventMotionData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventMotionData(int id)
        {
            var eventMotionData = await _context.EventMotionData.FindAsync(id);
            if (eventMotionData == null)
            {
                return NotFound();
            }

            _context.EventMotionData.Remove(eventMotionData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventMotionDataExists(int id)
        {
            return _context.EventMotionData.Any(e => e.Id == id);
        }
    }
}
