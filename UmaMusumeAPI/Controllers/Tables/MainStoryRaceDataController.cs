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
    public class MainStoryRaceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceData>>> GetMainStoryRaceData()
        {
            return await _context.MainStoryRaceData.ToListAsync();
        }

        // GET: api/MainStoryRaceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceData>> GetMainStoryRaceData(int id)
        {
            var mainStoryRaceData = await _context.MainStoryRaceData.FindAsync(id);

            if (mainStoryRaceData == null)
            {
                return NotFound();
            }

            return mainStoryRaceData;
        }

        // PUT: api/MainStoryRaceData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainStoryRaceData(int id, MainStoryRaceData mainStoryRaceData)
        {
            if (id != mainStoryRaceData.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainStoryRaceData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainStoryRaceDataExists(id))
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

        // POST: api/MainStoryRaceData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MainStoryRaceData>> PostMainStoryRaceData(MainStoryRaceData mainStoryRaceData)
        {
            _context.MainStoryRaceData.Add(mainStoryRaceData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MainStoryRaceDataExists(mainStoryRaceData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMainStoryRaceData", new { id = mainStoryRaceData.Id }, mainStoryRaceData);
        }

        // DELETE: api/MainStoryRaceData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainStoryRaceData(int id)
        {
            var mainStoryRaceData = await _context.MainStoryRaceData.FindAsync(id);
            if (mainStoryRaceData == null)
            {
                return NotFound();
            }

            _context.MainStoryRaceData.Remove(mainStoryRaceData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainStoryRaceDataExists(int id)
        {
            return _context.MainStoryRaceData.Any(e => e.Id == id);
        }
    }
}
