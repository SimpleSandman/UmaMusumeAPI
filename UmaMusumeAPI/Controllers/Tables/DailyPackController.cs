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
    public class DailyPackController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyPackController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyPack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyPack>>> GetDailyPacks()
        {
            return await _context.DailyPacks.ToListAsync();
        }

        // GET: api/DailyPack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyPack>> GetDailyPack(int id)
        {
            var dailyPack = await _context.DailyPacks.FindAsync(id);

            if (dailyPack == null)
            {
                return NotFound();
            }

            return dailyPack;
        }

        // PUT: api/DailyPack/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailyPack(int id, DailyPack dailyPack)
        {
            if (id != dailyPack.ShopDataId)
            {
                return BadRequest();
            }

            _context.Entry(dailyPack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyPackExists(id))
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

        // POST: api/DailyPack
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DailyPack>> PostDailyPack(DailyPack dailyPack)
        {
            _context.DailyPacks.Add(dailyPack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DailyPackExists(dailyPack.ShopDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDailyPack", new { id = dailyPack.ShopDataId }, dailyPack);
        }

        // DELETE: api/DailyPack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDailyPack(int id)
        {
            var dailyPack = await _context.DailyPacks.FindAsync(id);
            if (dailyPack == null)
            {
                return NotFound();
            }

            _context.DailyPacks.Remove(dailyPack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DailyPackExists(int id)
        {
            return _context.DailyPacks.Any(e => e.ShopDataId == id);
        }
    }
}
