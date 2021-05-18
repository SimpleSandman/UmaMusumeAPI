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
    public class SupportCardLimitController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardLimitController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardLimit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardLimit>>> GetSupportCardLimits()
        {
            return await _context.SupportCardLimits.ToListAsync();
        }

        // GET: api/SupportCardLimit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardLimit>> GetSupportCardLimit(int id)
        {
            var supportCardLimit = await _context.SupportCardLimits.FindAsync(id);

            if (supportCardLimit == null)
            {
                return NotFound();
            }

            return supportCardLimit;
        }

        // PUT: api/SupportCardLimit/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardLimit(int id, SupportCardLimit supportCardLimit)
        {
            if (id != supportCardLimit.Rarity)
            {
                return BadRequest();
            }

            _context.Entry(supportCardLimit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardLimitExists(id))
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

        // POST: api/SupportCardLimit
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardLimit>> PostSupportCardLimit(SupportCardLimit supportCardLimit)
        {
            _context.SupportCardLimits.Add(supportCardLimit);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardLimitExists(supportCardLimit.Rarity))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardLimit", new { id = supportCardLimit.Rarity }, supportCardLimit);
        }

        // DELETE: api/SupportCardLimit/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardLimit(int id)
        {
            var supportCardLimit = await _context.SupportCardLimits.FindAsync(id);
            if (supportCardLimit == null)
            {
                return NotFound();
            }

            _context.SupportCardLimits.Remove(supportCardLimit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardLimitExists(int id)
        {
            return _context.SupportCardLimits.Any(e => e.Rarity == id);
        }
    }
}
