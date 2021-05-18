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
    public class CircleRankDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CircleRankDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CircleRankData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CircleRankData>>> GetCircleRankData()
        {
            return await _context.CircleRankData.ToListAsync();
        }

        // GET: api/CircleRankData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CircleRankData>> GetCircleRankData(int id)
        {
            var circleRankData = await _context.CircleRankData.FindAsync(id);

            if (circleRankData == null)
            {
                return NotFound();
            }

            return circleRankData;
        }

        // PUT: api/CircleRankData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCircleRankData(int id, CircleRankData circleRankData)
        {
            if (id != circleRankData.Id)
            {
                return BadRequest();
            }

            _context.Entry(circleRankData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CircleRankDataExists(id))
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

        // POST: api/CircleRankData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CircleRankData>> PostCircleRankData(CircleRankData circleRankData)
        {
            _context.CircleRankData.Add(circleRankData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CircleRankDataExists(circleRankData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCircleRankData", new { id = circleRankData.Id }, circleRankData);
        }

        // DELETE: api/CircleRankData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCircleRankData(int id)
        {
            var circleRankData = await _context.CircleRankData.FindAsync(id);
            if (circleRankData == null)
            {
                return NotFound();
            }

            _context.CircleRankData.Remove(circleRankData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CircleRankDataExists(int id)
        {
            return _context.CircleRankData.Any(e => e.Id == id);
        }
    }
}
