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
    public class EventMotionPlusDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public EventMotionPlusDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/EventMotionPlusData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventMotionPlusData>>> GetEventMotionPlusData()
        {
            return await _context.EventMotionPlusData.ToListAsync();
        }

        // GET: api/EventMotionPlusData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventMotionPlusData>> GetEventMotionPlusData(int id)
        {
            var eventMotionPlusData = await _context.EventMotionPlusData.FindAsync(id);

            if (eventMotionPlusData == null)
            {
                return NotFound();
            }

            return eventMotionPlusData;
        }

        // PUT: api/EventMotionPlusData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventMotionPlusData(int id, EventMotionPlusData eventMotionPlusData)
        {
            if (id != eventMotionPlusData.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventMotionPlusData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventMotionPlusDataExists(id))
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

        // POST: api/EventMotionPlusData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventMotionPlusData>> PostEventMotionPlusData(EventMotionPlusData eventMotionPlusData)
        {
            _context.EventMotionPlusData.Add(eventMotionPlusData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventMotionPlusDataExists(eventMotionPlusData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEventMotionPlusData", new { id = eventMotionPlusData.Id }, eventMotionPlusData);
        }

        // DELETE: api/EventMotionPlusData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventMotionPlusData(int id)
        {
            var eventMotionPlusData = await _context.EventMotionPlusData.FindAsync(id);
            if (eventMotionPlusData == null)
            {
                return NotFound();
            }

            _context.EventMotionPlusData.Remove(eventMotionPlusData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventMotionPlusDataExists(int id)
        {
            return _context.EventMotionPlusData.Any(e => e.Id == id);
        }
    }
}
