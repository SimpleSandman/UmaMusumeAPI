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
    public class MissionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MissionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MissionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MissionData>>> GetMissionData()
        {
            return await _context.MissionData.ToListAsync();
        }

        // GET: api/MissionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MissionData>> GetMissionData(int id)
        {
            var missionData = await _context.MissionData.FindAsync(id);

            if (missionData == null)
            {
                return NotFound();
            }

            return missionData;
        }

        // PUT: api/MissionData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMissionData(int id, MissionData missionData)
        {
            if (id != missionData.Id)
            {
                return BadRequest();
            }

            _context.Entry(missionData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MissionDataExists(id))
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

        // POST: api/MissionData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MissionData>> PostMissionData(MissionData missionData)
        {
            _context.MissionData.Add(missionData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MissionDataExists(missionData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMissionData", new { id = missionData.Id }, missionData);
        }

        // DELETE: api/MissionData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMissionData(int id)
        {
            var missionData = await _context.MissionData.FindAsync(id);
            if (missionData == null)
            {
                return NotFound();
            }

            _context.MissionData.Remove(missionData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MissionDataExists(int id)
        {
            return _context.MissionData.Any(e => e.Id == id);
        }
    }
}
