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
    public class SupportCardDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardData>>> GetSupportCardData()
        {
            return await _context.SupportCardData.ToListAsync();
        }

        // GET: api/SupportCardData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardData>> GetSupportCardData(int id)
        {
            var supportCardData = await _context.SupportCardData.FindAsync(id);

            if (supportCardData == null)
            {
                return NotFound();
            }

            return supportCardData;
        }

        // PUT: api/SupportCardData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardData(int id, SupportCardData supportCardData)
        {
            if (id != supportCardData.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportCardData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardDataExists(id))
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

        // POST: api/SupportCardData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardData>> PostSupportCardData(SupportCardData supportCardData)
        {
            _context.SupportCardData.Add(supportCardData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardDataExists(supportCardData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardData", new { id = supportCardData.Id }, supportCardData);
        }

        // DELETE: api/SupportCardData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardData(int id)
        {
            var supportCardData = await _context.SupportCardData.FindAsync(id);
            if (supportCardData == null)
            {
                return NotFound();
            }

            _context.SupportCardData.Remove(supportCardData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardDataExists(int id)
        {
            return _context.SupportCardData.Any(e => e.Id == id);
        }
    }
}
