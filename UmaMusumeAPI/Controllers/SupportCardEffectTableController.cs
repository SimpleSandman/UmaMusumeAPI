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
    public class SupportCardEffectTableController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardEffectTableController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardEffectTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardEffectTable>>> GetSupportCardEffectTables()
        {
            return await _context.SupportCardEffectTables.ToListAsync();
        }

        // GET: api/SupportCardEffectTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardEffectTable>> GetSupportCardEffectTable(int id)
        {
            var supportCardEffectTable = await _context.SupportCardEffectTables.FindAsync(id);

            if (supportCardEffectTable == null)
            {
                return NotFound();
            }

            return supportCardEffectTable;
        }

        // PUT: api/SupportCardEffectTable/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardEffectTable(int id, SupportCardEffectTable supportCardEffectTable)
        {
            if (id != supportCardEffectTable.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportCardEffectTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardEffectTableExists(id))
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

        // POST: api/SupportCardEffectTable
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardEffectTable>> PostSupportCardEffectTable(SupportCardEffectTable supportCardEffectTable)
        {
            _context.SupportCardEffectTables.Add(supportCardEffectTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardEffectTableExists(supportCardEffectTable.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardEffectTable", new { id = supportCardEffectTable.Id }, supportCardEffectTable);
        }

        // DELETE: api/SupportCardEffectTable/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardEffectTable(int id)
        {
            var supportCardEffectTable = await _context.SupportCardEffectTables.FindAsync(id);
            if (supportCardEffectTable == null)
            {
                return NotFound();
            }

            _context.SupportCardEffectTables.Remove(supportCardEffectTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardEffectTableExists(int id)
        {
            return _context.SupportCardEffectTables.Any(e => e.Id == id);
        }
    }
}
