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
    public class AnnounceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceData>>> GetAnnounceData()
        {
            return await _context.AnnounceData.ToListAsync();
        }

        // GET: api/AnnounceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceData>> GetAnnounceData(int id)
        {
            var announceData = await _context.AnnounceData.FindAsync(id);

            if (announceData == null)
            {
                return NotFound();
            }

            return announceData;
        }

        // PUT: api/AnnounceData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnnounceData(int id, AnnounceData announceData)
        {
            if (id != announceData.Id)
            {
                return BadRequest();
            }

            _context.Entry(announceData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnnounceDataExists(id))
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

        // POST: api/AnnounceData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnnounceData>> PostAnnounceData(AnnounceData announceData)
        {
            _context.AnnounceData.Add(announceData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnnounceDataExists(announceData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnnounceData", new { id = announceData.Id }, announceData);
        }

        // DELETE: api/AnnounceData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnounceData(int id)
        {
            var announceData = await _context.AnnounceData.FindAsync(id);
            if (announceData == null)
            {
                return NotFound();
            }

            _context.AnnounceData.Remove(announceData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnnounceDataExists(int id)
        {
            return _context.AnnounceData.Any(e => e.Id == id);
        }
    }
}
