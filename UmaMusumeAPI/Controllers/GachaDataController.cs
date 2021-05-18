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
    public class GachaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaData>>> GetGachaData()
        {
            return await _context.GachaData.ToListAsync();
        }

        // GET: api/GachaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaData>> GetGachaData(int id)
        {
            var gachaData = await _context.GachaData.FindAsync(id);

            if (gachaData == null)
            {
                return NotFound();
            }

            return gachaData;
        }

        // PUT: api/GachaData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaData(int id, GachaData gachaData)
        {
            if (id != gachaData.Id)
            {
                return BadRequest();
            }

            _context.Entry(gachaData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaDataExists(id))
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

        // POST: api/GachaData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaData>> PostGachaData(GachaData gachaData)
        {
            _context.GachaData.Add(gachaData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaDataExists(gachaData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaData", new { id = gachaData.Id }, gachaData);
        }

        // DELETE: api/GachaData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaData(int id)
        {
            var gachaData = await _context.GachaData.FindAsync(id);
            if (gachaData == null)
            {
                return NotFound();
            }

            _context.GachaData.Remove(gachaData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaDataExists(int id)
        {
            return _context.GachaData.Any(e => e.Id == id);
        }
    }
}
