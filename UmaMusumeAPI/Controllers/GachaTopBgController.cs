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
    public class GachaTopBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaTopBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaTopBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaTopBg>>> GetGachaTopBgs()
        {
            return await _context.GachaTopBgs.ToListAsync();
        }

        // GET: api/GachaTopBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaTopBg>> GetGachaTopBg(int id)
        {
            var gachaTopBg = await _context.GachaTopBgs.FindAsync(id);

            if (gachaTopBg == null)
            {
                return NotFound();
            }

            return gachaTopBg;
        }

        // PUT: api/GachaTopBg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGachaTopBg(int id, GachaTopBg gachaTopBg)
        {
            if (id != gachaTopBg.Id)
            {
                return BadRequest();
            }

            _context.Entry(gachaTopBg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GachaTopBgExists(id))
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

        // POST: api/GachaTopBg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GachaTopBg>> PostGachaTopBg(GachaTopBg gachaTopBg)
        {
            _context.GachaTopBgs.Add(gachaTopBg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GachaTopBgExists(gachaTopBg.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGachaTopBg", new { id = gachaTopBg.Id }, gachaTopBg);
        }

        // DELETE: api/GachaTopBg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGachaTopBg(int id)
        {
            var gachaTopBg = await _context.GachaTopBgs.FindAsync(id);
            if (gachaTopBg == null)
            {
                return NotFound();
            }

            _context.GachaTopBgs.Remove(gachaTopBg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GachaTopBgExists(int id)
        {
            return _context.GachaTopBgs.Any(e => e.Id == id);
        }
    }
}
