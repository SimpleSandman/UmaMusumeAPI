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
    public class LiveDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LiveDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LiveData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LiveData>>> GetLiveData()
        {
            return await _context.LiveData.ToListAsync();
        }

        // GET: api/LiveData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LiveData>> GetLiveData(int id)
        {
            var liveData = await _context.LiveData.FindAsync(id);

            if (liveData == null)
            {
                return NotFound();
            }

            return liveData;
        }

        // PUT: api/LiveData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLiveData(int id, LiveData liveData)
        {
            if (id != liveData.MusicId)
            {
                return BadRequest();
            }

            _context.Entry(liveData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveDataExists(id))
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

        // POST: api/LiveData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LiveData>> PostLiveData(LiveData liveData)
        {
            _context.LiveData.Add(liveData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LiveDataExists(liveData.MusicId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLiveData", new { id = liveData.MusicId }, liveData);
        }

        // DELETE: api/LiveData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLiveData(int id)
        {
            var liveData = await _context.LiveData.FindAsync(id);
            if (liveData == null)
            {
                return NotFound();
            }

            _context.LiveData.Remove(liveData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LiveDataExists(int id)
        {
            return _context.LiveData.Any(e => e.MusicId == id);
        }
    }
}
