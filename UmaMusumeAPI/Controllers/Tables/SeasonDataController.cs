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
    public class SeasonDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SeasonDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SeasonData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeasonData>>> GetSeasonData()
        {
            return await _context.SeasonData.ToListAsync();
        }

        // GET: api/SeasonData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeasonData>> GetSeasonData(int id)
        {
            var seasonData = await _context.SeasonData.FindAsync(id);

            if (seasonData == null)
            {
                return NotFound();
            }

            return seasonData;
        }

        // PUT: api/SeasonData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeasonData(int id, SeasonData seasonData)
        {
            if (id != seasonData.Id)
            {
                return BadRequest();
            }

            _context.Entry(seasonData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeasonDataExists(id))
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

        // POST: api/SeasonData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SeasonData>> PostSeasonData(SeasonData seasonData)
        {
            _context.SeasonData.Add(seasonData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SeasonDataExists(seasonData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSeasonData", new { id = seasonData.Id }, seasonData);
        }

        // DELETE: api/SeasonData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeasonData(int id)
        {
            var seasonData = await _context.SeasonData.FindAsync(id);
            if (seasonData == null)
            {
                return NotFound();
            }

            _context.SeasonData.Remove(seasonData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SeasonDataExists(int id)
        {
            return _context.SeasonData.Any(e => e.Id == id);
        }
    }
}
