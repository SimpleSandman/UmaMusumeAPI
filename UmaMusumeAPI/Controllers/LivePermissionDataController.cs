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
    public class LivePermissionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LivePermissionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LivePermissionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivePermissionData>>> GetLivePermissionData()
        {
            return await _context.LivePermissionData.ToListAsync();
        }

        // GET: api/LivePermissionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LivePermissionData>> GetLivePermissionData(int id)
        {
            var livePermissionData = await _context.LivePermissionData.FindAsync(id);

            if (livePermissionData == null)
            {
                return NotFound();
            }

            return livePermissionData;
        }

        // PUT: api/LivePermissionData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivePermissionData(int id, LivePermissionData livePermissionData)
        {
            if (id != livePermissionData.MusicId)
            {
                return BadRequest();
            }

            _context.Entry(livePermissionData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivePermissionDataExists(id))
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

        // POST: api/LivePermissionData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LivePermissionData>> PostLivePermissionData(LivePermissionData livePermissionData)
        {
            _context.LivePermissionData.Add(livePermissionData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LivePermissionDataExists(livePermissionData.MusicId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLivePermissionData", new { id = livePermissionData.MusicId }, livePermissionData);
        }

        // DELETE: api/LivePermissionData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivePermissionData(int id)
        {
            var livePermissionData = await _context.LivePermissionData.FindAsync(id);
            if (livePermissionData == null)
            {
                return NotFound();
            }

            _context.LivePermissionData.Remove(livePermissionData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LivePermissionDataExists(int id)
        {
            return _context.LivePermissionData.Any(e => e.MusicId == id);
        }
    }
}
