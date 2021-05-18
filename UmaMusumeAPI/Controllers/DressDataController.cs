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
    public class DressDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DressDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DressData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DressData>>> GetDressData()
        {
            return await _context.DressData.ToListAsync();
        }

        // GET: api/DressData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DressData>> GetDressData(int id)
        {
            var dressData = await _context.DressData.FindAsync(id);

            if (dressData == null)
            {
                return NotFound();
            }

            return dressData;
        }

        // PUT: api/DressData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDressData(int id, DressData dressData)
        {
            if (id != dressData.Id)
            {
                return BadRequest();
            }

            _context.Entry(dressData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DressDataExists(id))
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

        // POST: api/DressData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DressData>> PostDressData(DressData dressData)
        {
            _context.DressData.Add(dressData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DressDataExists(dressData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDressData", new { id = dressData.Id }, dressData);
        }

        // DELETE: api/DressData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDressData(int id)
        {
            var dressData = await _context.DressData.FindAsync(id);
            if (dressData == null)
            {
                return NotFound();
            }

            _context.DressData.Remove(dressData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DressDataExists(int id)
        {
            return _context.DressData.Any(e => e.Id == id);
        }
    }
}
