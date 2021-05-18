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
    public class SingleModeStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeStoryData>>> GetSingleModeStoryData()
        {
            return await _context.SingleModeStoryData.ToListAsync();
        }

        // GET: api/SingleModeStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeStoryData>> GetSingleModeStoryData(int id)
        {
            var singleModeStoryData = await _context.SingleModeStoryData.FindAsync(id);

            if (singleModeStoryData == null)
            {
                return NotFound();
            }

            return singleModeStoryData;
        }

        // PUT: api/SingleModeStoryData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeStoryData(int id, SingleModeStoryData singleModeStoryData)
        {
            if (id != singleModeStoryData.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeStoryData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeStoryDataExists(id))
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

        // POST: api/SingleModeStoryData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeStoryData>> PostSingleModeStoryData(SingleModeStoryData singleModeStoryData)
        {
            _context.SingleModeStoryData.Add(singleModeStoryData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeStoryDataExists(singleModeStoryData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeStoryData", new { id = singleModeStoryData.Id }, singleModeStoryData);
        }

        // DELETE: api/SingleModeStoryData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeStoryData(int id)
        {
            var singleModeStoryData = await _context.SingleModeStoryData.FindAsync(id);
            if (singleModeStoryData == null)
            {
                return NotFound();
            }

            _context.SingleModeStoryData.Remove(singleModeStoryData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeStoryDataExists(int id)
        {
            return _context.SingleModeStoryData.Any(e => e.Id == id);
        }
    }
}
