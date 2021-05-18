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
    public class SingleModeDifficultyDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyData>>> GetSingleModeDifficultyData()
        {
            return await _context.SingleModeDifficultyData.ToListAsync();
        }

        // GET: api/SingleModeDifficultyData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyData>> GetSingleModeDifficultyData(int id)
        {
            var singleModeDifficultyData = await _context.SingleModeDifficultyData.FindAsync(id);

            if (singleModeDifficultyData == null)
            {
                return NotFound();
            }

            return singleModeDifficultyData;
        }

        // PUT: api/SingleModeDifficultyData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeDifficultyData(int id, SingleModeDifficultyData singleModeDifficultyData)
        {
            if (id != singleModeDifficultyData.DifficultyId)
            {
                return BadRequest();
            }

            _context.Entry(singleModeDifficultyData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeDifficultyDataExists(id))
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

        // POST: api/SingleModeDifficultyData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeDifficultyData>> PostSingleModeDifficultyData(SingleModeDifficultyData singleModeDifficultyData)
        {
            _context.SingleModeDifficultyData.Add(singleModeDifficultyData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeDifficultyDataExists(singleModeDifficultyData.DifficultyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeDifficultyData", new { id = singleModeDifficultyData.DifficultyId }, singleModeDifficultyData);
        }

        // DELETE: api/SingleModeDifficultyData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeDifficultyData(int id)
        {
            var singleModeDifficultyData = await _context.SingleModeDifficultyData.FindAsync(id);
            if (singleModeDifficultyData == null)
            {
                return NotFound();
            }

            _context.SingleModeDifficultyData.Remove(singleModeDifficultyData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeDifficultyDataExists(int id)
        {
            return _context.SingleModeDifficultyData.Any(e => e.DifficultyId == id);
        }
    }
}
