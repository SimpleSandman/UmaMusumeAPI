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
    public class LegendRaceBossNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceBossNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceBossNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceBossNpc>>> GetLegendRaceBossNpcs()
        {
            return await _context.LegendRaceBossNpcs.ToListAsync();
        }

        // GET: api/LegendRaceBossNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceBossNpc>> GetLegendRaceBossNpc(int id)
        {
            var legendRaceBossNpc = await _context.LegendRaceBossNpcs.FindAsync(id);

            if (legendRaceBossNpc == null)
            {
                return NotFound();
            }

            return legendRaceBossNpc;
        }

        // PUT: api/LegendRaceBossNpc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegendRaceBossNpc(int id, LegendRaceBossNpc legendRaceBossNpc)
        {
            if (id != legendRaceBossNpc.Id)
            {
                return BadRequest();
            }

            _context.Entry(legendRaceBossNpc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegendRaceBossNpcExists(id))
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

        // POST: api/LegendRaceBossNpc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LegendRaceBossNpc>> PostLegendRaceBossNpc(LegendRaceBossNpc legendRaceBossNpc)
        {
            _context.LegendRaceBossNpcs.Add(legendRaceBossNpc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LegendRaceBossNpcExists(legendRaceBossNpc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLegendRaceBossNpc", new { id = legendRaceBossNpc.Id }, legendRaceBossNpc);
        }

        // DELETE: api/LegendRaceBossNpc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegendRaceBossNpc(int id)
        {
            var legendRaceBossNpc = await _context.LegendRaceBossNpcs.FindAsync(id);
            if (legendRaceBossNpc == null)
            {
                return NotFound();
            }

            _context.LegendRaceBossNpcs.Remove(legendRaceBossNpc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegendRaceBossNpcExists(int id)
        {
            return _context.LegendRaceBossNpcs.Any(e => e.Id == id);
        }
    }
}
