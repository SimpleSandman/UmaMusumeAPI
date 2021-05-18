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
    public class CircleStampDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CircleStampDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CircleStampData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CircleStampData>>> GetCircleStampData()
        {
            return await _context.CircleStampData.ToListAsync();
        }

        // GET: api/CircleStampData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CircleStampData>> GetCircleStampData(int id)
        {
            var circleStampData = await _context.CircleStampData.FindAsync(id);

            if (circleStampData == null)
            {
                return NotFound();
            }

            return circleStampData;
        }

        // PUT: api/CircleStampData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCircleStampData(int id, CircleStampData circleStampData)
        {
            if (id != circleStampData.Id)
            {
                return BadRequest();
            }

            _context.Entry(circleStampData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CircleStampDataExists(id))
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

        // POST: api/CircleStampData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CircleStampData>> PostCircleStampData(CircleStampData circleStampData)
        {
            _context.CircleStampData.Add(circleStampData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CircleStampDataExists(circleStampData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCircleStampData", new { id = circleStampData.Id }, circleStampData);
        }

        // DELETE: api/CircleStampData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCircleStampData(int id)
        {
            var circleStampData = await _context.CircleStampData.FindAsync(id);
            if (circleStampData == null)
            {
                return NotFound();
            }

            _context.CircleStampData.Remove(circleStampData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CircleStampDataExists(int id)
        {
            return _context.CircleStampData.Any(e => e.Id == id);
        }
    }
}
