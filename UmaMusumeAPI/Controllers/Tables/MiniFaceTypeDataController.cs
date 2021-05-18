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
    public class MiniFaceTypeDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniFaceTypeDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniFaceTypeData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniFaceTypeData>>> GetMiniFaceTypeData()
        {
            return await _context.MiniFaceTypeData.ToListAsync();
        }

        // GET: api/MiniFaceTypeData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniFaceTypeData>> GetMiniFaceTypeData(string id)
        {
            var miniFaceTypeData = await _context.MiniFaceTypeData.FindAsync(id);

            if (miniFaceTypeData == null)
            {
                return NotFound();
            }

            return miniFaceTypeData;
        }

        // PUT: api/MiniFaceTypeData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMiniFaceTypeData(string id, MiniFaceTypeData miniFaceTypeData)
        {
            if (id != miniFaceTypeData.Label)
            {
                return BadRequest();
            }

            _context.Entry(miniFaceTypeData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiniFaceTypeDataExists(id))
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

        // POST: api/MiniFaceTypeData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MiniFaceTypeData>> PostMiniFaceTypeData(MiniFaceTypeData miniFaceTypeData)
        {
            _context.MiniFaceTypeData.Add(miniFaceTypeData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MiniFaceTypeDataExists(miniFaceTypeData.Label))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMiniFaceTypeData", new { id = miniFaceTypeData.Label }, miniFaceTypeData);
        }

        // DELETE: api/MiniFaceTypeData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMiniFaceTypeData(string id)
        {
            var miniFaceTypeData = await _context.MiniFaceTypeData.FindAsync(id);
            if (miniFaceTypeData == null)
            {
                return NotFound();
            }

            _context.MiniFaceTypeData.Remove(miniFaceTypeData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MiniFaceTypeDataExists(string id)
        {
            return _context.MiniFaceTypeData.Any(e => e.Label == id);
        }
    }
}
