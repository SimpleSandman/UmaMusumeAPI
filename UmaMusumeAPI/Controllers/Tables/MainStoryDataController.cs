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
    public class MainStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryData>>> GetMainStoryData()
        {
            return await _context.MainStoryData.ToListAsync();
        }

        // GET: api/MainStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryData>> GetMainStoryData(int id)
        {
            var mainStoryData = await _context.MainStoryData.FindAsync(id);

            if (mainStoryData == null)
            {
                return NotFound();
            }

            return mainStoryData;
        }

        // PUT: api/MainStoryData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainStoryData(int id, MainStoryData mainStoryData)
        {
            if (id != mainStoryData.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainStoryData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainStoryDataExists(id))
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

        // POST: api/MainStoryData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MainStoryData>> PostMainStoryData(MainStoryData mainStoryData)
        {
            _context.MainStoryData.Add(mainStoryData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MainStoryDataExists(mainStoryData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMainStoryData", new { id = mainStoryData.Id }, mainStoryData);
        }

        // DELETE: api/MainStoryData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainStoryData(int id)
        {
            var mainStoryData = await _context.MainStoryData.FindAsync(id);
            if (mainStoryData == null)
            {
                return NotFound();
            }

            _context.MainStoryData.Remove(mainStoryData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainStoryDataExists(int id)
        {
            return _context.MainStoryData.Any(e => e.Id == id);
        }
    }
}
