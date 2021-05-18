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
    public class HonorDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HonorDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HonorData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HonorData>>> GetHonorData()
        {
            return await _context.HonorData.ToListAsync();
        }

        // GET: api/HonorData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HonorData>> GetHonorData(int id)
        {
            var honorData = await _context.HonorData.FindAsync(id);

            if (honorData == null)
            {
                return NotFound();
            }

            return honorData;
        }

        // PUT: api/HonorData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHonorData(int id, HonorData honorData)
        {
            if (id != honorData.Id)
            {
                return BadRequest();
            }

            _context.Entry(honorData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HonorDataExists(id))
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

        // POST: api/HonorData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HonorData>> PostHonorData(HonorData honorData)
        {
            _context.HonorData.Add(honorData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HonorDataExists(honorData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHonorData", new { id = honorData.Id }, honorData);
        }

        // DELETE: api/HonorData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHonorData(int id)
        {
            var honorData = await _context.HonorData.FindAsync(id);
            if (honorData == null)
            {
                return NotFound();
            }

            _context.HonorData.Remove(honorData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HonorDataExists(int id)
        {
            return _context.HonorData.Any(e => e.Id == id);
        }
    }
}
