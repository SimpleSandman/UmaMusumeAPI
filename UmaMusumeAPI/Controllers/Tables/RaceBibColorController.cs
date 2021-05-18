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
    public class RaceBibColorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBibColorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBibColor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBibColor>>> GetRaceBibColors()
        {
            return await _context.RaceBibColors.ToListAsync();
        }

        // GET: api/RaceBibColor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBibColor>> GetRaceBibColor(int id)
        {
            var raceBibColor = await _context.RaceBibColors.FindAsync(id);

            if (raceBibColor == null)
            {
                return NotFound();
            }

            return raceBibColor;
        }

        // PUT: api/RaceBibColor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceBibColor(int id, RaceBibColor raceBibColor)
        {
            if (id != raceBibColor.Grade)
            {
                return BadRequest();
            }

            _context.Entry(raceBibColor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceBibColorExists(id))
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

        // POST: api/RaceBibColor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceBibColor>> PostRaceBibColor(RaceBibColor raceBibColor)
        {
            _context.RaceBibColors.Add(raceBibColor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceBibColorExists(raceBibColor.Grade))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceBibColor", new { id = raceBibColor.Grade }, raceBibColor);
        }

        // DELETE: api/RaceBibColor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceBibColor(int id)
        {
            var raceBibColor = await _context.RaceBibColors.FindAsync(id);
            if (raceBibColor == null)
            {
                return NotFound();
            }

            _context.RaceBibColors.Remove(raceBibColor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceBibColorExists(int id)
        {
            return _context.RaceBibColors.Any(e => e.Grade == id);
        }
    }
}
