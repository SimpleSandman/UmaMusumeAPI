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
    public class GachaAvailableController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaAvailableController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaAvailable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaAvailable>>> GetGachaAvailables()
        {
            return await _context.GachaAvailables.ToListAsync();
        }

        // GET: api/GachaAvailable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaAvailable>> GetGachaAvailable(int id)
        {
            var gachaAvailable = await _context.GachaAvailables.FindAsync(id);

            if (gachaAvailable == null)
            {
                return NotFound();
            }

            return gachaAvailable;
        }

        // PUT: api/GachaAvailable/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaAvailable(int id, GachaAvailable gachaAvailable)
        {
            if (id != gachaAvailable.GachaId)
            {
                return BadRequest();
            }

            _context.Entry(gachaAvailable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaAvailableExists(id))
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

        // POST: api/GachaAvailable
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaAvailable>> PostGachaAvailable(GachaAvailable gachaAvailable)
        {
            _context.GachaAvailables.Add(gachaAvailable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaAvailableExists(gachaAvailable.GachaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaAvailable", new { id = gachaAvailable.GachaId }, gachaAvailable);
        }

        // DELETE: api/GachaAvailable/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaAvailable(int id)
        {
            var gachaAvailable = await _context.GachaAvailables.FindAsync(id);
            if (gachaAvailable == null)
            {
                return NotFound();
            }

            _context.GachaAvailables.Remove(gachaAvailable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaAvailableExists(int id)
        {
            return _context.GachaAvailables.Any(e => e.GachaId == id);
        }
    }
}
