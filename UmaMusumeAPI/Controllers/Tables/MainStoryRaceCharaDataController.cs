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
    public class MainStoryRaceCharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceCharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceCharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceCharaData>>> GetMainStoryRaceCharaData()
        {
            return await _context.MainStoryRaceCharaData.ToListAsync();
        }

        // GET: api/MainStoryRaceCharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceCharaData>> GetMainStoryRaceCharaData(int id)
        {
            var mainStoryRaceCharaData = await _context.MainStoryRaceCharaData.FindAsync(id);

            if (mainStoryRaceCharaData == null)
            {
                return NotFound();
            }

            return mainStoryRaceCharaData;
        }

        // PUT: api/MainStoryRaceCharaData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainStoryRaceCharaData(int id, MainStoryRaceCharaData mainStoryRaceCharaData)
        {
            if (id != mainStoryRaceCharaData.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainStoryRaceCharaData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainStoryRaceCharaDataExists(id))
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

        // POST: api/MainStoryRaceCharaData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MainStoryRaceCharaData>> PostMainStoryRaceCharaData(MainStoryRaceCharaData mainStoryRaceCharaData)
        {
            _context.MainStoryRaceCharaData.Add(mainStoryRaceCharaData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MainStoryRaceCharaDataExists(mainStoryRaceCharaData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMainStoryRaceCharaData", new { id = mainStoryRaceCharaData.Id }, mainStoryRaceCharaData);
        }

        // DELETE: api/MainStoryRaceCharaData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainStoryRaceCharaData(int id)
        {
            var mainStoryRaceCharaData = await _context.MainStoryRaceCharaData.FindAsync(id);
            if (mainStoryRaceCharaData == null)
            {
                return NotFound();
            }

            _context.MainStoryRaceCharaData.Remove(mainStoryRaceCharaData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainStoryRaceCharaDataExists(int id)
        {
            return _context.MainStoryRaceCharaData.Any(e => e.Id == id);
        }
    }
}
