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
    public class MobDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobData>>> GetMobData()
        {
            return await _context.MobData.ToListAsync();
        }

        // GET: api/MobData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobData>> GetMobData(int id)
        {
            var mobData = await _context.MobData.FindAsync(id);

            if (mobData == null)
            {
                return NotFound();
            }

            return mobData;
        }

        // PUT: api/MobData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobData(int id, MobData mobData)
        {
            if (id != mobData.MobId)
            {
                return BadRequest();
            }

            _context.Entry(mobData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobDataExists(id))
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

        // POST: api/MobData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MobData>> PostMobData(MobData mobData)
        {
            _context.MobData.Add(mobData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MobDataExists(mobData.MobId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMobData", new { id = mobData.MobId }, mobData);
        }

        // DELETE: api/MobData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMobData(int id)
        {
            var mobData = await _context.MobData.FindAsync(id);
            if (mobData == null)
            {
                return NotFound();
            }

            _context.MobData.Remove(mobData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MobDataExists(int id)
        {
            return _context.MobData.Any(e => e.MobId == id);
        }
    }
}
