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
    public class LegendRaceNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceNpc>>> GetLegendRaceNpcs()
        {
            return await _context.LegendRaceNpcs.ToListAsync();
        }

        // GET: api/LegendRaceNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceNpc>> GetLegendRaceNpc(int id)
        {
            var legendRaceNpc = await _context.LegendRaceNpcs.FindAsync(id);

            if (legendRaceNpc == null)
            {
                return NotFound();
            }

            return legendRaceNpc;
        }

        // PUT: api/LegendRaceNpc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegendRaceNpc(int id, LegendRaceNpc legendRaceNpc)
        {
            if (id != legendRaceNpc.Id)
            {
                return BadRequest();
            }

            _context.Entry(legendRaceNpc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegendRaceNpcExists(id))
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

        // POST: api/LegendRaceNpc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LegendRaceNpc>> PostLegendRaceNpc(LegendRaceNpc legendRaceNpc)
        {
            _context.LegendRaceNpcs.Add(legendRaceNpc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LegendRaceNpcExists(legendRaceNpc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLegendRaceNpc", new { id = legendRaceNpc.Id }, legendRaceNpc);
        }

        // DELETE: api/LegendRaceNpc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegendRaceNpc(int id)
        {
            var legendRaceNpc = await _context.LegendRaceNpcs.FindAsync(id);
            if (legendRaceNpc == null)
            {
                return NotFound();
            }

            _context.LegendRaceNpcs.Remove(legendRaceNpc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegendRaceNpcExists(int id)
        {
            return _context.LegendRaceNpcs.Any(e => e.Id == id);
        }
    }
}
